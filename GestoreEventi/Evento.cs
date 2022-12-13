using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi {
    public class Evento {
        private string titolo;
        private DateOnly data;
        private uint capienzaMassima;
        private uint postiPrenotati;


        public Evento(string titolo, DateOnly data, uint capienzaMassima) {
            this.titolo = titolo;
            this.data = data;
            this.capienzaMassima = capienzaMassima;
            this.postiPrenotati = 0;
        }

        public string GetTitolo() {
            return titolo;
        }

        public void SetTitolo(string value) {
            titolo = Utilities.ControllaVuoti(value);
        }

        public DateOnly GetData() {
            return data;
        }

        public void SetData(DateOnly value) {
            data = value;
        }

        public uint CapienzaMassima { get => capienzaMassima; }
        public uint PostiPrenotati { get => postiPrenotati; }

        public void PrenotaPosti() {
            Console.Write("Numero di prenotazioni: ");
            uint prenotazioni = Utilities.ControllaUint(Console.ReadLine());
            this.postiPrenotati += prenotazioni;
            Console.WriteLine("Sono stati prenotati " + prenotazioni + " posti. I posti disponibili ora sono " + (this.CapienzaMassima - this.postiPrenotati) + ".");
        }

        public void DisdiciPosti() {
            Console.Write("Numero di disdette: ");
            uint disdette = Utilities.ControllaUint(Console.ReadLine());
            if (disdette > this.postiPrenotati) {
                throw new Exception("Non puoi disdire un numero di posti maggiore di quelli prenotati!");
            }
            if (DateOnly.FromDateTime(DateTime.Now) > data) {
                throw new Exception("Non puoi disdire posti da un evento passato!");
            }
            this.postiPrenotati -= disdette;
            Console.WriteLine("Sono stati disdette " + disdette + " prenotazioni. I posti disponibili ora sono " + (this.CapienzaMassima - this.postiPrenotati) + ".");
        }

        public virtual void StampaEvento() {
            Console.WriteLine("" + data.ToString() + " - " + titolo);
        }
    }
}
