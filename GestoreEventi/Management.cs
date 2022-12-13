using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi {
    public class Management {

        public static Evento CostruisciEvento() {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Creiamo un nuovo evento!");
            Console.Write("Nome: ");
            string titolo = Console.ReadLine();
            Console.Write("Data (yyyy年mm月dd日 oppure yyyy/mm/dd): ");
            DateOnly data = Utilities.ControllaData(Console.ReadLine());
            Console.Write("Capienza massima: ");
            uint capienzaMassima = Utilities.ControllaUint(Console.ReadLine());

            return new Evento(titolo, data, capienzaMassima);
        }

    }
}
