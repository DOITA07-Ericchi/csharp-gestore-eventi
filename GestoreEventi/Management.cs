using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi {
    public class Management {

        public static Evento CostruisciEvento() {
            Console.WriteLine("Creiamo un nuovo evento!");
            Console.Write("Nome: ");
            string titolo = Console.ReadLine();
            Console.Write("Data (yyyy年mm月dd日 oppure yyyy/mm/dd): ");
            DateOnly data = Utilities.ControllaData(Console.ReadLine());
            Console.Write("Capienza massima: ");
            uint capienzaMassima = Utilities.ControllaUint(Console.ReadLine());

            return new Evento(titolo, data, capienzaMassima);
        }

        public static void ChiediDisdette(Evento evento) {
            bool ancora = true;
            Console.Write("Vuoi disdire delle prenotazioni? (s/N): ");
            bool disdire = Utilities.convalida();
            if (disdire) {
                while (ancora) {
                    evento.DisdiciPosti();
                    Console.Write("Vuoi disdire altre prenotazioni? (s/N): ");
                    ancora = Utilities.convalida();
                }
            }
        }

        public static ProgrammaEventi CostruisciProgrammaEvento() {
            Console.Write("Inserisci il titolo del programma eventi: ");
            string titolo = Utilities.ControllaVuoti(Console.ReadLine());
            return new ProgrammaEventi(titolo);
        }

        public static void AggiungiEventiALista(ProgrammaEventi lista) {
            Console.Write("Inserisci il numero di eventi da inserire: ");
            uint quanti = Utilities.ControllaUint(Console.ReadLine());
            for (uint i = 0; i<quanti; i++){
                Console.WriteLine("Inserisci i dati per l'evento " + (i + 1) + ".");
                lista.AggiungiEvento(CostruisciEvento());
            }
		}


    }
}
