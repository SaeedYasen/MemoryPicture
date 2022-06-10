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
    public partial class levels : Form
    {
        Image LevelLock = Image.FromFile(@"..\..\pictures\\lock.png");
        int level;
        public levels()
        {
            InitializeComponent();
        }
        public levels(int lvl)
        {
            level = lvl;
            IflEVEL();
            InitializeComponent();
        }

        private bool whatLevel()
        {
            switch (level)
            {
                case 1:
                    level2.BackgroundImage = LevelLock;
                    level3.BackgroundImage = LevelLock;
                    level4.BackgroundImage = LevelLock;
                    level5.BackgroundImage = LevelLock;
                    return true;
                case 2:
                    level3.BackgroundImage = LevelLock;
                    level4.BackgroundImage = LevelLock;
                    level5.BackgroundImage = LevelLock;
                    return true;
                case 3:
                    level4.BackgroundImage = LevelLock;
                    level5.BackgroundImage = LevelLock;
                    return true;
                case 4:
                    level5.BackgroundImage = LevelLock;
                    return true;
            }
            return false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            lists ls = new lists();
            ls.Show();
        }

        private void levels_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;



        }
        private void level1_Click(object sender, EventArgs e)
        {
                GamerUpdate();
        }

        private void GamerUpdate()
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

        }

        public void IflEVEL()
        {

        }

        private void level2_Click(object sender, EventArgs e)
        {

                GamerUpdate();

        }

        private void level3_Click(object sender, EventArgs e)
        {

                GamerUpdate();

        }

        private void level4_Click(object sender, EventArgs e)
        {

                GamerUpdate();
        }

        private void level5_Click(object sender, EventArgs e)
        {
                GamerUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            this.Hide();
            f.Show();
        }
    }
}
