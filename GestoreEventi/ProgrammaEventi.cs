using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi {
    public class ProgrammaEventi {
        private string titolo;
        private List<Evento> eventi; 

        public ProgrammaEventi(string titolo) {
            this.titolo = titolo;
            this.eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento evento) {
            this.eventi.Add(evento);
        }

        public void ElencaInData(DateOnly date) {
            Console.WriteLine("Ecco gli eventi in data " + date.ToString() +":");
            foreach (Evento evento in eventi) {
                if (evento.GetData() == DateOnly.FromDateTime(DateTime.Now)) {
                    Console.WriteLine(evento.GetTitolo());
                }
            }
        }

        public List<Evento> OttieniListaEventi() {
            return this.eventi;
        }

        public void EnumeraEventi() {
            Console.WriteLine("Sono presenti " + eventi.Count + " eventi nel programma eventi " + this.titolo + ".");
        }

        public void SvuotaEventi() {
            this.eventi.Clear();
            Console.WriteLine("Tutti gli eventi del programma " + this.titolo + " sono stati eliminati.");
        }
        public void StampaListaEventi(List<Evento> eventiListato) {
            Console.WriteLine("Ecco tutti gli eventi del programma " + this.titolo + ":");
            foreach (Evento evento in eventiListato) {
                Console.WriteLine(evento.GetData() + " - " + evento.GetTitolo());
            }
        }

        public string Titolo { get => titolo; set => titolo = value; }
    }
}
