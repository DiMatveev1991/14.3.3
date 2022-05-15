using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class SortContact
    {
        public static void SortContactList (List<Contact> phoneBook)
        {
            var sortedStuds = from s in phoneBook orderby s.Name, s.LastName select s;

            foreach (var stud in sortedStuds)
                Console.WriteLine(stud.Name + ", " + stud.LastName + ", " + stud.PhoneNumber + ", " + stud.Email);
        }
    }
}
