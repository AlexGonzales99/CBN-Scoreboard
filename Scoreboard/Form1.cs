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
            var pos = this.PointToScreen(awayTeamResult.Location);
            pos = image1.PointToClient(pos);
            awayTeamResult.Parent = image1;
            awayTeamResult.Location = pos;
            awayTeamResult.BackColor = Color.Transparent;
            var pos2 = this.PointToScreen(homeTeamResult.Location);
            pos2 = awayTeam.PointToClient(pos2);
            homeTeamResult.Parent = awayTeam;
            homeTeamResult.Location = pos2;
            homeTeamResult.BackColor = Color.Transparent;
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

        private void plus_one_away(object sender, EventArgs e)// + 1 Button
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
            homeTeamResult.Text = "0";

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
            InitializeComponent();
            var pos = this.PointToScreen(awayTeamResult.Location);
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
            label1.BackColor = System.Drawing.Color.Transparent; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int plusOne = Convert.ToInt32(button.Text);
            int textboxScore = Convert.ToInt32(homeTeamResult.Text);
            int totalScore = plusOne + textboxScore;


            homeTeamResult.Text = totalScore.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int plusOne = Convert.ToInt32(button.Text);
            int textboxScore = Convert.ToInt32(Inning.Text);
            int totalScore = plusOne + textboxScore;


            Inning.Text = totalScore.ToString();
        }

        private void Inning_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(50, 50, 150, 150);
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
                String imageLocation2 = "";
                try
                {

                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "PNG files(*.png)|*.png| jpg files(*.jpg)|*.jpg|  All Files('.')|'.'";

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation2 = dialog.FileName;

                        pictureBox2.ImageLocation = imageLocation2;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //  pictureBox3_Click.appear.false;
          
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Button alex = (Button)sender;
            empty.Visible = true;

            onebase.Visible = false;
            onetwobase.Visible = false;
            onethreebase.Visible = false;


            twoBase.Visible = false;
            twothreebase.Visible = false;

            threebase.Visible = false;
            basesloaded.Visible = false;


        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button alex = (Button)sender;
            onebase.Visible = true;

            onetwobase.Visible = false;
            onethreebase.Visible = false;


            twoBase.Visible = false;
            twothreebase.Visible = false;

            threebase.Visible = false;
            basesloaded.Visible = false;

            empty.Visible = false;

        }

        private void button19_Click(object sender, EventArgs e)
        {

            
            onebase.Visible = false;
            onetwobase.Visible = false;
            onethreebase.Visible = false;


            twoBase.Visible = false;
            twothreebase.Visible = false;

            threebase.Visible = false;
            basesloaded.Visible = false;

            empty.Visible = false;
            
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
           

        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            onetwobase.Visible = true;


            onebase.Visible = false;
            onethreebase.Visible = false;


            twoBase.Visible = false;
            twothreebase.Visible = false;

            threebase.Visible = false;
            basesloaded.Visible = false;

            empty.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button Alex = (Button)sender;

            onethreebase.Visible = true;

            onebase.Visible = false;
            onetwobase.Visible = false;


            twoBase.Visible = false;
            twothreebase.Visible = false;

            threebase.Visible = false;
            basesloaded.Visible = false;

            empty.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            twoBase.Visible = true;
            onebase.Visible = false;
            onetwobase.Visible = false;
            onethreebase.Visible = false;


            twothreebase.Visible = false;

            threebase.Visible = false;
            basesloaded.Visible = false;

            empty.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            twothreebase.Visible = true;

            onebase.Visible = false;
            onetwobase.Visible = false;
            onethreebase.Visible = false;


            twoBase.Visible = false;

            threebase.Visible = false;
            basesloaded.Visible = false;

            empty.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            threebase.Visible = true;

            onebase.Visible = false;
            onetwobase.Visible = false;
            onethreebase.Visible = false;


            twoBase.Visible = false;
            twothreebase.Visible = false;

            basesloaded.Visible = false;

            empty.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            basesloaded.Visible = true;

            onebase.Visible = false;
            onetwobase.Visible = false;
            onethreebase.Visible = false;


            twoBase.Visible = false;
            twothreebase.Visible = false;

            threebase.Visible = false;

            empty.Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            up.Visible = true;
            down.Visible = false;
        }

        private void down_Click(object sender, EventArgs e)
        {
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            up.Visible = false;
            down.Visible = true;

        }

        private void up_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int textboxScore = Convert.ToInt32(Inning.Text);
            int totalScore = textboxScore - 1; // fix this line make sure variable

            if (Inning.Text == "1")
            {
                Inning.Text = "1";
            }
            else
                Inning.Text = totalScore.ToString();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

          

            int plusOne = Convert.ToInt32(button.Text);
            int textboxScore = Convert.ToInt32(label11.Text);
            int totalScore = plusOne + textboxScore;

             


            label11.Text = totalScore.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int textboxScore = Convert.ToInt32(label11.Text);
            int totalScore = textboxScore - 1; // fix this line make sure variable

            if (label11.Text == "0")
            {
                label11.Text = "0";
            }
            else
                label11.Text = totalScore.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int plusOne = Convert.ToInt32(button.Text);
            int textboxScore = Convert.ToInt32(label10.Text);
            int totalScore = plusOne + textboxScore;


            label10.Text = totalScore.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int plusOne = Convert.ToInt32(button.Text);
            int textboxScore = Convert.ToInt32(label12.Text);
            int totalScore = plusOne + textboxScore;


            label12.Text = totalScore.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int textboxScore = Convert.ToInt32(label10.Text);
            int totalScore = textboxScore - 1; // fix this line make sure variable


            if (label10.Text == "0")
            {
                label10.Text = "0";
            }
        
            else
                label10.Text = totalScore.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int textboxScore = Convert.ToInt32(label12.Text);
            int totalScore = textboxScore - 1; // fix this line make sure variable

            if (label12.Text == "0")
            {
                label12.Text = "0";
            }
            else
                label12.Text = totalScore.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            label11.Text = "0";
            label10.Text = "0";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            String imageLocation2 = "";
            try
            {

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "PNG files(*.png)|*.png| jpg files(*.jpg)|*.jpg|  All Files('.')|'.'";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation2 = dialog.FileName;

                    pictureBox5.ImageLocation = imageLocation2;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
