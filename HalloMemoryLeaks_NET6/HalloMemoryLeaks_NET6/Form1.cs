using System.Data.SqlClient;

namespace HalloMemoryLeaks_NET6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<decimal> zeug = new List<decimal>();
           //for (int i = 0; i < 50_000_000; i++)
            for (; ; )
            {
                zeug.Add(5);

                //if (zeug.Count % 100_000 == 0)
                //    Thread.Sleep(1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var con2 = new SqlConnection("");

        }
    }
}