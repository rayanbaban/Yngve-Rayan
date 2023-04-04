using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace HjemmeLekse
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            // Vi må først splitte linje i 3 deler med "," tegnet
            // tolke informasjon, de to første er ok da de er string, men siste er int og vi trenger å parse denne til tall (int.TryParse)
            // Lage et objekt av Person og fyller inn riktig data
            // Legge denne individ i en liste med personer
            // Gå gjennomm listen med personer og skriv ut informasonen (ToSTring()) => foreach ( var p in personList )
            string PersonFile = "C:\\GA\\2.TerminDiv\\HjemmeLekse\\Person.txt";

            using (StreamReader reader = new(PersonFile))
            {
                string? HeadLine = reader.ReadLine();
                if ( HeadLine != null)
                {
                    string? line = reader.ReadLine();
                    while (line != null)
                    {

                        string[] LineSplitValueByComma = line.Split(",");

                        Person individ = new();
                        individ.Fornavn = LineSplitValueByComma[0];
                        individ.EtterNavn = LineSplitValueByComma[1];
                        individ.Alder = int.Parse(LineSplitValueByComma[2]);

                        personList.Add(individ);

                        line = reader.ReadLine();


                    }
                }
            }
            foreach (var i in personList)
            {
                Console.WriteLine(i.ToString());
            }
        }

    }
}