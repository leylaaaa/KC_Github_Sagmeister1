using System;

namespace KC_Github
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie ihren Benutzernamen an: ");
            Console.ReadLine();
            Console.WriteLine("1. Frage: Was ist Pyhton, a: eine Programmiersprache? b: eine Schlange, c: ein Spiel, d: ein Buch");
            string a = "eine Programmiersprache";
            string b = "eine Schlange";
            string c = "ein Spiel";
            string d = "ein Buch";
            string antwort = "";
            Console.ReadLine();



            while (true) { 
            Console.ReadLine();
            if (antwort == 'a' || 'A' & 'b' || 'B')
            {
                Console.WriteLine("Die Antworten sind richtig");
                    
            }
            else
                {
                    Console.WriteLine("Ihre Antworten sind leider nicht richtig, versuchen Sie es noch einmal");
                }

            }

            Console.WriteLine("2. Frage: kann man mit Phyton Spiele Programmieren? e Nein nur Websiten, f Ja, g Ja aber nicht nur h Nein nur Programme");
            string e = "Nein nur Websiten";
            string f = "Ja";
            string g = "Ja aber nicht nur";
            string h = "Nein nur Programme";
            string antwort2 = Console.ReadLine(); 

            Console.ReadLine();
            if (antwort2 == 'f' || 'F' & 'g' ||'G')
            {
                Console.WriteLine("Die Antworten sind richtig");
            }
            else
            {
                Console.WriteLine("Ihre Antworten sind leider nicht richtig, versuchen Sie es noch einmal");
            }


            //  Console.ReadLine(antworten_benutzer.txt);

            /* while (true) { 
                 if (antwort == 'a'|| == 'A') {
                     Console.WriteLine("Ihre Antwort" +  "war richtig");
                 }
             Console.ReadLine();
        }*/

    }
    }
}
