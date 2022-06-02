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
            }
        }
    }
}