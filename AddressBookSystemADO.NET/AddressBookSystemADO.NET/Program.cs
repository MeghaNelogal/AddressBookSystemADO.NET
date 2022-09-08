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

            //UC3
            AddNewContactDetails();

            //UC4                                                      // Zip,   FirstName, LastName
            Console.WriteLine(addressBookManagement.EditContactUsingName("577101", "Ekta", "Kapoor") ? "Update Record successfully\n" : "Update failed");
        }
        //UC3:Ability to insert new Contacts to Address Book
        public static void AddNewContactDetails()
        {
            AddressBookManagement repository = new AddressBookManagement();
            AddressBookModel model = new AddressBookModel();
            model.FirstName = "megha";
            model.LastName = "nelogal";
            model.Address = "RR Nagar";
            model.City = "banglore";
            model.State = "Karnataka";
            model.Zip = "222105";
            model.PhoneNumber = "1234567891";
            model.EmailId = "megha@gmail.com";
            model.AddressBookType = "Friend";
            model.AddressBookName = "Ekta";

            Console.WriteLine(repository.AddDataToTable(model) ? "Record inserted successfully\n" : "Record inserted Failed");
        }
    }
}