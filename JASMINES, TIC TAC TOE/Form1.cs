using System.Media;
namespace JASMINES__TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        String Botvalue = "X";
        int counter = 0;
        SoundPlayer _soundPlayer = new SoundPlayer(soundLocation: @"E:\PROGRAMMING\JASMINES, TIC TAC TOE\JASMINES, TIC TAC TOE\bin\Debug\TICTACTOE.wav");
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Bot1_Click(object sender, EventArgs e)
        {
            if (Bot1.Text == "")
            {
                Bot1.Text = Botvalue;
                if (Botvalue == "X")
                {
                    Botvalue = "O";
                }
                else
                {
                    Botvalue = "X";
                }
                // V B1
                if (Bot1.Text == Bot2.Text)
                {
                    if (Bot2.Text == Bot3.Text)
                    {
                        MessageBox.Show("Winner " + Bot1.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                    // H B1 
                }
                else if (Bot1.Text == Bot4.Text)
                {
                    if (Bot4.Text == Bot7.Text)
                    {
                        MessageBox.Show("Winner " + Bot1.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                    // D B1
                }
                else if (Bot1.Text == Bot5.Text)
                {
                    if (Bot5.Text == Bot9.Text)
                    {
                        MessageBox.Show("Winner " + Bot1.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                }
            }
        }

        private void Bot2_Click(object sender, EventArgs e)
        {
            if (Bot2.Text == "")
            {
                Bot2.Text = Botvalue;
                if (Botvalue == "X")
                {
                    Botvalue = "O";
                }
                // V B2
                else
                {
                    Botvalue = "X";
                }
                if (Bot2.Text == Bot3.Text)
                {
                    if (Bot3.Text == Bot1.Text)
                    {
                        MessageBox.Show("Winner " + Bot2.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                    // H B2
                }
                else if (Bot2.Text == Bot5.Text)
                {
                    if (Bot5.Text == Bot8.Text)
                    {
                        MessageBox.Show("Winner " + Bot2.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                }

            }
        }

        private void Bot3_Click(object sender, EventArgs e)
        {
            if (Bot3.Text == "")
            {
                Bot3.Text = Botvalue;
                if (Botvalue == "X")
                {
                    Botvalue = "O";
                }
                // V B3
                else
                {
                    Botvalue = "X";
                }
                if (Bot3.Text == Bot2.Text)
                {
                    if (Bot2.Text == Bot1.Text)
                    {
                        MessageBox.Show("Winner " + Bot3.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                    // H B3
                }
                else if (Bot3.Text == Bot6.Text)
                {
                    if (Bot6.Text == Bot9.Text)
                    {
                        MessageBox.Show("Winner " + Bot3.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                    // D B3
                }
                else if (Bot3.Text == Bot5.Text)
                {
                    if (Bot5.Text == Bot7.Text)
                    {
                        MessageBox.Show("Winner " + Bot3.Text); Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                }
            }
        }

        private void Bot4_Click(object sender, EventArgs e)
        {
            if (Bot4.Text == "")
            {
                Bot4.Text = Botvalue;
                if (Botvalue == "X")
                {
                    Botvalue = "O";
                }
                // V B4
                else
                {
                    Botvalue = "X";
                }
                if (Bot4.Text == Bot5.Text)
                {
                    if (Bot5.Text == Bot6.Text)
                    {
                        MessageBox.Show("Winner " + Bot4.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                    // H B4
                }
                else if (Bot4.Text == Bot7.Text)
                {
                    if (Bot7.Text == Bot1.Text)
                    {
                        MessageBox.Show("Winner " + Bot4.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                }
            }
        }

        private void Bot5_Click(object sender, EventArgs e)
        {
            if (Bot5.Text == "")
            {
                Bot5.Text = Botvalue;
                if (Botvalue == "X")
                {
                    Botvalue = "O";
                }
                // V B5
                else
                {
                    Botvalue = "X";
                }
                if (Bot5.Text == Bot6.Text)
                {
                    if (Bot6.Text == Bot4.Text)
                    {
                        MessageBox.Show("Winner " + Bot5.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                    // H B5
                }
                else if (Bot5.Text == Bot8.Text)
                {
                    if (Bot8.Text == Bot2.Text)
                    {
                        MessageBox.Show("Winner " + Bot5.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                    // D B5
                }
                else if (Bot5.Text == Bot7.Text)
                {
                    if (Bot7.Text == Bot3.Text)
                    {
                        MessageBox.Show("Winner " + Bot5.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                }
            }
        }

        private void Bot6_Click(object sender, EventArgs e)
        {
            if (Bot6.Text == "")
            {
                Bot6.Text = Botvalue;
                if (Botvalue == "X")
                {
                    Botvalue = "O";
                }
                // V B6
                else
                {
                    Botvalue = "X";
                }
                if (Bot6.Text == Bot5.Text)
                {
                    if (Bot5.Text == Bot4.Text)
                    {
                        MessageBox.Show("Winner " + Bot6.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                    // H B6
                }
                else if (Bot6.Text == Bot9.Text)
                {
                     if (Bot9.Text == Bot3.Text)
                    {
                        MessageBox.Show("Winner " + Bot6.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                }
            }
        }

        private void Bot7_Click(object sender, EventArgs e)
        {
            if (Bot7.Text == "")
            {
                Bot7.Text = Botvalue;
                if (Botvalue == "X")
                {
                    Botvalue = "O";
                }
                else
                {
                    Botvalue = "X";
                }
                // V B7
                if (Bot7.Text == Bot8.Text)
                {
                    if (Bot8.Text == Bot9.Text)
                    {
                        MessageBox.Show("Winner " + Bot7.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                    // H B7
                }
                else if (Bot7.Text == Bot4.Text)
                {
                    if (Bot4.Text == Bot1.Text)
                    {
                        MessageBox.Show("Winner " + Bot7.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                    // D B7
                }
                else if (Bot7.Text == Bot5.Text)
                {
                    if (Bot5.Text == Bot3.Text)
                    {
                        MessageBox.Show("Winner " + Bot7.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                }
            }
        }

        private void Bot8_Click(object sender, EventArgs e)
        {
            if (Bot8.Text == "")
            {
                Bot8.Text = Botvalue;
                if (Botvalue == "X")
                {
                    Botvalue = "O";
                }
                else
                {
                    Botvalue = "X";
                }
                // V B8
                if (Bot8.Text == Bot9.Text)
                {
                    if (Bot9.Text == Bot7.Text)
                    {
                        MessageBox.Show("Winner " + Bot8.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                    // H B8
                }
                else if (Bot8.Text == Bot5.Text)
                {
                     if (Bot5.Text == Bot1.Text)
                     {
                        MessageBox.Show("Winner " + Bot8.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                }
            }
        }

        private void Bot9_Click(object sender, EventArgs e)
        {
            if (Bot9.Text == "")
            {
                Bot9.Text = Botvalue;
                if (Botvalue == "X")
                {
                    Botvalue = "O";
                }
                else
                {
                    Botvalue = "X";
                }
                // V B9
                if (Bot9.Text == Bot8.Text)
                {
                    if (Bot8.Text == Bot7.Text)
                    {
                        MessageBox.Show("Winner " + Bot9.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                    // H B9
                }
                else if (Bot9.Text == Bot6.Text)
                {
                     if (Bot6.Text == Bot3.Text)
                    {
                        MessageBox.Show("Winner " + Bot9.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                     // D B9
                }
                else if (Bot9.Text == Bot5.Text)
                {
                     if (Bot5.Text == Bot1.Text)
                    {
                        MessageBox.Show("Winner " + Bot9.Text);
                        Bot1.Text = "";
                        Bot2.Text = "";
                        Bot3.Text = "";
                        Bot4.Text = "";
                        Bot5.Text = "";
                        Bot6.Text = "";
                        Bot7.Text = "";
                        Bot8.Text = "";
                        Bot9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                }
            }
        }

        private void BOTabout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game was created by John Lloyd Jasmines :)", "About:");
        }

        private void BotReset_Click(object sender, EventArgs e) 
        {
            Bot1.Enabled = true;
            Bot2.Enabled = true;
            Bot3.Enabled = true;
            Bot4.Enabled = true;
            Bot5.Enabled = true;
            Bot6.Enabled = true;
            Bot7.Enabled = true;
            Bot8.Enabled = true;
            Bot9.Enabled = true;

            Bot1.Text = "";
            Bot2.Text = "";
            Bot3.Text = "";
            Bot4.Text = "";
            Bot5.Text = "";
            Bot6.Text = "";
            Bot7.Text = "";
            Bot8.Text = "";
            Bot9.Text = "";

            Bot1.BackColor = Color.White;
            Bot2.BackColor = Color.White;
            Bot3.BackColor = Color.White;
            Bot4.BackColor = Color.White;
            Bot5.BackColor = Color.White;
            Bot6.BackColor = Color.White;
            Bot7.BackColor = Color.White;
            Bot8.BackColor = Color.White;
            Bot9.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _soundPlayer.Stop();
        }
    }
}