using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            int age = DateTime.Now.Year - selectedDate.Year;
            if (DateTime.Now.DayOfYear < selectedDate.DayOfYear)
            {
                age--;
            }
            if (age < 12)
            {

                MessageBox.Show("Вам повинно бути не менше 12 років", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

               
                dateTimePicker1.Value = DateTime.Now.AddYears(-12);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Ви зареїструвалися на сайт namaxalowo.com", "Дякую", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            checkBox2.Checked = false;


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 13)
            {

                MessageBox.Show("Імя завелике, введіть не більше 13 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = textBox1.Text.Substring(0, 13);


                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox4.PasswordChar == '•')
            {
                textBox4.PasswordChar = '\0'; 
                checkBox2.Text = "Приховати пароль";
            }
            else
            {
                textBox4.PasswordChar = '•'; 
                checkBox2.Text = "Показати пароль";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (!textBox3.Text.EndsWith("@gmail.com"))
            {
                
                textBox3.ForeColor = System.Drawing.Color.Red; 
            }
            else
            {
                
                textBox3.ForeColor = System.Drawing.Color.Black; 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 13)
            {

                MessageBox.Show("Імя завелике, введіть не більше 13 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = textBox1.Text.Substring(0, 13);


                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }
    }
}
    
