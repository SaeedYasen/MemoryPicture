using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryPicture
{
    public partial class EndGame : Form
    {
        string user1, user2, user3, user4;
        int pointTure1, point2, point3, point4;
        int pointFalse = 0, pointTimer = 0, lvl = 1 , a;
        public string path = @"..\..\database\memorypic.accdb";


        public EndGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lists lists = new lists(user1, lvl + "");
            this.Hide();
            lists.Show();
        }

        public EndGame(string name,int PointTrue , int Tq , int PFlase , int levl)
        {
            InitializeComponent();
            user1 = name;pointFalse = PFlase; pointTimer = Tq;lvl = levl;
            pointTure1 = PointTrue;
            gamer1.Text = name; p1.Text = PointTrue.ToString();
  
            gamer2.Visible = false; gamer3.Visible = false; gamer4.Visible = false;
            p2.Visible = false; p2.Visible = false; p2.Visible = false;


        }
        public EndGame(string name1, int PointTrue1, string name2, int PointTrue2, int Tq, int PFlase , int level)
        {
            InitializeComponent();
            user1 = name1; pointTure1 = PointTrue1; pointFalse = PFlase; pointTimer = Tq; lvl = level; 
            user2 = name2;point2 = PointTrue2;

            gamer1.Text = name1; p1.Text = PointTrue1.ToString();
            gamer2.Text = name2; p2.Text = PointTrue2.ToString();

            gamer2.Visible = true; gamer3.Visible = false; gamer4.Visible = false;
            p2.Visible = true; p3.Visible = false; p4.Visible = false;
        }
        public EndGame(string name1, int PointTrue1, string name2, int PointTrue2, string name3, int PointTrue3 , int Tq , int PFlase,int level)
        {
            InitializeComponent();
            user1 = name1; pointTure1 = PointTrue1; pointFalse = PFlase; pointTimer = Tq; lvl = level;
            user2 = name2; point2 = PointTrue2;
            user3 = name3; point3 = PointTrue3;

            gamer1.Text = name1; p1.Text = PointTrue1.ToString();
            gamer2.Text = name2; p2.Text = PointTrue2.ToString();
            gamer3.Text = name3; p3.Text = PointTrue3.ToString();

            gamer2.Visible = true; gamer3.Visible = true; gamer4.Visible = false;
            p2.Visible = true; p3.Visible = true; p4.Visible = false;
        }
        public EndGame(string name1, int PointTrue1, string name2, int PointTrue2, string name3, int PointTrue3, string name4, int PointTrue4, int Tq, int PFlase,int level)
        {
            InitializeComponent();
            user1 = name1; pointTure1 = PointTrue1; pointFalse = PFlase; pointTimer = Tq; lvl = level;
            user2 = name2; point2 = PointTrue2;
            user3 = name3; point3 = PointTrue3;
            user4 = name4; point4 = PointTrue4;

            gamer1.Text = name1; p1.Text = PointTrue1.ToString();
            gamer2.Text = name2; p2.Text = PointTrue2.ToString();
            gamer3.Text = name3; p3.Text = PointTrue3.ToString();
            gamer4.Text = name4; p4.Text = PointTrue4.ToString();

            gamer2.Visible = true; gamer3.Visible = true; gamer4.Visible = true;
            p2.Visible = true; p3.Visible = true; p4.Visible = true;

        }

               

        private void EndGame_Load(object sender, EventArgs e)
        {
            if (IfUser(user1))
            {
                using (OleDbConnection connection = new OleDbConnection(string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + path)))
                {
                    using (OleDbCommand updateCommand = new OleDbCommand("UPDATE player SET [point] = ?, [false] = ?, [true] = ?, [timee] = ?, [level] = ? WHERE [username] = ?", connection))
                    {
                        connection.Open();

                        updateCommand.Parameters.AddWithValue("@point", pointTure1);
                        updateCommand.Parameters.AddWithValue("@false", pointFalse);
                        updateCommand.Parameters.AddWithValue("@true",  (pointTure1/10));
                        updateCommand.Parameters.AddWithValue("@timee", pointTimer);
                        updateCommand.Parameters.AddWithValue("@level", lvl+"");
                        updateCommand.Parameters.AddWithValue("@id",user1);


                        updateCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record updated", "Contacts", MessageBoxButtons.OK);
            }
        }

        public bool IfUser(string u1)
        {
            if (u1 == "user1") return false;
            else return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
