using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Labor_exchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshPerson();
            RefreshCompany();
        }

        /// <summary>
        /// Refreshes the view of people that are not in the archive
        /// </summary>
        public void RefreshPerson()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Labor_exchange.Container.People.Count; i++)
            {
                if (Labor_exchange.Container.People[i].Archive == false)
                {
                    UpdatePerson(i);
                }
            }
        }

        /// <summary>
        /// Refreshes the view of companies that are not in the archive
        /// </summary>
        public void RefreshCompany()
        {
            dataGridView2.Rows.Clear();
            for (int i = 0; i < Labor_exchange.Container.Companies.Count; i++)
            {
                if (Labor_exchange.Container.Companies[i].Archive == false)
                {
                    UpdateCompany(i);
                }
            }
        }

        /// <summary>
        /// Outputs related to the searching parameters people
        /// </summary>
        /// <param name="searchedPeople">List of related objects of the class "People"</param>
        public void SearchPeople(List<Person> searchedPeople)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < searchedPeople.Count; i++)
            {
                dataGridView1.Rows.Add(searchedPeople[i].PId, searchedPeople[i].Name, searchedPeople[i].Surname,
                   searchedPeople[i].Profession, searchedPeople[i].Education,
                   searchedPeople[i].LastWorkPlace, searchedPeople[i].LastWorkPosition,
                   searchedPeople[i].ReasonOfFiring, searchedPeople[i].MaritalStatus,
                   searchedPeople[i].LivingConditions, searchedPeople[i].TelephoneNumber,
                   searchedPeople[i].Email, searchedPeople[i].Requirements, searchedPeople[i].Archive, "Delete", "Print");
            }
        }

        /// <summary>
        /// Outputs related to the searching parameters companies
        /// </summary>
        /// <param name="searchedCompanies">List of related objects of the class "Company"</param>
        public void SearchCompanies(List<Company> searchedCompanies)
        {
            dataGridView2.Rows.Clear();
            for(int i = 0; i < searchedCompanies.Count; i++)
            {
                dataGridView2.Rows.Add(searchedCompanies[i].CId, searchedCompanies[i].CompanyName,
                    searchedCompanies[i].Position, searchedCompanies[i].WorkingConditions,
                    searchedCompanies[i].PaymentConditions, searchedCompanies[i].LivingConditions,
                    searchedCompanies[i].CompanyRequirements, searchedCompanies[i].Archive, "Delete", "Print");
            }
        }

        /// <summary>
        /// Updates the view of people
        /// </summary>
        /// <param name="i">The key of object in the list</param>
        private void UpdatePerson(int i)
        {
            dataGridView1.Rows.Add(Labor_exchange.Container.People[i].PId, Labor_exchange.Container.People[i].Name, Labor_exchange.Container.People[i].Surname,
                   Labor_exchange.Container.People[i].Profession, Labor_exchange.Container.People[i].Education,
                   Labor_exchange.Container.People[i].LastWorkPlace, Labor_exchange.Container.People[i].LastWorkPosition,
                   Labor_exchange.Container.People[i].ReasonOfFiring, Labor_exchange.Container.People[i].MaritalStatus,
                   Labor_exchange.Container.People[i].LivingConditions, Labor_exchange.Container.People[i].TelephoneNumber,
                   Labor_exchange.Container.People[i].Email, Labor_exchange.Container.People[i].Requirements, Labor_exchange.Container.People[i].Archive, "Delete", "Print");
        }

        /// <summary>
        /// Updates the view of companies
        /// </summary>
        /// <param name="i">The key of object in the list</param>
        private void UpdateCompany(int i)
        {
            dataGridView2.Rows.Add(Labor_exchange.Container.Companies[i].CId, Labor_exchange.Container.Companies[i].CompanyName,
                    Labor_exchange.Container.Companies[i].Position, Labor_exchange.Container.Companies[i].WorkingConditions,
                    Labor_exchange.Container.Companies[i].PaymentConditions, Labor_exchange.Container.Companies[i].LivingConditions,
                    Labor_exchange.Container.Companies[i].CompanyRequirements, Labor_exchange.Container.Companies[i].Archive, "Delete", "Print");
        }

        /// <summary>
        /// Shows dialog to add the company advertisment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
        }

        /// <summary>
        /// Shows dialog to add the person advertisment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        /// <summary>
        /// Refreshes view of people advertisments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button7_Click(object sender, EventArgs e)
        {
            RefreshPerson();
        }

        /// <summary>
        /// Refreshes view of companies advertisments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button8_Click(object sender, EventArgs e)
        {
            RefreshCompany();
        }

        /// <summary>
        /// Updates values of the object after their changes in the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int recordId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Labor_exchange.Container.ChangePersonData(recordId, dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString(), Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[13].Value));
            }
        }

        /// <summary>
        /// Updates values of the object after their changes in the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                int recordId = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                Labor_exchange.Container.ChangeCompanyData(recordId, dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString(), dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString(), dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString(), Convert.ToBoolean(dataGridView2.Rows[e.RowIndex].Cells[7].Value));
            }
        }

        /// <summary>
        /// Outputs advertisments from the archive
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Labor_exchange.Container.People.Count; i++)
            {
                if (Labor_exchange.Container.People[i].Archive == true)
                {
                    UpdatePerson(i);
                }
            }
        }

        /// <summary>
        /// Outputs advertisments from the archive
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button6_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            for (int i = 0; i < Labor_exchange.Container.Companies.Count; i++)
            {
                if (Labor_exchange.Container.Companies[i].Archive == true)
                {
                    UpdateCompany(i);
                }
            }
        }

        /// <summary>
        /// Shows form to perform searching amoung people advertisments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button5_Click(object sender, EventArgs e)
        {
            SearchPerson searchPerson = new SearchPerson(this);
            searchPerson.ShowDialog();
        }

        /// <summary>
        /// Shows form to perform searching amoung companies advertisments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4_Click(object sender, EventArgs e)
        {
            SearchCompany searchCompanies = new SearchCompany(this);
            searchCompanies.ShowDialog();
        }

        /// <summary>
        /// Perform deleting and printing of the advertisment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 15)
            {
                Labor_exchange.Container.CreatePdfForPerson(int.Parse(dataGridView1.CurrentRow.Cells["p_id"].Value.ToString()));
            }
            if (e.ColumnIndex == 14)
            {
                Labor_exchange.Container.DeletePerson(int.Parse(dataGridView1.CurrentRow.Cells["p_id"].Value.ToString()));
                RefreshPerson();
                return;
            }
        }

        /// <summary>
        /// Perform deleting and printing of the advertisment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                Labor_exchange.Container.CreatePdfForCompany(int.Parse(dataGridView2.CurrentRow.Cells["c_id"].Value.ToString()));
            }
            if (e.ColumnIndex == 8)
            {
                Labor_exchange.Container.DeleteCompany(int.Parse(dataGridView2.CurrentRow.Cells["c_id"].Value.ToString()));
                RefreshCompany();
                return;
            }
        }
    }
}
