using PracticaFacade.Subsystem;
using PracticaFacade.Facade;

ContactSystem subsystem= new ContactSystem();

ContactFacade facade = new ContactFacade(subsystem);

Console.WriteLine(facade.create().ToString());