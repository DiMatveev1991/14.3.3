using System.Linq;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> BooKContact = PhoneBook.PhoneBookList.ContactList();
            SortContact.SortContactList(BooKContact);
        }
    }
}

 
