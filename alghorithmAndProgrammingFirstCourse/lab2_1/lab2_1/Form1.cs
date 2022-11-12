namespace lab2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(xValueTextBox.Text);
            double y = double.Parse(yValueTextBox.Text);
            double z = double.Parse(zValueTextBox.Text);

            double b = (2 + Math.Cos(y - 2)) / (Math.Pow(x, 4) + Math.Pow(Math.Sin(z), 2));
            double a = (1 + x)*((x + y + 1) / (Math.Pow(b, -x) + x * Math.Pow(y, 2)));
            bool t = (a + 1) < (b + 1);

            resultTextBox.Text = "Лаб. раб. №1. Ст. гр. БОЗИоз22 Кучмина И.Н. формула 6" + Environment.NewLine +
            "X = " + x + Environment.NewLine +
            "Y = " + y + Environment.NewLine +
            "Z = " + z + Environment.NewLine +
            "a = " + a + Environment.NewLine +
            "b = " + b + Environment.NewLine +
            "t = " + t + Environment.NewLine;
        }
    }
}