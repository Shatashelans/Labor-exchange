using System;
using System.Windows.Forms;

namespace Labor_exchange
{
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("You should fill at least company name and position for it!", "Add job attention", MessageBoxButtons.OK);
            }
            else
            {
                Labor_exchange.Container.AddCompany(textBox1.Text, textBox2.Text, textBox3.Text,
                textBox4.Text, textBox5.Text, textBox6.Text);
                form1.RefreshCompany();
                Close();
            }
        }
    }
}
