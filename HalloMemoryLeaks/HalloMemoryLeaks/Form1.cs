using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloMemoryLeaks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            List<MeineKlasse> zeug = new List<MeineKlasse>();

            for (int i = 0; i < 5_000; i++)
            {
                var z = new MeineKlasse();
                this.ClientSizeChanged += (s, ee) => z.EineZahl += 1;
                zeug.Add(z);

                for (int saaaa = 0; saaaa < 10000; saaaa++)
                {
                    var lll = Math.Pow(324432, 234234);
                }

                if (zeug.Count % 100_000 == 0)
                    Thread.Sleep(1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var mk = new MeineKlasse())
            {

            }//mk.Dispose();


            try
            {
                using (var con2 = new SqlConnection(""))
                {
                    con2.Open();
                    //db arbeit

                } //con.Dispse() -> con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(":(");
            }


            SqlConnection con = null;
            try
            {
                con = new SqlConnection("");
                con.Open();
                //db arbeit XXXXXXXX
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(":-(");
            }
            finally
            {
                con?.Close();
            }

        }
    }

    public class MeineKlasse : IDisposable
    {
        public decimal EineZahl { get; set; } = 12;

        public SolidBrush MyProperty { get; set; }

        public void Dispose()
        {
            MyProperty.Dispose();
        }
    }
}
