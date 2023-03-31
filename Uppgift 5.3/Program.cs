using System;
namespace uppgift5._3
{
    class program
    {
        static void Main(string[] args)
        {
            string[] frågor = new string[4];
            string[] svar = new string[4];

            frågor[0] = "vad heter grundaren till tesla?";
            svar[0] = "elon musk";

            frågor[1] = "Vad är den sista bokstäven i följande bilmärke: BM_";
            svar[1] = "w";

            frågor[2] = "Är detta ett program i visual studio?";
            svar[2] = "ja";

            frågor[3] = "Vilket år är eleverna i klasserna TE21 födda?";
            svar[3] = "2005";

            Console.WriteLine("Du kommer snart få en fråga, skriv svaret i bara små bokstäver");
            Console.WriteLine("Skriv ett nummer mellan 1-4");

            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(frågor[(x-1)]);
            string y = Console.ReadLine();

            if (y == svar[(x-1)])
            {
                Console.WriteLine("Rätt! Bra jobbat!");
            }
            else
            {
                Console.WriteLine("Fel, rätt svar var: " + svar[(x-1)]);
            }

        }
    }
}