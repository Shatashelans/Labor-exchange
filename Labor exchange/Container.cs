using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Drawing;
using System.Diagnostics;

namespace Labor_exchange
{
    static class Container
    {
        private static List<Person> people = new List<Person>();
        private static List<Company> companies = new List<Company>();

        /// <summary>
        /// Gets or sets People's items properties
        /// </summary>
        public static List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        /// <summary>
        /// Gets or sets Company's items properties
        /// </summary>
        public static List<Company> Companies
        {
            get { return companies;  }
            set { companies = value; }
        }

        /// <summary>
        /// Adds object of the class "Person" to the list of people
        /// </summary>
        /// <param name="pName">Person's name</param>
        /// <param name="pSurname">Person's surname</param>
        /// <param name="pProfession">Person's profession</param>
        /// <param name="pEducation">Person's education</param>
        /// <param name="pLastWorkPlace">Person's last work place</param>
        /// <param name="pLastWorkPosition">Person's last work position</param>
        /// <param name="pReasonOfFiring">Person's reason of firing</param>
        /// <param name="pMaterialStatus">Person's marital status</param>
        /// <param name="pLivingConditions">Person's living conditions</param>
        /// <param name="pTelephoneNumber">Person's telephone number</param>
        /// <param name="pEmail">Person's email</param>
        /// <param name="pRequirements">Person's requirements</param>
        public static void AddPerson(string pName, string pSurname, string pProfession, string pEducation, string pLastWorkPlace, string pLastWorkPosition,
            string pReasonOfFiring, string pMaterialStatus, string pLivingConditions, string pTelephoneNumber, string pEmail, string pRequirements)
        {
            Person person = new Person(pName, pSurname, pProfession, pEducation, pLastWorkPlace, pLastWorkPosition,     // Calls the constructor for new Person object
            pReasonOfFiring, pMaterialStatus, pLivingConditions, pTelephoneNumber, pEmail, pRequirements);

            people.Add(person);                                                                                         // Adds the current object to the list
        }

        /// <summary>
        /// Adds object of the class "Company" to the list of companies
        /// </summary>
        /// <param name="cCompany">Company name</param>
        /// <param name="cPosition">Company position</param>
        /// <param name="cWorkingConditions">Company working conditions</param>
        /// <param name="cPaymentConditions">Company payment conditions</param>
        /// <param name="cLivingConditions">Company living conditions</param>
        /// <param name="cCompanyRequirements">Company requirements</param>
        public static void AddCompany(string cCompany, string cPosition, string cWorkingConditions,
            string cPaymentConditions, string cLivingConditions, string cCompanyRequirements)
        {
            Company company = new Company(cCompany, cPosition, cWorkingConditions,                                  // Calls the constructor for new Company object
            cPaymentConditions, cLivingConditions, cCompanyRequirements);

            companies.Add(company);                                                                                 // Adds the current object to the list
        }

        /// <summary>
        /// Searches for the person with parameters like ones that were in inputted (if they are empty, then parameters will be ignored)
        /// </summary>
        /// <param name="pName">Person's name</param>
        /// <param name="pSurname">Person's surname</param>
        /// <param name="pProfession">Person's profession</param>
        /// <param name="pEducation">Person's education</param>
        /// <param name="pLastWorkPlace">Person's last work place</param>
        /// <param name="pLastWorkPosition">Person's last work position</param>
        /// <param name="pReasonOfFiring">Person's reason of firing</param>
        /// <param name="pMaterialStatus">Person's marital status</param>
        /// <param name="pLivingConditions">Person's living conditions</param>
        /// <param name="pTelephoneNumber">Person's telephone number</param>
        /// <param name="pEmail">Person's email</param>
        /// <param name="pRequirements">Person's requirements</param>
        /// <returns>The list of objects of the class "Person" that are fit the inputted parameters</returns>
        public static List<Person> SearchForPeople(string pName, string pSurname, string pProfession, string pEducation, string pLastWorkPlace, string pLastWorkPosition,
            string pReasonOfFiring, string pMaterialStatus, string pLivingConditions, string pTelephoneNumber, string pEmail, string pRequirements)
        {
            List<Person> searchedPeople = new List<Person>();   // The list for the related people
            for (int i = 0; i < people.Count; i++)
            {
                if ((People[i].Name == pName || pName == "") && (People[i].Surname == pSurname || pSurname == "") && (People[i].Profession == pProfession || pProfession == "") && (People[i].Education == pEducation || pEducation == "") &&               // If the properties are equal
                    (People[i].LastWorkPlace == pLastWorkPlace || pLastWorkPlace == "") && (People[i].LastWorkPosition == pLastWorkPosition || pLastWorkPosition == "") && (People[i].ReasonOfFiring == pReasonOfFiring || pReasonOfFiring == "") &&        // or the field for searching was empty
                    (People[i].MaritalStatus == pMaterialStatus || pMaterialStatus == "") && (People[i].LivingConditions == pLivingConditions || pLivingConditions == "") && (People[i].TelephoneNumber == pTelephoneNumber || pTelephoneNumber == "") && 
                    (People[i].Email == pEmail || pEmail == "") && (People[i].Requirements == pRequirements || pRequirements == "") && People[i].Archive == false)
                {
                    searchedPeople.Add(People[i]);                                                                                                                                                                                                          // adds it to the list of related people
                }
            }
            return searchedPeople;
        }

        /// <summary>
        /// Searches for the company with parameters like ones that were in inputted (if they are empty, then parameters will be ignored)
        /// </summary>
        /// <param name="cCompany">Company name</param>
        /// <param name="cPosition">Company position</param>
        /// <param name="cWorkingConditions">Company working conditions</param>
        /// <param name="cPaymentConditions">Company payment conditions</param>
        /// <param name="cLivingConditions">Company living conditions</param>
        /// <param name="cCompanyRequirements">Company requirements</param>
        /// <returns>The list of objects of the class "Company" that are fit the inputted parameters</returns>
        public static List<Company> SearchForCompanies(string cCompany, string cPosition, string cWorkingConditions,
            string cPaymentConditions, string cLivingConditions, string cCompanyRequirements)
        {
            List<Company> searchedCompanies = new List<Company>();  // The list for the related people
            for (int i = 0; i < companies.Count; i++)
            {
                if ((Companies[i].CompanyName == cCompany || cCompany == "") &&
                    (Companies[i].Position == cPosition || cPosition == "") && (Companies[i].WorkingConditions == cWorkingConditions || cWorkingConditions == "") &&                            // If the properties are equal
                    (Companies[i].PaymentConditions == cPaymentConditions || cPaymentConditions == "") && (Companies[i].LivingConditions == cLivingConditions || cLivingConditions == "") &&    // or the field for searching was empty
                    (Companies[i].CompanyRequirements == cCompanyRequirements || cCompanyRequirements == "") && Companies[i].Archive == false)
                {
                    searchedCompanies.Add(Companies[i]);                                                                                                                                        // adds it to the list of related people
                }
            }
            return searchedCompanies;
        }

        /// <summary>
        /// Changes data of the person according to the inputted data and id
        /// </summary>
        /// <param name="personId">Id of the person</param>
        /// <param name="pName">Person's name</param>
        /// <param name="pSurname">Person's surname</param>
        /// <param name="pProfession">Person's profession</param>
        /// <param name="pEducation">Person's education</param>
        /// <param name="pLastWorkPlace">Person's last work place</param>
        /// <param name="pLastWorkPosition">Person's last work position</param>
        /// <param name="pReasonOfFiring">Person's reason of firing</param>
        /// <param name="pMaterialStatus">Person's marital status</param>
        /// <param name="pLivingConditions">Person's living conditions</param>
        /// <param name="pTelephoneNumber">Person's telephone number</param>
        /// <param name="pEmail">Person's email</param>
        /// <param name="pRequirements">Person's requirements</param>
        /// <param name="pArchive">Is this advertisment in the archive</param>
        public static void ChangePersonData(int personId, string pName, string pSurname, string pProfession, string pEducation, string pLastWorkPlace, string pLastWorkPosition,
            string pReasonOfFiring, string pMaterialStatus, string pLivingConditions, string pTelephoneNumber, string pEmail, string pRequirements, bool pArchive)
        {
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].PId == personId)                          // If the inputted id and id of object are equal
                {
                    People[i].Name = pName;                             // changes the properties of the current
                    People[i].Surname = pSurname;                       // object accordind to the inputted data
                    People[i].Profession = pProfession;
                    People[i].Education = pEducation;
                    People[i].LastWorkPlace = pLastWorkPlace;
                    People[i].LastWorkPosition = pLastWorkPosition;
                    People[i].ReasonOfFiring = pReasonOfFiring;
                    People[i].MaritalStatus = pMaterialStatus;
                    People[i].LivingConditions = pLivingConditions;
                    People[i].TelephoneNumber = pTelephoneNumber;
                    People[i].Email = pEmail;
                    People[i].Requirements = pRequirements;
                    People[i].Archive = pArchive;
                    break;
                }
            }
        }

        /// <summary>
        /// Changes data of the company according to the inputted data and id
        /// </summary>
        /// <param name="companyId">Id of the company</param>
        /// <param name="cCompany">Company name</param>
        /// <param name="cPosition">Company position</param>
        /// <param name="cWorkingConditions">Company working conditions</param>
        /// <param name="cPaymentConditions">Company payment conditions</param>
        /// <param name="cLivingConditions">Company living conditions</param>
        /// <param name="cCompanyRequirements">Company requirements</param>
        /// <param name="cArchive">Is this advertisment in the archive</param>
        public static void ChangeCompanyData(int companyId, string cCompany, string cPosition, string cWorkingConditions,
            string cPaymentConditions, string cLivingConditions, string cCompanyRequirements, bool cArchive)
        {
            for (int i = 0; i < Companies.Count; i++)
            {
                if (Companies[i].CId == companyId)                              // If the inputted id and id of object are equal
                {
                    Companies[i].CompanyName = cCompany;                        // changes the properties of the current
                    Companies[i].Position = cPosition;                          // object accordind to the inputted data
                    Companies[i].WorkingConditions = cWorkingConditions;        
                    Companies[i].PaymentConditions = cPaymentConditions;
                    Companies[i].LivingConditions = cLivingConditions;
                    Companies[i].CompanyRequirements = cCompanyRequirements;
                    Companies[i].Archive = cArchive;
                    break;
                }
            }
        }

        /// <summary>
        /// Performs deleting of the object from the list of people
        /// </summary>
        /// <param name="personId">Id of the person to delete</param>
        public static void DeletePerson(int personId)
        {
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].PId == personId)      // If the inputted id and id of object are equal
                {
                    if (MessageBox.Show("Are you sure you want to delete this person?", "Delete person", MessageBoxButtons.YesNo) == DialogResult.Yes) // and deleting was confirmed
                    {
                        People.Remove(People[i]);   // deletes the current object
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Performs deleting of the object from the list of companies
        /// </summary>
        /// <param name="companyId">Id of the company to delete</param>
        public static void DeleteCompany(int companyId)
        {
            for (int i = 0; i < Companies.Count; i++)
            {
                if (Companies[i].CId == companyId)      // If the inputted id and id of object are equal
                {
                    if (MessageBox.Show("Are you sure you want to delete this company?", "Delete company", MessageBoxButtons.YesNo) == DialogResult.Yes)    // and deleting was confirmed
                    {
                        Companies.Remove(Companies[i]); // deletes the current object
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Performs creating of the *.pdf document to be printed with advertisment
        /// </summary>
        /// <param name="personId">Id of the person to print</param>
        public static void CreatePdfForPerson(int personId)
        {
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].PId == personId)                  // If the inputted id and id of object are equal
                {
                    PdfDocument document = new PdfDocument();   // creates the PDF object
                    PdfPage page = document.Pages.Add();        // adds a new page
                    PdfGraphics graphics = page.Graphics;       // declares graphics

                    PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);    // and text parameters
                    graphics.DrawString("JOB ADVERTISMENT:", font, PdfBrushes.Black, new PointF(0, 0));                 // Outputs text
                    graphics.DrawString("Personal information:", font, PdfBrushes.Black, new PointF(0, 40));            //
                    graphics.DrawString("Name: " + People[i].Name, font, PdfBrushes.Black, new PointF(0, 70));          //
                    graphics.DrawString("Surname: " + People[i].Surname, font, PdfBrushes.Black, new PointF(0, 90));    //

                    int position = 110;
                    if (People[i].MaritalStatus != "")                                                                                      // Such constructions make output
                    {                                                                                                                       // only if there is an information 
                        graphics.DrawString("Marital status: " + People[i].MaritalStatus, font, PdfBrushes.Black, new PointF(0, position)); // in this property
                        position += 20;
                    }
                    if (People[i].LivingConditions != "")
                    {
                        graphics.DrawString("Living conditions: " + People[i].LivingConditions, font, PdfBrushes.Black, new PointF(0, position));
                        position += 20;
                    }

                    position += 20;
                    graphics.DrawString("Professional expirience:", font, PdfBrushes.Black, new PointF(0, position));

                    position += 30;
                    graphics.DrawString("Profession: " + People[i].Profession, font, PdfBrushes.Black, new PointF(0, position));
                    position += 20;
                    if (People[i].Education != "")
                    {
                        graphics.DrawString("Education: " + People[i].Education, font, PdfBrushes.Black, new PointF(0, position));
                        position += 20;
                    }


                    if (People[i].LastWorkPlace != "" || People[i].LastWorkPosition != "" || People[i].ReasonOfFiring != "")
                    {
                        position += 20;
                        graphics.DrawString("Previous work data:", font, PdfBrushes.Black, new PointF(0, position));
                    }
                    position += 30;
                    if (People[i].LastWorkPosition != "")
                    {
                        graphics.DrawString("Last work place: " + People[i].LastWorkPlace, font, PdfBrushes.Black, new PointF(0, position));
                        position += 20;
                    }
                    if (People[i].LastWorkPosition != "")
                    {
                        graphics.DrawString("Last work postition: " + People[i].LastWorkPosition, font, PdfBrushes.Black, new PointF(0, position));
                        position += 20;
                    }
                    if (People[i].ReasonOfFiring != "")
                    {
                        graphics.DrawString("Reason of firing: " + People[i].ReasonOfFiring, font, PdfBrushes.Black, new PointF(0, position));
                        position += 20;
                    }
                    position += 20;


                    position += 20;
                    graphics.DrawString("Contact information:", font, PdfBrushes.Black, new PointF(0, position));
                    position += 30;
                    if (People[i].TelephoneNumber != "")
                    {
                        graphics.DrawString("Telephone number: " + People[i].TelephoneNumber, font, PdfBrushes.Black, new PointF(0, position));
                        position += 20;
                    }
                    if (People[i].Email != "")
                    {
                        graphics.DrawString("Email: " + People[i].Email, font, PdfBrushes.Black, new PointF(0, position));
                        position += 20;
                    }
                    position += 20;

                    position += 20;
                    if (People[i].Requirements != "")
                    {
                        graphics.DrawString("Requirements: " + People[i].Requirements, font, PdfBrushes.Black, new PointF(0, position));
                    }

                    string fileName = FolderBrowsing() + "person_" + People[i].PId + ".pdf";
                    // Save the document
                    document.Save(fileName);

                    // Close the document
                    document.Close(true);

                    // Open document
                    Process.Start(fileName);
                }
            }
        }

        /// <summary>
        /// Performs creating of the *.pdf document to be printed with advertisment
        /// </summary>
        /// <param name="companyId">Id of the company to print</param>
        public static void CreatePdfForCompany(int companyId)
        {
            for (int i = 0; i < Companies.Count; i++)
            {
                if (Companies[i].CId == companyId)                  // If the inputted id and id of object are equal
                {
                    PdfDocument document = new PdfDocument();       // creates the PDF object
                    PdfPage page = document.Pages.Add();            // adds a new page
                    PdfGraphics graphics = page.Graphics;           // declares graphics

                    PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);    // and text parameters
                    graphics.DrawString("JOB ADVERTISMENT:", font, PdfBrushes.Black, new PointF(0, 0));                             // Outputs text
                    graphics.DrawString("Company name: " + Companies[i].CompanyName, font, PdfBrushes.Black, new PointF(0, 40));    //
                    graphics.DrawString("Position: " + Companies[i].Position, font, PdfBrushes.Black, new PointF(0, 70));           //

                    int position = 100;
                    if (Companies[i].WorkingConditions != "")                                                                                           // Such constructions make output
                    {                                                                                                                                   // only if there is an information 
                        graphics.DrawString("Working conditions: " + Companies[i].WorkingConditions, font, PdfBrushes.Black, new PointF(0, position));  // in this property
                        position += 30;
                    }
                    if (Companies[i].PaymentConditions != "")
                    {
                        graphics.DrawString("Payment conditions: " + Companies[i].PaymentConditions, font, PdfBrushes.Black, new PointF(0, position));
                        position += 30;
                    }
                    if (Companies[i].LivingConditions != "")
                    {
                        graphics.DrawString("Living conditions: " + Companies[i].LivingConditions, font, PdfBrushes.Black, new PointF(0, position));
                        position += 30;
                    }
                    position += 30;
                    if (Companies[i].CompanyRequirements != "")
                    {
                        graphics.DrawString("Requirements: " + Companies[i].CompanyRequirements, font, PdfBrushes.Black, new PointF(0, position));
                    }

                    string fileName = FolderBrowsing() + "person_" + Companies[i].CId + ".pdf";
                    //Save the document
                    document.Save(fileName);

                    //Close the document
                    document.Close(true);

                    Process.Start(fileName);
                }
            }
        }

        /// <summary>
        /// Shows folder dialog to the user to select folder for documents to be printed
        /// </summary>
        /// <returns>Path to the folder</returns>
        private static string FolderBrowsing()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();    // Creates the dialog for folder selecting for PDF output
            folderBrowserDialog.ShowDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            return folderBrowserDialog.SelectedPath;                                // Returns the selected path
        }
    }
}
