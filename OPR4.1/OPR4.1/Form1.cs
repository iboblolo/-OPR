namespace OPR4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(trackBar1.Value);

            if (radioButton1.Checked)
            {
                label2.Text = (n * (n + 1) * (2 * n + 1) * (3 * n * n + 3 * n - 1) / 30).ToString();
            }
            if (radioButton2.Checked)
            {
                int s = 0;

                for (int i = 1; i <= n; i++)
                {
                    s += i * i * i * i;
                }
                label2.Text = s.ToString();
            }
        }
    }
}
