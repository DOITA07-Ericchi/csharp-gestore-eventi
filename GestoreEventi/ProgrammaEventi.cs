using System;
using System.Collections;
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
        public void StampaListaEventi() {
            Console.WriteLine("Ecco tutti gli eventi del programma " + this.titolo + ":");
            foreach (Evento evento in this.eventi) {
                Console.WriteLine(evento.GetData() + " - " + evento.GetTitolo());
            }
        }

        public static void StampaEventiInData(ProgrammaEventi programma, DateOnly date) {
            Console.WriteLine("Ecco gli eventi presenti in data " + date + ":");
			programma.StampaListaEventi();
        }

		public void ChiediEventiInData() {
			Console.Write("Inserisci la data di cui vuoi conoscere gli eventi: ");
			DateOnly date = Utilities.ControllaData(Console.ReadLine());
			ProgrammaEventi temp = new ProgrammaEventi("Programma temporaneo per la stampa degli eventi");
			foreach (Evento evento in this.eventi) {
				if (evento.GetData() == date) {
					temp.AggiungiEvento(evento);
				}
			}
            StampaEventiInData(temp, date);
		}

		public string Titolo { get => titolo; set => titolo = value; }
    }
}
