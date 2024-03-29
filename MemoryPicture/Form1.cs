﻿using System;
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


    public partial class Form1 : Form
    {

        String UserGamer;
        int timeQ=0;
        int pointFalse = 0 , pointTrue = 0;
        public string path = @"..\..\database\memorypic.accdb";
        int level = 1;
       
        int numberQ =1;
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


        Random rnd = new Random();
        int numDICE;


        public Form1()
        { 
            InitializeComponent();
        }
        public Form1(String name , int l)
        {
            level = l;
            UserGamer = name;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            lists l = new lists();
            l.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerDice.Stop();
            timerpic.Stop();
            timerQuestion.Stop();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            DialogResult result = MessageBox.Show("Are u reday for Game :) ");
            if(result == DialogResult.OK)
            {
                StartGame();
            }

        }

        private void LoadQuestion()
        {

            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path;
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("SELECT * from question WHERE idpicture='"+numberQ.ToString()+"'", connection);
              //  command.Parameters.AddWithValue("@1","1");
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                   // MessageBox.Show("adding");
                    Lquestion.Add(new question(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));
                }
            }
        }

        private void StartGame()
        {
            timerDice.Stop();
            timerpic.Stop();
            timerQuestion.Stop();
            DataPicture gic= new DataPicture(level);
            switch (level)
            {
                case 1: picture.Image = gic.getPictureLevel1(numberQ); break;
                case 2: picture.Image = gic.getPictureLevel2(numberQ); break;
                case 3: picture.Image = gic.getPictureLevel3(numberQ); break;
                case 4: picture.Image = gic.getPictureLevel4(numberQ); break;
                case 5: picture.Image = gic.getPictureLevel5(numberQ); break;
            }
            picture.Image = gic.getPictureLevel1(numberQ);
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
            leblClick.Visible = false;
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
            int rn=rnd.Next(1, 6);
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
             labelHQ.Visible = true;

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
                pointTrue += 10;
                choice1.BackColor = Color.Green;
            }
            else { choice1.BackColor = Color.Red; pointFalse += 1; ShowAnswer(); }
            button1.Visible = true;

        }

        private void choice2_Click(object sender, EventArgs e)
        {
            if (choice2.Text == Lquestion[numDICE].getAnswer())
            {
                pointTrue += 10;
                choice2.BackColor = Color.Green;
            }
            else { choice2.BackColor = Color.Red; pointFalse += 1; ShowAnswer(); }
            button1.Visible = true;

        }

        private void choice3_Click(object sender, EventArgs e)
        {
            if (choice3.Text == Lquestion[numDICE].getAnswer())
            {
                pointTrue += 10;
                choice3.BackColor = Color.Green;
            }
            else { choice3.BackColor = Color.Red; pointFalse += 1; ShowAnswer(); }
            button1.Visible = true;

        }

        private void choice4_Click(object sender, EventArgs e)
        {

            if (choice4.Text == Lquestion[numDICE].getAnswer())
            {
                pointTrue += 10;
                choice4.BackColor = Color.Green;
            }
            else { choice4.BackColor = Color.Red; pointFalse += 1;ShowAnswer(); }

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
            if (pointTrue == 100) level++;
            if(numberQ == 2 ) EGame(UserGamer);
            StartGame();
        }

        public void EGame(string user)
        {
            if (user != "user1")
            {
                if (numberQ == 10 && pointTrue == 100)
                {

                    EndGame endGamee = new EndGame(UserGamer, pointTrue, timeQ, pointFalse,level);
                    DialogResult dr1 = endGamee.ShowDialog(this);
                    this.Hide();

                }
                else
                {
                    EndGame end = new EndGame(UserGamer, pointTrue, timeQ, pointFalse,level);
                    DialogResult d = end.ShowDialog(this);
                    this.Hide();


                }
            }
            EndGame endGame = new EndGame(UserGamer, pointTrue, timeQ, pointFalse,level);
            DialogResult dr = endGame.ShowDialog(this);
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

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
            labelHQ.Visible = false;



            timeQ++;
            button1.Visible = true;//next question
            timerQuestion.Stop();

            
        }
    }
}
