using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Penebak_Lawan_Berikutnya_MCGOGO
{
    public partial class Homes : Form
    {
        string lawan1;
        string lawan2;
        string lawan3;
        string lawan4;
        string lawan5;
        string lawan6;
        string lawan7;
        string prediksi;

        public Homes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {

                this.Close();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {

                MessageBox.Show("Aksi dibatalkan.");
            }
        }

        private void Homes_Load(object sender, EventArgs e)
        {

            textBox1.Focus();

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                groupBox2.Visible = true;
                lawan1 = textBox1.Text;
                e.SuppressKeyPress = true;
                //  MessageBox.Show(lawan1);
                groupBox1.Visible = false;



            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                groupBox3.Visible = true;
                lawan2 = textBox2.Text;
                e.SuppressKeyPress = true;
                //  MessageBox.Show(lawan1);
                groupBox2.Visible = false;

                label3.Text = "siapakah lawan " + lawan1 + " ?";

            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                groupBox4.Visible = true;
                lawan3 = textBox3.Text;
                e.SuppressKeyPress = true;
                //  MessageBox.Show(lawan1);
                groupBox3.Visible = false;
                prediksi = textBox3.Text;
                MessageBox.Show( "Lawan selanjutnya : "+prediksi);
              //  Prediktion.Text = prediksi;

                label7.Text = "Lawan Ke 4";

            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                groupBox5.Visible = true;
                lawan4 = textBox4.Text;
                e.SuppressKeyPress = true;
                //  MessageBox.Show(lawan1);
                groupBox4.Visible = false;
                prediksi = "?";
                MessageBox.Show("Lawan selanjutnya : " + prediksi);
                // Prediktion.Text = "?";

                label10.Text = "siapakah lawan " + lawan1 + " ?";

            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.F1)
                {
                    groupBox6.Visible = true;
                    lawan5 = textBox5.Text;
                    e.SuppressKeyPress = true;
                    //  MessageBox.Show(lawan1);
                    groupBox5.Visible = false;
                    prediksi = textBox5.Text;
                    MessageBox.Show("Lawan selanjutnya : " + prediksi);
                    //    Prediktion.Text = prediksi;

                    label12.Text = "siapakah lawan " + lawan3 + " ?";

                }
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                groupBox7.Visible = true;
                lawan6 = textBox6.Text;
                e.SuppressKeyPress = true;
                //  MessageBox.Show(lawan1);
                groupBox6.Visible = false;
                prediksi = textBox6.Text;
                MessageBox.Show("Lawan selanjutnya : " + prediksi);
                /* Prediktion.Text = prediksi;*/

                label14.Text = "siapakah lawan yang belum dilawan?";

            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
               
                lawan7 = textBox7.Text;
                e.SuppressKeyPress = true;
                //  MessageBox.Show(lawan1);
                groupBox7.Visible = false;
                prediksi = "";
                /*   Prediktion.Text = prediksi;
                   Prediktion.Visible = false;
                   label8.Visible = false;*/
                pictureBox1.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;

                label16.Text = "1. " + lawan1;
                label17.Text = "2. " + lawan2;
                label18.Text = "3. " + lawan3;
                label19.Text = "4. " + lawan4;
                label20.Text = "5. " + lawan5;
                label21.Text = "6. " + lawan6;
                label22.Text = "7. " + lawan7;

              //  label14.Text = "siapakah lawan yang belum dilawan?";

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/@FulungGames"; // Ganti dengan link YouTube kamu
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}