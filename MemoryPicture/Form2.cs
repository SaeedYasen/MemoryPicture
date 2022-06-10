using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryPicture
{
    public partial class Form2 : Form
    {
        int pointFalse = 0, pointTrue = 0;
        DataSet ds = new DataSet();
        public string path = @"..\..\database\memorypic.accdb";
         int level = 1,lvl=1;
        int numberQ = 1, timeQ = 0;

        List<question> Lquestion = new List<question>();
        Image upPicture = Image.FromFile(@"..\..\pictures\\uppic.jpg");
        //  Image questiondb = null;

        Image DiceStop = Image.FromFile(@"..\..\pictures\\Dice.png");

        Image DicePlay = Image.FromFile(@"..\..\pictures\\DicePlay.gif");
        Image Dice1 = Image.FromFile(@"..\..\pictures\\dice1.png");
        Image Dice2 = Image.FromFile(@"..\..\pictures\\dice2.png");
        Image Dice3 = Image.FromFile(@"..\..\pictures\\dice3.png");
        Image Dice4 = Image.FromFile(@"..\..\pictures\\dice4.png");
        Image Dice5 = Image.FromFile(@"..\..\pictures\\dice5.png");
        Image Dice6 = Image.FromFile(@"..\..\pictures\\dice6.png");


        String GamerUser;
        bool user1 = true;
        bool user2 = false;
        int pointuser2 = 0;

        Random rnd = new Random();
        int numDICE;


        public Form2()
        {
            InitializeComponent();
        }
        public Form2(String name , int l)
        {
            level = l;
            GamerUser = name;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerDice.Stop();
            timerpic.Stop();
            timerQuestion.Stop();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            DialogResult result = MessageBox.Show("Are u reday for Game :) ");
            if (result == DialogResult.OK)
            {
                StartGame(user1,user2);
            }

        }

        private void LoadQuestion()
        {

            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path;
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("SELECT * from question WHERE idpicture='" + numberQ.ToString() + "'", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Lquestion.Add(new question(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));
                }
            }
        }

        private void StartGame(bool u1, bool u2)
        {

            Gamer2.Text = "שחקן 2 " + " נקודות : "+pointuser2;
            Gamer1.Text = "שחקן 1 " + " נקודות : "+ pointTrue;

            if (user1) { Gamer1.BackColor = Color.Green; pictureBox2.BackColor = Color.Green; }
            if (user2) { Gamer2.BackColor = Color.Green; pictureBox1.BackColor = Color.Green; }

            timerDice.Stop();
            timerpic.Stop();
            timerQuestion.Stop();
            DataPicture gic = new DataPicture(1);
            if(numberQ >= 11) { lvl = 2; }
            switch (lvl)
            {
                case 1: picture.Image = gic.getPictureLevel1(numberQ); break;
                case 2: picture.Image = gic.getPictureLevel2(numberQ); break;
                case 3: picture.Image = gic.getPictureLevel3(numberQ); break;
                case 4: picture.Image = gic.getPictureLevel4(numberQ); break;
                case 5: picture.Image = gic.getPictureLevel5(numberQ); break;
            }
            PICtimer.Visible = true;
            timerpic.Enabled = true;
            timerpic.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            leblClick.Visible = false;
          //  Dice.Visible = false;
            Dice.Image = DicePlay;
            timerDice.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            PICtimer.Visible = false;
            picture.Image = upPicture;
            timerpic.Stop();
            timerpic.Enabled = false;
            leblClick.Visible = true;
            Dice.Visible = true;
        }

        private void timerDice_Tick(object sender, EventArgs e)
        {
            int rn = rnd.Next(1, 6);
            numDICE = rn;
            switch (rn)
            {
                case 1:
                    Dice.Image = Dice1;
                    QBox1.BackColor = Color.Maroon;
                    Qlabel.Text = "Questions1";
                    ShowQuestion(rn);
                    break;
                case 2:
                    Dice.Image = Dice2;
                    QBox2.BackColor = Color.Maroon;
                    Qlabel.Text = "Questions2";
                    ShowQuestion(rn);
                    break;
                case 3:
                    Dice.Image = Dice3;
                    QBox3.BackColor = Color.Maroon;
                    Qlabel.Text = "Questions3";
                    ShowQuestion(rn);
                    break;
                case 4:
                    Dice.Image = Dice4;
                    QBox4.BackColor = Color.Maroon;
                    Qlabel.Text = "Questions4";
                    ShowQuestion(rn);
                    break;
                case 5:
                    Dice.Image = Dice5;
                    QBox5.BackColor = Color.Maroon;
                    Qlabel.Text = "Questions5";
                    ShowQuestion(rn);
                    break;
                case 6:
                    Dice.Image = Dice6;
                    QBox6.BackColor = Color.Maroon;
                    Qlabel.Text = "Questions6";
                    ShowQuestion(rn);
                    break;
            }
            timerDice.Stop();
        }

        private void ShowQuestion(int rn)
        {
            LoadQuestion();
            bkgQ.Visible = true;
            Qlabel.Visible = true;
            labelHQ.Visible = true;

            choice1.Visible = true;
            choice2.Visible = true;
            choice3.Visible = true;
            choice4.Visible = true;
            timerQuestion.Start();
            timerQut.Visible = true;

            Qlabel.Text = Lquestion[rn].gettxtquestion();
            choice1.Text = Lquestion[rn].getchoice1();
            choice2.Text = Lquestion[rn].getchoice2();
            choice3.Text = Lquestion[rn].getchoice3();
            choice4.Text = Lquestion[rn].getchoice4();
        }

        private void choice1_Click(object sender, EventArgs e)
        {
            if (choice1.Text == Lquestion[numDICE].getAnswer())
            {
                if(user1) pointTrue += 10;
                if(user2) pointuser2 += 10;
                choice1.BackColor = Color.Green;
            }
            else { choice1.BackColor = Color.Red; pointFalse += 1; ShowAnswer(); }
            button1.Visible = true;

        }

        private void choice2_Click(object sender, EventArgs e)
        {
            if (choice2.Text == Lquestion[numDICE].getAnswer())
            {
                if (user1) pointTrue += 10;
                if (user2) pointuser2 += 10;
                choice2.BackColor = Color.Green;
            }
            else { choice2.BackColor = Color.Red; pointFalse += 1; ShowAnswer(); }
            button1.Visible = true;

        }

        private void choice3_Click(object sender, EventArgs e)
        {
            if (choice3.Text == Lquestion[numDICE].getAnswer())
            {
                if (user1) pointTrue += 10;
                if (user2) pointuser2 += 10;
                choice3.BackColor = Color.Green;
            }
            else { choice3.BackColor = Color.Red; pointFalse += 1; ShowAnswer(); }
            button1.Visible = true;

        }

        private void choice4_Click(object sender, EventArgs e)
        {

            if (choice4.Text == Lquestion[numDICE].getAnswer())
            {
                if (user1) pointTrue += 10;
                if (user2) pointuser2 += 10;
                choice4.BackColor = Color.Green;
            }
            else { choice4.BackColor = Color.Red; pointFalse += 1; ShowAnswer(); }

            button1.Visible = true;

        }

        private void ShowAnswer()
        {
            if (choice1.Text == Lquestion[numDICE].getAnswer()) choice1.BackColor = Color.Green;
            if (choice2.Text == Lquestion[numDICE].getAnswer()) choice2.BackColor = Color.Green;
            if (choice3.Text == Lquestion[numDICE].getAnswer()) choice3.BackColor = Color.Green;
            if (choice4.Text == Lquestion[numDICE].getAnswer()) choice4.BackColor = Color.Green;
        }

        private void timerNextQ_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void EGame()
        {
            timerDice.Enabled = false;
            timerpic.Enabled = false;
            timerQuestion.Enabled = false;

            if (numberQ == 10 && pointTrue == 100)
            {
                EndGame endGame = new EndGame(GamerUser, pointTrue, "User2", pointuser2, timeQ, pointFalse , level);
                DialogResult dr = endGame.ShowDialog(this);
                this.Hide();
            }
            else
            {
                EndGame endGame = new EndGame(GamerUser, pointTrue, "User2", pointuser2, timeQ, pointFalse , level);
                DialogResult dr = endGame.ShowDialog(this);
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Dice.Image = DiceStop;
            Dice.Visible = false;
            QBox1.BackColor = Color.White;
            QBox2.BackColor = Color.White;
            QBox3.BackColor = Color.White;
            QBox4.BackColor = Color.White;
            QBox5.BackColor = Color.White;
            QBox6.BackColor = Color.White;
            choice1.BackColor = Color.White;
            choice2.BackColor = Color.White;
            choice3.BackColor = Color.White;
            choice4.BackColor = Color.White;

            labelHQ.Visible = false;
            bkgQ.Visible = false;
            Qlabel.Visible = false;
            choice1.Visible = false;
            choice2.Visible = false;
            choice3.Visible = false;
            choice4.Visible = false;
            timerQut.Visible = false;
            button1.Visible = false;
            Lquestion.Clear();
            numberQ++;
            if (user1) { user2 = true; user1 = false; }
            else { user1 = true; user2 = false; }
            Gamer1.BackColor = Color.White;pictureBox1.BackColor = Color.White;
            Gamer2.BackColor = Color.White; pictureBox2.BackColor = Color.White;
            if (pointTrue == 100) level++;
            if (numberQ == 3) EGame();
            StartGame(user1,user2);
        }

        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            bkgQ.Visible = false;
            Qlabel.Visible = false;
            choice1.Visible = false;
            choice2.Visible = false;
            choice3.Visible = false;
            choice4.Visible = false;
            timerQut.Visible = false;
            timeQ++;
            button1.Visible = true;
            timerQuestion.Stop();
        }
    }
}