using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi {
    public class Utilities {

        public static string ControllaVuoti(string value) {
            bool valido = true;
            if (value == "") {
                valido = false;
            }
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

        public static DateOnly ControllaData(string value) {
            CultureInfo japan = CultureInfo.GetCultureInfo("ja-JP");
            DateOnly data = new DateOnly();
            bool valido = DateOnly.TryParse(value, japan, DateTimeStyles.None, out data);
            while (!valido) {
                Console.Write("Data non valida. Riprova (yyyy年mm月dd日 oppure yyyy/mm/dd): ");
                value = Console.ReadLine();
                valido = DateOnly.TryParse(value, japan, DateTimeStyles.None, out data);
            }
            return data;
        }

    }
}
