// See https://aka.ms/new-console-template for more information
using GestoreEventi;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Creiamo un nuovo evento!");
Console.Write("Nome: ");
string titolo = Console.ReadLine();
Console.Write("Data (yyyy年mm月dd日 oppure yyyy/mm/dd): ");
string dataText = Console.ReadLine();
DateOnly data = Utilities.ControllaData(dataText);
Console.Write("Capienza massima: ");