using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi {
    public class Utilities {

        public static string ControllaVuoti(string value) {
            bool valido = false;
            while (!valido) {
                if (value == "") {
                    Console.Write("Hai inserito un testo vuoto. Riprova: ");
                    value = Console.ReadLine();
                }
                else {
                    valido = true;
                }
            }
            return value;
        }

    }
}
