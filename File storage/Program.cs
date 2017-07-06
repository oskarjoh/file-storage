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