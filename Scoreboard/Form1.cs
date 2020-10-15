using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoreboard
{
    public partial class form1 : Form
    {
       

        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
               
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "PNG files(*.png)|*.png| jpg files(*.jpg)|*.jpg|  All Files('.')|'.'";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    awayTeam.ImageLocation = imageLocation;
                }
            
            }
            catch(Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            String imageLocation2 = "";
            try
            {

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "PNG files(*.png)|*.png| jpg files(*.jpg)|*.jpg|  All Files('.')|'.'";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation2 = dialog.FileName;

                    image1.ImageLocation = imageLocation2;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void image1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1; // 1 second interval

        }

        private void awayTeamResult_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)// + 1 Button
        {

            Button button = (Button)sender;

            int plusOne = Convert.ToInt32(button.Text);
            int textboxScore = Convert.ToInt32(awayTeamResult.Text);
            int totalScore = plusOne + textboxScore;


            awayTeamResult.Text = totalScore.ToString();
           
        }

        private void button5_Click(object sender, EventArgs e) 
        {
            Button button = (Button)sender;

            awayTeamResult.Text = "0";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int plusOne = Convert.ToInt32(button.Text);
            int textboxScore = Convert.ToInt32(awayTeamResult.Text);
            int totalScore = plusOne + textboxScore;


            awayTeamResult.Text = totalScore.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int plusOne = Convert.ToInt32(button.Text);
            int textboxScore = Convert.ToInt32(awayTeamResult.Text);
            int totalScore = plusOne + textboxScore;


            awayTeamResult.Text = totalScore.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int textboxScore = Convert.ToInt32(awayTeamResult.Text);
            int totalScore = textboxScore - 2;

            if (awayTeamResult.Text == "0")
                awayTeamResult.Text = "0";
            else
                awayTeamResult.Text = totalScore.ToString();

        }

        private void minusOne_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int textboxScore = Convert.ToInt32(awayTeamResult.Text);
            int totalScore =  textboxScore - 1 ; // fix this line make sure variable

            if (awayTeamResult.Text == "0")
            {
                awayTeamResult.Text = "0";
            }
            else
                awayTeamResult.Text = totalScore.ToString();

        }

        private void awayTeamResult_Click_1(object sender, EventArgs e)
        {
           // awayTeamResult.BackColor = Color.Transparent;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int textboxScore = Convert.ToInt32(awayTeamResult.Text);
            int totalScore = textboxScore - 3;

            if (awayTeamResult.Text == "0")
                awayTeamResult.Text = "0";
            else
                awayTeamResult.Text = totalScore.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int textboxScore = Convert.ToInt32(homeTeamResult.Text);
            int totalScore = textboxScore - 1; // fix this line make sure variable

            if (homeTeamResult.Text == "0")
            {
                homeTeamResult.Text = "0";
            }
            else
                homeTeamResult.Text = totalScore.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int plusOne = Convert.ToInt32(button.Text);
            int textboxScore = Convert.ToInt32(homeTeamResult.Text);
            int totalScore = plusOne + textboxScore;


            homeTeamResult.Text = totalScore.ToString();
        }
    }
}
