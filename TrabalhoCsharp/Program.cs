using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Contato contato1 = new Contato();
           
            contato1.Nome = "Lucas";
            contato1.Sobrenome = "Oliveira";
            contato1.Telefone = "997147896";
            contato1.DataNascimento = new DateTime(1996, 07, 25);
            


            Compromisso compromisso1 = new Compromisso();
        
            compromisso1.Titulo = "Cafézinho da tarde";
            compromisso1.Local = "lá em casa";
            compromisso1.Inicio = new DateTime(2019, 09, 02);
            compromisso1.Termino = new DateTime(2019, 09, 02);
            compromisso1.Contatos = new List<Contato>();
            compromisso1.Contatos.Add(contato1);

            AgendaModel context = new AgendaModel();

            context.Contatos.Add(contato1);

            context.Compromissos.Add(compromisso1);

            context.SaveChanges();

            
        }

        }
    }

