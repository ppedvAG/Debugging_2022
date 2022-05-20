namespace AppForLogging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Program.Logger.Information("Info: {Text}", textBox1.Text);
            //Program.Logger.Warning("Warn: {Text}", textBox1.Text);
            //Program.Logger.Error("Error: {Text}", textBox1.Text);

            Program.Logger.Information("Info: {Text} {Cool}", textBox1, checkBox1);
        }
    }
}