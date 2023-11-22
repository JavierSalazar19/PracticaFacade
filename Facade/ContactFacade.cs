using PracticaFacade.Entity;
using PracticaFacade.Subsystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFacade.Facade
{
    public class ContactFacade
    {
        protected ContactSystem _contact;

        public ContactFacade(ContactSystem contact)
        {
            this._contact = contact;
        }
        public Contact create()
        {
            Console.WriteLine("Iniciando programa...");
            return this._contact.CreateContact();
        }
    }
}
