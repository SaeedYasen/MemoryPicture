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
    public partial class lists : Form
    {
        public string path = @"..\..\database\memorypic.accdb";
        string levels="1";
        string NameGamer;
        public lists()
        {
            InitializeComponent();
        }
        public lists(String username,string level)
        {
            InitializeComponent();
            NameGamer = username;
            levels = level;
            if (NameGamer != "user1")
            {
                string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path;
                using (OleDbConnection connection = new OleDbConnection(connString))
                {
                    connection.Open();
                    OleDbDataReader reader = null;
                    OleDbCommand command = new OleDbCommand("SELECT * from player WHERE username='" + username + "'", connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        levels = reader[7].ToString();

                    }
                    if (levels == "") levels = "1";
                }
            }
            else
            {
                button6.Enabled = false;
                button3.Enabled = false;

            }
            name.Text = username+ " ברוך הבא למשחק הזכרון"  ;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button8.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }

        private void lists_Load(object sender, EventArgs e)
        {
            
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login ls = new login();
            ls.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile(NameGamer);
            profile.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(NameGamer, Convert.ToInt32(levels));
            f1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            listpoint f1 = new listpoint();
            f1.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if (NameGamer != "user1")
            {
                rmot f1 = new rmot(NameGamer,Convert.ToInt32(levels));
                f1.Show();
            }
            else
            {
                rmot f2 = new rmot(NameGamer, 3);
                f2.Show();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HelpGame f1 = new HelpGame();
            f1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f1 = new Form2(NameGamer, Convert.ToInt32(levels));
            f1.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f1 = new Form3(NameGamer, Convert.ToInt32(levels));
            f1.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f1 = new Form4(NameGamer, Convert.ToInt32(levels));
            f1.Show();
        }
    }
}
