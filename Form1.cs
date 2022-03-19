using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace autoLectureLogin
{

    public partial class Form1 : Form
    {
        DateTime todayDate;

        string timeNowHM;
        string ampm;
        string nowDate;
        string timeMilSec;
        int timeMinInt;

        public Form1()
        {
            InitializeComponent();
            milSecText.Hide();
            this.BackColor = Color.FromArgb(57, 62, 70);
            panel1.BackColor = Color.FromArgb(78, 204, 163);
            labelTodayDate.ForeColor = Color.FromArgb(57, 62, 70);
        }

        private void openLecture(TextBox lectureXID, TextBox lectureTimeHoursX, DateTimePicker datePickedX, ComboBox ampmX)
        {

            //numericUpDown.ReadOnly = true; //only buttons
            string url = "https://zoom.us/j/" + lectureXID.Text.Trim();

            
                if (nowDate == datePickedX.Text && timeNowHM == lectureTimeHoursX.Text
                && ampm == ampmX.Text && timeMilSec == milSecText.Text) 
                {
                    try //Open Website
                    {
                       
                        System.Diagnostics.Process.Start(url.Trim()); //Open link

                    }
                    catch (Exception e)
                    {
                        System.Windows.Forms.MessageBox.Show("Please check the meeting ID");
                    }
                }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelTodayDate.Text = DateTime.Now.ToString();
            nowDate = DateTime.Now.ToString("dddd, MMMM d, yyyy");
            timeNowHM = DateTime.Now.ToString("h:mm");
            timeMilSec = DateTime.Now.ToString("ss");
            ampm = DateTime.Now.ToString("tt");
            

            textBox1_TextChanged(sender, e);

            lectureOneID_TextChanged(sender, e);
            lectureTwoID_TextChanged(sender, e);
            lectureThreeID_TextChanged(sender, e);
            lectureFourID_TextChanged(sender, e);
            lectureFiveID_TextChanged(sender, e);
            lectureSixID_TextChanged(sender, e);
            lectureSevenID_TextChanged(sender, e);
            lectureEighitID_TextChanged(sender, e);

        }

        

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lectureTimeOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void lectureOneID_TextChanged(object sender, EventArgs e)
        {
            openLecture(lectureOneID, lectureTimeOne, dateTimePicker1, ampmOne);
        }

        private void lectureTwoID_TextChanged(object sender, EventArgs e)
        {
            openLecture(lectureTwoID, lectureTimeTwo, dateTimePicker2, ampmTwo);
        }

        private void lectureThreeID_TextChanged(object sender, EventArgs e)
        {
            openLecture(lectureThreeID, lectureTimeThree, dateTimePicker3, ampmThree);
        }


        private void lectureFourID_TextChanged(object sender, EventArgs e)
        {
            openLecture(lectureFourID, lectureTimeFour, dateTimePicker4, ampmFour);
        }

        private void lectureFiveID_TextChanged(object sender, EventArgs e)
        {
            openLecture(lectureFiveID, textBox1, dateTimePicker5, comboBox1);
        }

        private void lectureSixID_TextChanged(object sender, EventArgs e)
        {
            openLecture(lectureFiveID, textBox3, dateTimePicker6, comboBox2);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lectureSevenID_TextChanged(object sender, EventArgs e)
        {
            openLecture(lectureSevenID, textBox5, dateTimePicker7, comboBox2);
        }

        private void lectureEighitID_TextChanged(object sender, EventArgs e)
        {
            openLecture(lectureEighitID, textBox7, dateTimePicker8, comboBox3);
        }

        private void labelPickedTime_Click(object sender, EventArgs e)
        {

        }
    }
}
