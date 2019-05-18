namespace Labor_exchange
{
    public class Company
    {
        private static int formCId = 0;
        private int cId;
        private string companyName;
        private string position;
        private string workingConditions;
        private string paymentConditions;
        private string livingConditions;
        private string companyRequirements;
        private bool archive;

        public int CId
        {
            get { return cId; }
        }
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public string WorkingConditions
        {
            get { return workingConditions; }
            set { workingConditions = value; }
        }
        public string PaymentConditions
        {
            get { return paymentConditions; }
            set { paymentConditions = value; }
        }
        public string LivingConditions
        {
            get { return livingConditions; }
            set { livingConditions = value; }
        }
        public string CompanyRequirements
        {
            get { return companyRequirements; }
            set { companyRequirements = value; }
        }
        public bool Archive
        {
            get { return archive; }
            set { archive = value; }
        }

        public Company()
        {
            cId = formCId;
            formCId++;
            companyName = "Default";
            position = "Default";
            workingConditions = "Default";
            paymentConditions = "Default";
            livingConditions = "Default";
            companyRequirements = "Default";
            archive = false;
        }

        public Company(string cCompany, string cPosition, string cWorkingConditions,
            string cPaymentConditions, string cLivingConditions, string cCompanyRequirements)
        {
            cId = formCId;
            formCId++;
            companyName = cCompany;
            position = cPosition;
            workingConditions = cWorkingConditions;
            paymentConditions = cPaymentConditions;
            livingConditions = cLivingConditions;
            companyRequirements = cCompanyRequirements;
            archive = false;
        }


    }
}
