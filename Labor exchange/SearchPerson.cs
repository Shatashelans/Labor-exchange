using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Labor_exchange
{
    public partial class SearchPerson : Form
    {
        Form1 form1;
        public SearchPerson(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Person> searchedPeople = Labor_exchange.Container.SearchForPeople(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text,
                textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text);
            form1.SearchPeople(searchedPeople);
            Close();
        }
    }
}
