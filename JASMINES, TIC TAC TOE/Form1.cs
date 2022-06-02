namespace JASMINES__TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        String Botvalue = "X";
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
                    }
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
                    }
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
                    }
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
                    }
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
                    }
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
                    }
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
                    }
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
                    }
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
                    }
                }
            }
        }
    }
}