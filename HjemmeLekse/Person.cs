using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HjemmeLekse
{
    public class Person
    {
       public Person(){ }


        public Person(string forNavn, string etterNavn, int alder)
        {
            Fornavn = forNavn;
            EtterNavn = etterNavn;
            Alder = alder;

        }
        public string Fornavn { get; set; } = string.Empty;
        public string EtterNavn { get; set; } = string.Empty;
        public int Alder { get; set; } 

        public override string ToString()
        {
            return $"Fornavn: {Fornavn}, Etternavn: {EtterNavn}, Alder: {Alder}";
        }

    }
}

