using System;
using System.Collections.Generic;
using System.Text;

namespace Paul_Killian_Assignment_1
{
    /// <summary>
    /// Contains people who are contacts.
    /// </summary>
    class Team : IComparable<Team>, IEquatable<Team>
    {

        // Data members
        string Name;
        string City;
        string State;

        //Constructors
        public Team()
        {
            Name = "";
            City = "";
            State = "";
        }

        /// <summary>
        /// Id is set and First and last Name required.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Team(string tempTeamName, string tempCity, string tempState)
        {
            Name = tempTeamName;
            City = tempCity;
            State = tempState;
        }

        // Properties

        /// <summary>
        /// Team Name
        /// </summary>
        public string TeamName
        {
            get { return Name; }
            set
            {
                if (value != null && value != "")
                    TeamName = value;
                else
                {
                    throw new ArgumentException("Team Name is required");
                }
            }
        }

        /// <summary>
        /// City is required to have a value.
        /// </summary>
        public string TeamCity
        {
            get { return City; }
            set
            {
                if (value != null && value != "")
                    City = value;
                else
                {
                    throw new ArgumentException("Team City is required");
                }
            }
        }

        /// <summary>
        /// State is required to have a value.
        /// </summary>
        public string TeamState
        {
            get { return State; }
            set
            {
                if (value != null && value != "")
                    State = value;
                else
                {
                    throw new ArgumentException("Team State is required");
                }
            }
        }

        public string ToTabString()
        {
            string tabString = TeamName + "\t"
                + TeamCity + "\t"
                + TeamState;
            return tabString;
        }

        public static Team FromTabString(string strTeam)
        {
            Team c;
            try
            {
                string[] strData = strTeam.Split('\t');
                string tName = strData[0];
                string tCity = strData[1];
                string tState = strData[2];
                c = new Team(tName, tCity, tState);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(
                    "Error: cannot convert from string:\n"
                + strTeam + "\nto a contact object."
                + "Error Msg: " + ex.Message);
                throw; // rethrow
            }
            return c;
        }

        // Interface methods
        public int CompareTo(Team rhs)
        {
			//return this.id.CompareTo(rhs.id);
			string strLhs;
			string strRhs;
			strLhs = this.TeamName + this.TeamCity + this.TeamState;
			strRhs = rhs.TeamName + rhs.TeamCity + rhs.TeamState;

			return strLhs.CompareTo(strRhs);
		}

        public bool Equals(Team rhs)
        {
            return this.TeamName.Equals(rhs.TeamName);
        }

    }
}
