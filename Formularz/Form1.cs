namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            checkBox1.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            label4.Text = string.Empty;
            checkBox1.Enabled = true;
            label9.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string haslo = textBox2.Text;
            string phaslo = textBox3.Text;
            string email = textBox1.Text;
            int ok = 0;
            string wybor = "";
            if (email == string.Empty)
            {
                label7.ForeColor = Color.Red;
                label7.Text = "Wype³nij pole email";
                ok += 1;
            }
            else
            {
                label7.Text = string.Empty;
            }
            if (haslo == "")
            {
                label6.ForeColor = Color.Red;
                label6.Text = "Wype³nij pole has³o";
                ok += 1;
            }
            else
            {
                label6.Text = string.Empty;
            }
            if (haslo != phaslo)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Has³a nie s¹ identyczne";
                ok += 1;
            }
            else
            {
                label4.Text = string.Empty;
            }
            if (!checkBox1.Checked)
            {
                label8.ForeColor = Color.Red;
                label8.Text = "Zaznacz zgodê";
                ok += 1;
            }
            else
            {
                label8.Text = string.Empty;
            }
            if (haslo.Length < 8)
            {
                label6.ForeColor = Color.Red;
                label6.Text = "Has³o musi mieæ \nminimum 8 znaków";
                ok += 1;
            }
            else
            {
                label6.Text = string.Empty;
            }
            if (radioButton1.Checked)
            {
                wybor = "ma³a";
            }
            else if (radioButton2.Checked)
            {
                wybor = "du¿a";
            }
            else if (radioButton3.Checked)
            {
                wybor = "œrednia";
            }
            if (ok == 0)
            {
                label9.ForeColor = Color.Green;
                label9.Text = "Login: " + email + "\nZnajomoœæ C#: " + wybor;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            label8.Text = string.Empty;
        }
    }
}