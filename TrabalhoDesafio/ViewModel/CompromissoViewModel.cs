using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCsharp;

namespace TrabalhoDesafio.ViewModel
{
    public class CompromissoViewModel
    {
        public ObservableCollection<Compromisso> Compromissos { get; set; }

        public Compromisso CompromissoSelecionado { get; set; }

        public ObservableCollection<Contato> Contatos { get; set; }

        public Contato ContatoSelecionado { get; set; }

        private AgendaModel Context { get; set; }

        public CompromissoViewModel()
        {
            Context = new AgendaModel();
            this.Compromissos = new ObservableCollection<Compromisso>(Context.Compromissos.Include("Contatos").ToList());
            this.CompromissoSelecionado = Context.Compromissos.FirstOrDefault();
            this.Contatos = new ObservableCollection<Contato>(Context.Contatos.ToList());
            this.ContatoSelecionado = Context.Contatos.FirstOrDefault();
           
        }

        public void Adicionar()
        {
            Compromisso c = new Compromisso();
            DateTime dt = DateTime.Now;
            c.Inicio = dt;
            c.Termino = dt;
            this.Compromissos.Add(c);
            this.Context.Compromissos.Add(c);
            this.CompromissoSelecionado = c;
            this.CompromissoSelecionado.Contatos = new ObservableCollection<Contato>();

        }

        public void Salvar()
        {
            this.Context.SaveChanges();
        }

        public void AddContato()
        {
            this.CompromissoSelecionado.Contatos.Add(this.ContatoSelecionado);
        }
    }
}
