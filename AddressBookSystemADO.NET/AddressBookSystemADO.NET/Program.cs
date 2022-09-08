namespace AddressBookSystemADO.NET
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to AddressBookSystem ADO.NET");
            AddressBookManagement addressBookManagement = new AddressBookManagement();

            //UC1
            addressBookManagement.DataBaseConnection();

            //UC2
            addressBookManagement.GetAllContact();
        }
    }
}