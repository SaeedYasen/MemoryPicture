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
    public partial class Profile : Form
    {
        float g;
        public string path = @"..\..\database\memorypic.accdb";
        int idgamer;
        int gardee=0,a=0,b=0,c=0;
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(String user)
        {
            InitializeComponent();
            nameplayer.Text = user;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            ShowProflie();
        }

        private void ShowProflie()
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + path);

                con.Open();
                OleDbCommand cmdoledb = con.CreateCommand();
                cmdoledb.Connection = con;
                string query = "select * from player where username='" + nameplayer.Text + "'";
                cmdoledb.CommandText = query;
                OleDbDataReader reader = cmdoledb.ExecuteReader();
                while (reader.Read())
                {
                    levels.Text = reader["level"].ToString();
                    lfalse.Text = reader["false"].ToString();
                    lpoints.Text = reader["point"].ToString();
                    ltimee.Text = reader["timee"].ToString();
                    lnamegamer.Text = reader["name"].ToString();
                    idgamer = Convert.ToInt32(reader["id"].ToString());
                    //memory garde
                    //  label3.Text = lpoints.Text  / (lpoints.Text + lfalse.Text)*100;
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            if (levels.Text == "") levels.Text = "1";
            if (lfalse.Text == "") lfalse.Text = "0";
            if (ltimee.Text == "") ltimee.Text = "0";
            if (lpoints.Text == "") { lpoints.Text = "0"; gardee = 0; } else gardee = Convert.ToInt32(lpoints.Text);

        //    a = Convert.ToInt32(lpoints.Text);
        //    b = Convert.ToInt32(lfalse.Text);

            //   c = (a/(a+b))*100;
            lgarede.Text = gardee + "%";
            if (ShowpicGold(gardee)) { pictureGold.Visible = true; }
        }

        public bool ShowpicGold(int g)
        {
            if (g == 100) return true;
            else return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("are u sure");
                using (OleDbConnection connection = new OleDbConnection(string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + path)))
                {
                    using (OleDbCommand updateCommand = new OleDbCommand("UPDATE player SET [point] = ?, [false] = ?, [true] = ?, [timee] = ?, [level] = ? WHERE [id] = ?", connection))
                    {
                        connection.Open();

                        updateCommand.Parameters.AddWithValue("@point", "0");
                        updateCommand.Parameters.AddWithValue("@false", "0");
                        updateCommand.Parameters.AddWithValue("@true", "0");
                        updateCommand.Parameters.AddWithValue("@timee", "0");
                        updateCommand.Parameters.AddWithValue("@level", "1");
                        updateCommand.Parameters.AddWithValue("@id", idgamer);


                        updateCommand.ExecuteNonQuery();
                    }
                }
            ShowProflie();
        }

        private void lnamegamer_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IfUser(nameplayer.Text))
            {
                this.Hide();
                lists f1 = new lists(nameplayer.Text, levels.Text);
                f1.Show();
            }
            else
            {
                this.Hide();
                lists f1 = new lists("user1", "1");
                f1.Show();
            }
        }
        public bool IfUser(string s)
        {
            if (s == "User1") return false;
            return true;
        }
    }
}
