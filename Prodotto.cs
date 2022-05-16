using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    internal class Prodotto
    {
        /*
        //dichiaro il nome
        private string Nome;
        //creo un metodo per settare il valore alla variabile nome
        public void SetNome(string name)
        {
            if (name.Length > 10)
                Nome = name.Substring(0, 10);
            else
                Nome = name;
        }
        // faccio diventare una variabile una propietá
        private int Prezzo { get; set; }
        */

        //Attributi dichiarati 
        private int iCodiceProdotto;
        public string sNomeProdotto { get; set; }
        public double dPrezzoProdotto { get; set; }
        public int iIva { get; set; }
        public string? sDescrizione { get; set; }


        public int GetCodice()
        {
            return this.iCodiceProdotto;
        }
        //setto private cosí dopo aver lanciato la prima volta non posso piú richiamare il metodo dall'esterno della classe(solo lettura)
        private void SetCodice()
        {
            Random random = new Random();
            this.iCodiceProdotto = random.Next(1, 99999999);
        }

        public string GetFullNameProduct()
        {
             return string.Format("{0}-{1}", sNomeProdotto, iCodiceProdotto);
            
        }
        public double GetIvaPrice()
        {
            return dPrezzoProdotto + (dPrezzoProdotto * iIva) / 100;
            // return dPrezzoProdotto * (100 + iIva / 100);    
        }

        

        //costruttore della classe prodotto
        public Prodotto(string sNomeProdotto,double dPrezzoProdotto, int iIva)
        {
            SetCodice();
            this.sNomeProdotto = sNomeProdotto;
            this.dPrezzoProdotto = dPrezzoProdotto;
            this.iIva = iIva;
        }
        
    }
}
