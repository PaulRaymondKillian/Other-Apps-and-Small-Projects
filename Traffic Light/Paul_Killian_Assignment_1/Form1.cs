using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Paul_Killian_Assignment_1
{
    public partial class Form1 : Form
    {
        // Declare private variables / class members
        private About frmAbout;
        private Help frmHelp;
        private List<Team> cList;
        private string filename; // for File I/O

        public Form1()
        {
            InitializeComponent();
            InitializeAppCode();
        }

        private void InitializeAppCode()
        {
            frmAbout = new About();
            frmHelp = new Help();
            cList = new List<Team>();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Note: First column is the "key".
            Team c = new Team(txtTeamName.Text, txtCity.Text, txtState.Text);

            // Add to list for later use.
            cList.Add(c);
            //string tabContact = Contact.ToTabString(c);
            //MessageBox.Show("Tab string is:\n" + Contact.ToTabString(c));
            //Contact newContact = Contact.FromTabString(tabContact);
            //MessageBox.Show("From Tab String is: " + newContact.ToString());

            ListViewItem item = new ListViewItem(c.TeamName);
            item.SubItems.Add(c.TeamCity);
            item.SubItems.Add(c.TeamState);
            teamListView.Items.Add(item);
            txtTeamName.Focus();
            txtTeamName.SelectAll();
        }

        private void RefreshListViewFromClist()
        {
            teamListView.Items.Clear();
            foreach (Team c in cList)
            {
                ListViewItem item = new ListViewItem(c.TeamName);
                item.SubItems.Add(c.TeamCity);
                item.SubItems.Add(c.TeamState);
                teamListView.Items.Add(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Not yet implemented");
            ListView.SelectedIndexCollection rowsToDelete
                = teamListView.SelectedIndices;
            foreach (int ix in rowsToDelete)
            {
                // Find it in the list and delete it.
                // first take listview data and create a contact.
                Team c = new Team(
                    teamListView.Items[ix].SubItems[0].Text,
                    teamListView.Items[ix].SubItems[1].Text,
                    teamListView.Items[ix].SubItems[2].Text);
                // Next remove from list
                if (!cList.Remove(c))
                    MessageBox.Show("Team "
                    + c.TeamName + " " + c.TeamCity + " " + c.TeamState
                    + " was NOT REMOVED.");
            }
            // refresh from clist
            RefreshListViewFromClist();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            cList.Sort();
            RefreshListViewFromClist();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout.Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHelp.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadContactsFromFile()
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Open,
                    FileAccess.Read, FileShare.Read);
                StreamReader sr = new StreamReader(fs);
                string strTeam;
                cList.Clear();
                while (!sr.EndOfStream)
                {
                    strTeam = sr.ReadLine();
                    cList.Add(Team.FromTabString(strTeam));
                }
                sr.Close();
                RefreshListViewFromClist();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error reading from file: \n" + ex.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.DefaultExt = "txt";
            if (filename == "")
                openFileDialog1.FileName = "Teams.txt";
            else
            {
                openFileDialog1.FileName = filename;
            }
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.CheckFileExists = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                loadContactsFromFile();
            }
        }

        private void saveContactsToFile()
        {
            try
            {
                FileStream fs =
                    new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (Team c in cList)
                {
                    sw.WriteLine(c.ToTabString());
                }
                sw.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error saving to file: \n" + ex.Message);
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Feature Not Yet Implemented.");
            // Get a filename by invoking save file dialog
            // First set up the dialog
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.OverwritePrompt = true;

            // now invoke the dialog
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                saveContactsToFile();
            }
        }

    }
}