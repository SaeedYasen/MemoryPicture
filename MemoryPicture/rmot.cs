using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryPicture
{
    public partial class rmot : Form
    {
        int l;string usergame;
        public rmot(string name,int i)
        {
            l = i;
            usergame = name;
            InitializeComponent();
        }

        private void rmot_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"..\..\pictures\\lock.png");

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            if (userName())
            {
                switch (l)
                {
                    case 1:
                        button2.Image = image; button2.Enabled = false;
                        button3.Image = image; button3.Enabled = false;
                        button4.Image = image; button4.Enabled = false;
                        button5.Image = image; button5.Enabled = false;

                        break;
                    case 2:
                        button3.Image = image; button3.Enabled = false;
                        button4.Image = image; button4.Enabled = false;
                        button5.Image = image; button5.Enabled = false;
                        break;
                    case 3:
                        button4.Image = image; button4.Enabled = false;
                        button5.Image = image; button5.Enabled = false;
                        break;
                    case 4:
                        button5.Image = image; button5.Enabled = false; break;
                }
            }
            else
            {
                button2.Image = image; button2.Enabled = false;
                button3.Image = image; button3.Enabled = false;
                button4.Image = image; button4.Enabled = false;
                button5.Image = image; button5.Enabled = false;
            }
        }

        public bool userName()
        {
            if (usergame == "user1") return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game1.Visible = true;
            game2.Visible = true;
            game3.Visible = true;
            game4.Visible = true;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(usergame,l);
            this.Hide();
            f.Show();
        }

        private void game2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(usergame, l);
            this.Hide();
            f.Show();
        }

        private void game1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(usergame, l);
            this.Hide();
            f.Show();
        }

        private void game4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4(usergame, l);
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game1.Visible = true;
            game2.Visible = true;
            game3.Visible = true;
            game4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game1.Visible = true;
            game2.Visible = true;
            game3.Visible = true;
            game4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game1.Visible = true;
            game2.Visible = true;
            game3.Visible = true;
            game4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            game1.Visible = true;
            game2.Visible = true;
            game3.Visible = true;
            game4.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            lists ls = new lists(usergame,l+"");
            ls.Show();
        }
    }
}
