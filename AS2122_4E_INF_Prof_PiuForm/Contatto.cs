using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4E_INF_Prof_PiuForm
{
    class Contatto
    {
        public string Nome { get; }
        public string Indirizzo { get; }
        public string Citta { get; }
        public string Telefono { get; }

        public Contatto (string nome, string indirizzo, string citta, string telefono)
        {
            this.Nome = nome;
            this.Indirizzo = Indirizzo;
            this.Citta = Citta;
            this.Telefono = Telefono;
        } 

        public string Visualizzati()
        {
            return $"{Nome}, {Citta}";
        }
    }
}
