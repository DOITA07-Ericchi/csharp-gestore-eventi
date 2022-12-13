using GestoreEventi;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Evento evento1 = Management.CostruisciEvento();
evento1.PrenotaPosti();
Management.ChiediDisdette(evento1);

ProgrammaEventi lista1 = Management.CostruisciProgrammaEvento();
Management.AggiungiEventiALista(lista1);

lista1.StampaListaEventi();

// lista1.SvuotaEventi();