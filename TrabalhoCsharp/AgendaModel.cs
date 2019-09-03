namespace TrabalhoCsharp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AgendaModel : DbContext
    {
        // Your context has been configured to use a 'AgendaModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TrabalhoCsharp.AgendaModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AgendaModel' 
        // connection string in the application configuration file.
        public AgendaModel()
            : base("name=AgendaModel")
        {
        }
        public virtual DbSet<Contato> Contatos { get; set; }

        public virtual DbSet<Compromisso> Compromissos { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}