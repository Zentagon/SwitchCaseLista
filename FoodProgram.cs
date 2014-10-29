using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Food_program
{
    class Program
    {
        private static void Main(string[] args)
        {
            string dag, mat, kostnad, confirm;
            bool mer = true, mat2 = true, running = true;
            List<string> matList = new List<string>();
            Console.WriteLine("Ett enkelt program som räknar ut dina matkostnader." +
                              " Vi börjar med att skapa en lista över dina kostnader.");
            while (running == true)
            {
                while (mer == true)
                {
                    while (mat2 == true)
                    {
                        Console.Write("Dag: ");
                        dag = Console.ReadLine();
                        Console.Write("Mat: ");
                        mat = Console.ReadLine();
                        Console.Write("Kostnad: ");
                        kostnad = Console.ReadLine();
                        Console.WriteLine(dag + " åt du " + mat + " som kostade " + kostnad);
                        Console.WriteLine("Stämmer detta?");
                        confirm = Console.ReadLine();
                        switch (confirm)
                        {
                            case "Ja":
                                string total = dag + " / " + mat + " / " + kostnad;
                                matList.Add(total);
                                mat2 = false;
                                break;
                            case "Nej":
                                Console.WriteLine("Prova igen!");
                                break;
                        }
                    }

                    Console.Write("Har du ätit något mer denna veckan? : ");
                    confirm = Console.ReadLine();
                    switch (confirm)
                    {
                        case "Ja":
                            Console.WriteLine("Fyll i fälten igen!" + Environment.NewLine);
                            mat2 = true;
                            break;
                        case "Nej":
                            Console.WriteLine("Här är listan på vad du du vilken dag, vad du åt och vad det kostade!" +
                                              Environment.NewLine + Environment.NewLine + Environment.NewLine);
                            mer = false;
                            break;
                    }
                    foreach (var item in matList)
                    {
                        Console.WriteLine(item);
                        
                    }
                    Console.WriteLine("#-#-#-#-#-#-#-#-#-#-#-#-#-#");
                }
                Console.WriteLine("Skriv (Quit) för att stänga ner");
                confirm = Console.ReadLine();
                switch (confirm)
                {
                    case "Quit":
                        running = false;
                        break;
                }
            }
        }
    }
}
