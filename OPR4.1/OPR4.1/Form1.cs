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
                label2.Text = (Math.Pow(-1, n) * 2 * (n + 1) * (n + 1) - (1 + Math.Pow(-1, n))/2).ToString();
            }
            if (radioButton2.Checked)
            {
                int s = 0;
                n += 1;
                for (int i = 0; i < n; i++)
                {
                    int d = (2 * i + 1) * (2 * i + 1);
                    if(i %  2 == 1)
                    {
                        d *= -1;
                    }
                    s += d;
                   
                }
                label2.Text = s.ToString();
            }
        }
    }
}
