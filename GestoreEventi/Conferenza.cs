using System;

namespace GestoreEventi {
	public class Conferenza : Evento {
		private string relatore;
		private double prezzo;
		private DateOnly data;
		private string titolo;

		public Conferenza(string titolo, DateOnly data, uint capienzaMassima, string relatore, double prezzo) : base(titolo, data, capienzaMassima) {
			this.relatore = relatore;
			this.prezzo = prezzo;
			this.titolo = titolo;
			this.data = data;
		}

		public string Relatore { get => relatore; set => relatore = value; }
		public double Prezzo { get => prezzo; set => prezzo = value; }

		public override void StampaEvento(){
			Console.WriteLine("" + data.ToString() + " - " + titolo + " - " + relatore + " - " + prezzo);
		}
    }
}

