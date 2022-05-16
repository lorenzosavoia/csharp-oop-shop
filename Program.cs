using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto prodotto1 = new Prodotto("calcolatrice", 12, 22);
            Prodotto prodotto2 = new Prodotto("volano", 15, 22);

            string sFullName = prodotto1.GetFullNameProduct();
            double iPrezzoIvato = prodotto1.GetIvaPrice();

            Console.WriteLine(sFullName);
            Console.WriteLine(iPrezzoIvato);


        }
    }
}

/*
 * Esercizio di oggi: C# Shop nome repo: csharp-oop-shop Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.
 * Un prodotto è caratterizzato da: - codice (numero intero) - nome - descrizione - prezzo - iva.
 * Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
 * - Alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random OK
 * - Il codice prodotto sia accessibile solo in lettura(get)
 * - Gli altri attributi siano accessibili sia in lettura(get) che in scrittura(set)
 * - Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva 
 * - Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome 
 * - Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto. 
 * 
 * BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
 * 
 */