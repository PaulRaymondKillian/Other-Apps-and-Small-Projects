using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartyMusicManager
{
    public partial class frmManageMusicLibrary : Form
    {
        private PartyMusicManagerLib _PartyMusicManagerLib;

        public frmManageMusicLibrary(PartyMusicManagerLib pPartyMusicManagerLib)
        {
            InitializeComponent();
            _PartyMusicManagerLib = pPartyMusicManagerLib;
        }

        public void SetAddDirectory()
        {
            rdoAddDirectory.Checked = true;
        }//SetAddDirectory

        public void SetAddFile()
        {
            rdoAddFile.Checked = true;
        }//SetAddDirectory

        private void rdoAddDirectory_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAddDirectory.Checked == true)
            {
                txtAddDirectory.Enabled = true;
                btnxAddDirectory.Enabled = true;
                txtAddFile.Enabled = false;
                txtAddFile.Text = "";
                btnxAddFile.Enabled = false;
            }
        }

        private void rdoAddFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAddFile.Checked == true)
            {
                txtAddDirectory.Enabled = false;
                btnxAddDirectory.Enabled = false;
                txtAddFile.Enabled = true;
                txtAddDirectory.Text = "";
                btnxAddFile.Enabled = true;
            }
        }

        private void btnxAddDirectory_Click(object sender, EventArgs e)
        {
            if (fbdAddDirectory.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtAddDirectory.Text = fbdAddDirectory.SelectedPath;

        }

        private void btnxAddFile_Click(object sender, EventArgs e)
        {
            if (ofdAddFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtAddFile.Text = ofdAddFile.FileName;
        }

        private void btnSaveToLibrary_Click(object sender, EventArgs e)
        {
            if (rdoAddDirectory.Checked == true)
            {
                if (txtAddDirectory.Text != "")
                {
                    _PartyMusicManagerLib.AddMusicDirectoryToLibrary(txtAddDirectory.Text);
                }
            }
            else
            {
                if (txtAddFile.Text != "")
                {
                    _PartyMusicManagerLib.AddMusicFileToLibrary(txtAddFile.Text);
                }
            }
        }
    }
}
