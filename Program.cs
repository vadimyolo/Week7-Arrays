using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutajale hommikusöögi menüüd.
            //programm palub kasutajal teha valikut
            //programm kuvab kasutaja valikut konsoolis.

            string[] menu = { "omlett", "pannkoogid", "keedumuna", "4-vilja puder", "võileib"};
            Console.WriteLine($"Meie menüüs on {menu.Length} valikut.");

            //menu[3] = "kaerapuder";
            //menu[4] = "juustvõileib.";
           
            Console.WriteLine("Tänases menüüs:");
            for (int i = 0; i < menu.Length; i++)
            {
                if (menu[i] == "4-vilja puder")
                {
                    menu[i] = "kaerapuder";
                }
                else if (menu[i] == "võileib")
                {
                    menu[i] = "singivõileib";
                }
                    Console.WriteLine(menu[i]);
            }

            Console.WriteLine("Palun tee oma valik; (sisesta numbrid 1 - 5.):");
            int userChoice = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"Oled valinud {menu[userChoice]}");


          /* foreach (string menuelement in menu)
            {
                if(menuelement == "4-vilja puder")
                {
                    
                }
                Console.WriteLine(menuelement);
            }
       */ }
    }
}
