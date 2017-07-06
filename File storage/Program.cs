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

            Console.WriteLine("hva er passordet");
            temppassword = Console.ReadLine();
        }

        public void lesFraFil()
        {
            
        }

        public void nyBrukerData()
        {
            
        }
    }   //class
}   //name spaice
