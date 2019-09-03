using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCsharp;

namespace TrabalhoDesafio.ViewModel
{
    public class AgendaViewModel
    {
        public ObservableCollection<Contato> Contatos { get; set; }

        public Contato ContatoSelecionado { get; set; }
        
        private AgendaModel Context { get; set; }

        public AgendaViewModel()
        {
            Context = new AgendaModel();
            this.Contatos = new ObservableCollection<Contato>(Context.Contatos.Include("Compromissos").ToList());
            this.ContatoSelecionado = Context.Contatos.FirstOrDefault();
        }

        public void Adicionar()
        {
            Contato c = new Contato();
            DateTime dt = DateTime.Now;
            c.DataNascimento = dt;  
            this.Contatos.Add(c);
            this.Context.Contatos.Add(c);
            this.ContatoSelecionado = c;

        }

        public void Salvar()
        {
            this.Context.SaveChanges();
        }
    }
}
