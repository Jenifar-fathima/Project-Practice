using ContactBook.Common;
using ContactBook.Data;

namespace ContactBook
{
    public class ContactBook
    {
        #region Privates
        private static void Main()
        {
            bool bIsRunning = true;

            while (bIsRunning)
            {
                Console.WriteLine(ContactBookMessages.USER_CHOICE);
                Console.Write(ContactBookMessages.ENTER_CHOICE);

                string strChoice = Console.ReadLine() ?? string.Empty;

                switch (strChoice)
                {
                    case "1":
                        CreateContact();
                        break;
                    case "2":
                        ViewAllContact();
                        break;
                    case "3":
                        HandleUpdateDelete(Operation.UPDATE);
                        break;
                    case "4":
                        HandleUpdateDelete(Operation.DELETE);
                        break;
                    case "5":
                        bIsRunning = false;
                        break;
                    default:
                        Console.WriteLine(ContactBookMessages.ERROR_CHOICE);
                        break;
                }
            }
        }

        private static void CreateContact()
        {
            Contact contactObj = new();

            UpdateContactInfo(contactObj);
            DataSet.Add(contactObj);

            Console.WriteLine(ContactBookMessages.ADD_CONTACT_SUCCESS);
        }

        private static void ViewAllContact()
        {
            Console.WriteLine("View Contact List:");

            Console.WriteLine(DataSet.GetAll());
        }

        private static void HandleUpdateDelete(Operation operation)
        {
            Console.Write(operation == Operation.UPDATE ? ContactBookMessages.EDIT_DATA : ContactBookMessages.DELETE_DATA);

            string email = Console.ReadLine() ?? string.Empty;
            Contact? contact = DataSet.FindByEmail(email);

            if (contact != null)
            {
                switch (operation)
                {
                    case Operation.UPDATE:
                        UpdateContact(contact);
                        break;
                    case Operation.DELETE:
                        DeleteContact(contact);
                        break;
                }
            }
            else
            {
                Console.WriteLine(ContactBookMessages.CONTACT_NOT_FOUND);
            }
        }

        private static void UpdateContact(Contact contactToUpdate)
        {
            UpdateContactInfo(contactToUpdate);

            Console.WriteLine(ContactBookMessages.EDIT_CONTACT_SUCCESS);
        }

        private static void DeleteContact(Contact contactToDelete)
        {
            DataSet.Remove(contactToDelete);

            Console.WriteLine(ContactBookMessages.DELETE_CONTACT_SUCCESS);
        }

        private static void UpdateContactInfo(Contact contact)
        {
            Console.WriteLine(ContactBookMessages.ENTER_DETAILS);

            Console.Write("Name: ");
            contact.Name = Console.ReadLine() ?? string.Empty;

            Console.Write("Email: ");
            contact.Email = Console.ReadLine() ?? string.Empty;

            Console.Write("Contact Number: ");
            contact.ContactNumber = Console.ReadLine() ?? string.Empty;
        }
        #endregion
    }
}