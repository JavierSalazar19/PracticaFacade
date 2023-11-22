using PracticaFacade.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFacade.Subsystem
{
    public class ContactSystem
    {
        public Contact CreateContact()
        {
            Console.WriteLine("introduzca el nombre de usuario");
            string name = Console.ReadLine();

            Console.WriteLine("introduzca el email");
            string email = Console.ReadLine();

            Console.WriteLine("introduzca el numero telefonico");
            string phone = Console.ReadLine();

            Console.WriteLine("introduzca la contra");
            string password = Console.ReadLine();

            Contact contacto1 = new Contact(name, email, phone, password);

            return contacto1;
        }

    }
}
