using System;
using System.Windows.Forms;

namespace Labor_exchange
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || (textBox10.Text == "" && textBox11.Text == ""))
            {
                MessageBox.Show("You should fill at least name, surname, profession and one of the contacts for it!", "Add person attention", MessageBoxButtons.OK);
            }
            else
            {
                Labor_exchange.Container.AddPerson(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text,
                textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text);
                form1.RefreshPerson();
                Close();
            }
        }
    }
}
