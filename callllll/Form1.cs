namespace calculatrise
{
    public partial class CALCOLATER : Form
    {
        double value;
        string soperator;
        bool check;
        public CALCOLATER()
        {
            InitializeComponent();
        }

        private void Pnumber(object sender, EventArgs e)
        {
            if ( (soperator == "+") || (soperator == "-") || (soperator == "*") || (soperator == "/"))
            {
                if (check)
                {
                    check = false;
                    txtbox.Text = "0";
                }
            }
            Button b = sender as Button;
            if (txtbox.Text == "0")
                txtbox.Text = b.Text;
            else
                txtbox.Text += b.Text;
        }

       private void POperator(object sender , EventArgs e)
        {
            Button b = sender as Button;
            value = double.Parse(txtbox.Text);
            soperator = b.Text;
            txtbox.Text += b.Text;
            check = true;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            txtbox.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbox.Text = "0";
            value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                switch (soperator)
                {
                    case "+":
                        txtbox.Text = (value + double.Parse(txtbox.Text)).ToString();
                        break;
                    case "-":
                        txtbox.Text = (value - double.Parse(txtbox.Text)).ToString();
                        break;
                    case "*":
                        txtbox.Text = (value * double.Parse(txtbox.Text)).ToString();
                        break;
                    case "/":
                        txtbox.Text = (value / double.Parse(txtbox.Text)).ToString();
                        break;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}