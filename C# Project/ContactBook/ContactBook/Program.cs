using System;
using System.Collections.Generic;

public class ContactBook
{
    static List<Contact> contactInfo = new List<Contact>();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("User Options:");
            Console.WriteLine("1. Add Contact\n2. View Contact\n3. Update Contact\n4. Delete Contact\n5. Exit\n");
            Console.Write("Enter the choice: ");
            string strChoice = Console.ReadLine();

            switch (strChoice)
            {
                case "1":
                    CreateContact();
                    break;

                case "2":
                    ViewAllContact();
                    break;

                case "3":
                    UpdateContact();
                    break;

                case "4":
                    DeleteContact();
                    break;

                case "5":
                    Console.WriteLine("Exit");
                    return;

                default:
                    Console.WriteLine("Enter option from 1 to 5");
                    break;
            }
        }
    }
    static void CreateContact()
    {
        Console.WriteLine("Enter the user contact details");
        Console.Write("Name: ");
        string strName = Console.ReadLine();
        Console.Write("Email: ");
        string strEmail = Console.ReadLine();
        Console.Write("Contact Number: ");
        string strContactNumber = Console.ReadLine();

        Contact newContact = new Contact(strName, strEmail, strContactNumber);
        contactInfo.Add(newContact);
        Console.WriteLine("Contact added successfully!!!\n");
    }

    static void ViewAllContact()
    {
        Console.WriteLine("View Contact List:");
        foreach (Contact contact in contactInfo)
        {
            Console.WriteLine($"Name: {contact.Name},  Email: {contact.Email}, Contact Number: {contact.ContactNumber}\n");
        }
    }

    static void UpdateContact()
    {
        Console.Write("Enter the email of the contact to update:");
        string email = Console.ReadLine();

        Contact contactToUpdate = contactInfo.FirstOrDefault(c => c.Email == email);

        if (contactToUpdate != null)
        {
            Console.WriteLine("Enter updated contact details:");
            Console.Write("Name: ");
            string strName = Console.ReadLine();
            Console.Write("Email: ");
            string strEmail = Console.ReadLine();
            Console.Write("Contact Number: ");
            string strContactNumber = Console.ReadLine();

            contactToUpdate.Name = strName;
            contactToUpdate.Email = strEmail;
            contactToUpdate.ContactNumber = strContactNumber;

            Console.WriteLine("Contact updated successfully!!!\n");
        }
        else
        {
            Console.WriteLine("Oops!!Contact not found.\n");
        }
    }

    static void DeleteContact()
    {
        Console.Write("Enter the email of the contact to delete:");
        string strEmail = Console.ReadLine();

        Contact contactToDelete = contactInfo.FirstOrDefault(c => c.Email == strEmail);

        if (contactToDelete != null)
        {
            contactInfo.Remove(contactToDelete);
            Console.WriteLine("Contact deleted successfully!!!\n");
        }
        else
        {
            Console.WriteLine("Oops!!Contact not found.\n");
        }
    }
}

class Contact
{
    public string Name
    {
        get;
        set;
    }
    public string ContactNumber
    {
        get;
        set;
    }
    public string Email
    {
        get;
        set;
    }
    public Contact(string Name, string Email, string ContactNumber)
    {
        this.Name = Name;
        this.Email = Email;
        this.ContactNumber = ContactNumber;
    }
}
