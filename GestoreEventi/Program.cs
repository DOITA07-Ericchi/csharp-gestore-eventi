using GestoreEventi;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Evento evento1 = Management.CostruisciEvento();
evento1.PrenotaPosti();
Management.ChiediDisdette(evento1);