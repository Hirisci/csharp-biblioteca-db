// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;
using System;
using csharp_biblioteca;
using System.Xml.Linq;

//Gli utenti si possono registrare al sistema
//Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD)
//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.


// Lista libri


Library lib = new Library();
//Console.WriteLine("2) Consulta i libri/Dvd in giacenza");
//Console.WriteLine("3) Ricerca libro/Dvd per titolo");
//Console.WriteLine("4) Ricerca libro/Dvd per Codice");
//Console.WriteLine("5) Consulta i libro/Dvd in prestito");
//Console.WriteLine("6) Prendi in prestito un libro/Dvd (codice/Ibs)");


bool status = true;
do
{
    Console.WriteLine("digita il numero della tua azione");
    Console.WriteLine("1) Consulta il Magazzino della libreria");
    Console.WriteLine("2) Registrati");
    Console.WriteLine("3) Accedi");
    Console.WriteLine("4) Exit");
    Console.Write("digita il numero del azione: ");
    int scelta = Convert.ToInt32(Console.ReadLine());

    switch (scelta)
    {
        case (1):
            Console.WriteLine();
            lib.showStorage();
            Console.WriteLine();
            break;
        case (2):
            Console.WriteLine();
            Console.WriteLine("Dati Registrazione");
            Console.Write("Inserisci nome: ");
            string name = Console.ReadLine();
            Console.Write("Inserisci cognome: ");
            string lastName = Console.ReadLine();
            Console.Write("Inserisci password: ");
            string password = Console.ReadLine();
            Console.Write("Inserisci email: ");
            string email = Console.ReadLine();
            Console.Write("Inserisci number: ");
            string number = Console.ReadLine();
   
            Console.WriteLine();
            Console.WriteLine("UTENTE REGISTRATO CON SUCCESSO");
            Console.WriteLine();
            break;
        case (3):
            Console.WriteLine();
            Console.WriteLine("Inserisci Dati per Accesso");
            Console.Write("Inserisci nome: ");
            name = Console.ReadLine();
            Console.Write("Inserisci cognome: ");
            lastName = Console.ReadLine();
            Console.Write("Inserisci password: ");
            break;
        case (4):
            Console.WriteLine();
            Console.WriteLine("Arrivederci");
            Console.WriteLine();
            status = !status;
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Scelta non valida");
            Console.WriteLine();
            break;
    }
        



} while (status);