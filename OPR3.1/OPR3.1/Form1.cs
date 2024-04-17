namespace OPR3._1
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
                double dot1x = Convert.ToDouble(d1x.Text);
                double dot1y = Convert.ToDouble(d1y.Text);

                double dot2x = Convert.ToDouble(d2x.Text);
                double dot2y = Convert.ToDouble(d2y.Text);

                double dot3x = Convert.ToDouble(d3x.Text);
                double dot3y = Convert.ToDouble(d3y.Text);


                double AB = Math.Sqrt((dot2x - dot1x) * (dot2x - dot1x)
                    + (dot2y - dot1y) * (dot2y - dot1y));
                double BC = Math.Sqrt((dot3x - dot2x) * (dot3x - dot2x)
                    + (dot3y - dot2y) * (dot3y - dot2y));
                double CA = Math.Sqrt((dot1x - dot3x) * (dot1x - dot3x)
                    + (dot1y - dot3y) * (dot1y - dot3y));

                double P = AB + BC + CA;
                double p = P / 2;
                double S = Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));

                MessageBox.Show($"Периметр: {P}\nПлощадь: {S}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
