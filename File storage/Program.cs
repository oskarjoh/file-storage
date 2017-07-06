using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_storage
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramVerktoy ProgramVerktoy = new ProgramVerktoy();

            if(!File.Exists("brukerdata.txt"))
            {
                ProgramVerktoy.nyBrukerData();
            }
            else
            {
                ProgramVerktoy.lesFraFil();
            }

            Char valg = '0';

            while (valg == '0')
            {
                string muligheter =
                    "Hva ønsker du å gjøre\n\n" +
                    "(1) Logg inn\n" +
                    "(2) Endere Bruker\n" +
                    "(x) Avslutt";

                Console.WriteLine(muligheter);

                valg = Console.ReadKey().KeyChar;

                Console.ReadLine();
                Console.WriteLine("\n");

                switch(valg)
                {
                    case '1':
                        ProgramVerktoy.loggInn();
                        break;
                    case '2':
                        ProgramVerktoy.nyBrukerData();
                        break;
                    default:
                        Console.WriteLine("Feill valg. \n\n");
                        break;
                }
            }
        }
    }

    struct bruker
    {
        public String brukernavn;
        public String password;

        public bruker(StreamReader stream)
        {
            brukernavn = stream.ReadLine();
            password = stream.ReadLine();
        }
    }

    class ProgramVerktoy
    {
        bruker bruker = new bruker();

        public ProgramVerktoy( )
        {

        }

        public void loggInn()
        {
            string tempBrukernavn;
            string temppassword;

            Console.WriteLine("Hva er brkernavnet");
            tempBrukernavn = Console.ReadLine();
            Console.WriteLine("\n\n"); // lager melomrom

            Console.WriteLine("hva er passordet");
            temppassword = Console.ReadLine();
            Console.WriteLine("\n\n"); // lager melomrom

            if(tempBrukernavn == bruker.brukernavn && temppassword == bruker.password)
            {
                string hemeligtekst = "the Ultemate answer \n" +
                    "to life, the universe and evriting \n" +
                    "is 42";
                Console.WriteLine(hemeligtekst);

                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("du feilet med å loge inn");
            }

        }

        public void lesFraFil()
        {
            StreamReader sReder = new StreamReader("brukerdata.txt");

            bruker = new bruker(sReder);

            sReder.Close();
        }

        public void nyBrukerData()
        {
            Console.WriteLine("hva skal det nye brukernavnet vere");
            bruker.brukernavn = Console.ReadLine();
            Console.WriteLine("\n\n");

            Console.WriteLine("hva skal det nye passordet vere");
            bruker.password = Console.ReadLine();
            Console.WriteLine("\n\n");

            skrivTilFil();
        }

        public void skrivTilFil()
        {
            StreamWriter sWriter = new StreamWriter("brukerdata.txt");

            sWriter.WriteLine(bruker.brukernavn);
            sWriter.WriteLine(bruker.password);

            sWriter.Close();
        }
    }   //class
}   //name spaice