using System.Collections;
using System.IO;

namespace HjemmeLekse
{
    public class Program
    {
        static void Main(string[] args)
        {
            string data;
            StreamReader reader = null;

            reader = new StreamReader("C:\\GA\\MinMappe\\Persons.txt");
            data = reader.ReadLine();

            while (data != null)
            {
                Console.WriteLine(data);
                data = reader.ReadLine();
            }

            List<string> list = new List<string>();
        }
    }
}