using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange
{
    public class Person
    {
        private static int formPId = 0;
        private int pId;
        private string name;
        private string surname;
        private string profession;
        private string education;
        private string lastWorkPlace;
        private string lastWorkPosition;
        private string reasonOfFiring;
        private string maritalStatus;
        private string livingConditions;
        private string telephoneNumber;
        private string email;
        private string requirements;
        private bool archive;

        public int PId
        {
            get { return pId; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public string Education
        {
            get { return education; }
            set { education = value; }
        }

        public string LastWorkPlace
        {
            get { return lastWorkPlace; }
            set { lastWorkPlace = value; }
        }

        public string LastWorkPosition
        {
            get { return lastWorkPosition; }
            set { lastWorkPosition = value; }
        }

        public string ReasonOfFiring
        {
            get { return reasonOfFiring; }
            set { reasonOfFiring = value; }
        }

        public string MaritalStatus
        {
            get { return maritalStatus; }
            set { maritalStatus = value; }
        }

        public string LivingConditions
        {
            get { return livingConditions; }
            set { livingConditions = value; }
        }

        public string TelephoneNumber
        {
            get { return telephoneNumber; }
            set { telephoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Requirements
        {
            get { return requirements; }
            set { requirements = value; }
        }

        public bool Archive
        {
            get { return archive; }
            set { archive = value; }
        }

        public Person()
        {
            pId = formPId;
            formPId++;
            name = "Default";
            surname = "Default";
            profession = "Default";
            education = "Default";
            lastWorkPlace = "Default";
            lastWorkPosition = "Default";
            reasonOfFiring = "Default";
            maritalStatus = "Default";
            livingConditions = "Default";
            telephoneNumber = "Default";
            email = "Default";
            requirements = "Default";
            archive = false;
        }

        public Person(string pName, string pSurname, string pProfession, string pEducation, string pLastWorkPlace, string pLastWorkPosition, 
            string pReasonOfFiring, string pMaterialStatus, string pLivingConditions, string pTelephoneNumber, string pEmail, string pRequirements)
        {
            pId = formPId;
            formPId++;
            name = pName;
            surname = pSurname;
            profession = pProfession;
            education = pEducation;
            lastWorkPlace = pLastWorkPlace;
            lastWorkPosition = pLastWorkPosition;
            reasonOfFiring = pReasonOfFiring;
            maritalStatus = pMaterialStatus;
            livingConditions = pLivingConditions;
            telephoneNumber = pTelephoneNumber;
            email = pEmail;
            requirements = pRequirements;
            archive = false;
        }


    }
}
