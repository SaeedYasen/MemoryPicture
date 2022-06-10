using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MemoryPicture
{
    public partial class login : Form
    {
        string level = "1";
        public string path = @"..\..\database\memorypic.accdb";

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lists f1 = new lists("user1",level);
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passlog.Visible = true;
            usernamelog.Visible = true;
            textBoxpasslog.Visible = true;
            textBoxuserlog.Visible = true;
            btnlogin.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            usernameup.Visible = true;
            nameup.Visible = true;
            passup.Visible = true;
            boxusername.Visible = true;
            textBoxname.Visible = true;
            textBoxpassup.Visible = true;
            sigupbtn.Visible = true;
            button2.Visible = false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + path);
            OleDbCommand cmdoledb = con.CreateCommand();
            OleDbDataAdapter da;
            DataTable dt = new DataTable();
            con.Open();


            da = new OleDbDataAdapter("select * from player where username='" + textBoxuserlog.Text + "' and pas='" + textBoxpasslog.Text + "'", con);

            try
            {
                da.Fill(dt);
                if (dt.Rows.Count <= 0)
                {

                }
                else if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Succsufully");
                    this.Hide();
                    lists f1 = new lists(textBoxuserlog.Text,level);
                    f1.Show();
                }
                else MessageBox.Show("password or username false");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            dt.Clear();

        }

        private void sigupbtn_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + path);
            OleDbCommand cmdoledb = con.CreateCommand();
            con.Open();

            String name = textBoxname.Text.ToString();
            String username = boxusername.Text.ToString();
            String pass = textBoxpassup.Text.ToString();
            String lev = "1";

            String my_querry = ("INSERT INTO player(name,username,pas) VALUES ('" + name + "','" + username + "','" + pass + "')");

            try
            {
                OleDbCommand cmd = new OleDbCommand(my_querry, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("success .. and u sholed log in");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
