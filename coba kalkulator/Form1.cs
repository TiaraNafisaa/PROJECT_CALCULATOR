using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace coba_kalkulator
{

    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            opr = 1; // Operator penambahan
            textBox1.Text = "+";
            textBox1.Text = "";
            opr_selesai = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (opr_selesai) // Pastikan opr_selesai adalah true sebelum melanjutkan
            {
                bil2 = Convert.ToDecimal(textBox1.Text); // Inisialisasi bil2 dengan nilai di textBox1
                switch (opr)
                {
                    case 1:
                        textBox1.Text = Convert.ToString(bil1 + bil2);
                        break;
                    case 2:
                        textBox1.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 3:
                        textBox1.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 4:
                        textBox1.Text = Convert.ToString(bil1 / bil2);
                        break;
                    case 5:
                        decimal result = 1; // Inisialisasi hasil pangkat
                        for (int i = 0; i < bil2; i++)
                        {
                            result *= bil1; // Mengalikan bil1 sebanyak bil2 kali
                        }
                        textBox1.Text = result.ToString(); // Menampilkan hasil pangkat di dalam textBox1
                        break;
                }
                opr_selesai = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            opr = 5; // Operator pangkat
            textBox1.Clear(); // Menghapus teks untuk menerima bilangan pangkat
            opr_selesai = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            bil1 = 0;
            bil2 = 0;
            textBox1.Text = " ";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            double result = Math.Sqrt(Convert.ToDouble(bil1)); // Menghitung akar kuadrat dari bil1
            textBox1.Text = result.ToString(); // Menampilkan hasil akar kuadrat di dalam textBox1
            opr = 0; // Mengatur operator menjadi 0 karena tidak diperlukan dalam kasus akar kuadrat
            opr_selesai = true; // Menandakan bahwa operasi sudah selesai
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text += "+"; // Menambahkan "+" ke teks yang sudah ada         
            opr = 1; // Operator penambahan
            textBox1.Text = "";
            opr_selesai = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text += "-"; // Menambahkan tanda pengurangan ke teks yang sudah ada
            opr = 2; // Mengatur operator menjadi 2 untuk pengurangan
            opr_selesai = true; // Menandakan bahwa operasi sudah selesai
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text += "x"; // Menambahkan "x" ke teks yang sudah ada         
            opr = 3; // Operator penambahan
            textBox1.Text = "";
            opr_selesai = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text += ":"; // Menambahkan "+" ke teks yang sudah ada         
            opr = 4; // Operator penambahan
            textBox1.Text = "";
            opr_selesai = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text += "-"; // Menambahkan "-" ke teks yang sudah ada         
            opr = 2; // Operator penambahan
            textBox1.Text = "";
            opr_selesai = true;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Membaca nilai dari textBox
                decimal input = Convert.ToDecimal(textBox1.Text);

                // Mengkonversi input dari derajat ke radian
                double radians = (double)input * Math.PI / 180;

                // Menghitung sinus dari input
                double result = Math.Sin(radians);

                // Menampilkan hasil di textBox
                textBox1.Text = result.ToString();
            }
            catch (FormatException)
            {
                // Menangani kasus di mana input bukan angka desimal yang valid
                MessageBox.Show("Harap masukkan angka yang valid.");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            double result = Math.Cos(Convert.ToDouble(bil1)); // Menghitung kosinus dari bil1
            textBox1.Text = result.ToString(); // Menampilkan hasil kosinus di dalam textBox1
            opr = 0; // Mengatur operator menjadi 0 karena tidak diperlukan dalam kasus kosinus
            opr_selesai = true; // Menandakan bahwa operasi sudah selesai
        }

        private void button22_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            double result = Math.Tan(Convert.ToDouble(bil1)); // Menghitung tangen dari bil1
            textBox1.Text = result.ToString(); // Menampilkan hasil tangen di dalam textBox1
            opr = 0; // Mengatur operator menjadi 0 karena tidak diperlukan dalam kasus tangen
            opr_selesai = true; // Menandakan bahwa operasi sudah selesai
        }
    }
} 




















