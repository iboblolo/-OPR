namespace OPR3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);

                if (radioButton1.Checked)
                {
                    MessageBox.Show((n * (n + 1) * (2 * n + 1) * (3 * n * n + 3 * n - 1) / 30).ToString());
                }
                if (radioButton2.Checked)
                {
                    int s = 0;

                    for (int i = 1; i <= n; i++)
                    {
                        s += i * i * i * i;
                    }
                    MessageBox.Show(s.ToString());
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
