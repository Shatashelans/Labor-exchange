using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Labor_exchange
{
    public partial class SearchCompany : Form
    {
        Form1 form1;
        public SearchCompany(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Company> searchedCompanies = Labor_exchange.Container.SearchForCompanies(textBox1.Text, textBox2.Text, textBox3.Text,
                textBox4.Text, textBox5.Text, textBox6.Text);
            form1.SearchCompanies(searchedCompanies);
            Close();
        }
    }
}
