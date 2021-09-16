using System;

namespace Library
{
    public class Game
    {
        public static var Start()
        {
            // Setup for the game

            // Wizard Set-Up
            Item SpellBook = new Item("SpellBook", 210, 15);
            Item ChronosPendant = new Item("Chronos Pendant", 300, 5);
            Item DoomOrb = new Item("Doom Orb", 100, 25);
            Wizard Thoth = new Wizard("Thoth", 10, 10);
            Wizard.AddItem(DoomOrb);
            Wizard.AddItem(ChronosPendant);
            Wizard.AddItem(SpellBook);
            Thoth.Equip();
            Thoth.PrettyPrint();

            // Menu
            
            Console.WriteLine()
            int contador = 0;
            while(Player1.health && Player2.health > 0)
            {
                Console.WriteLine("Player 1, please choose between these heroes: \n 1- Thoth \n 2- IDK \n 3- IDK \n 4- IDK \n");
                bool unSelected = true;
                while(unSelected)
                {
                    int selection = Console.Read();
                    if(selection == 1)
                    {
                        Wizard Player1 = Thoth;
                        unSelected = false;
                    }
                    else if(selection == 2)
                    {
                        Dwarf Player1 = IDK;
                        unSelected = false;
                    }
                    else if(selection == 3)
                    {
                        Elf Player1 = IDK;
                        unSelected = false;
                    }
                    else if(selection == 4)
                    {
                        UnDead Player1 = IDK;
                        unSelected = false;
                    }
                    else
                    {
                    Console.WriteLine("It seems you pick a correct number, try again \n");  
                    }
                    Console.WriteLine("Player 2, please choose between these heroes: \n 1- Thoth \n 2- IDK \n 3- IDK \n 4- IDK \n");
                    int selection2 = Console.Read();
                    if(selection2 == 1)
                    {
                        Wizard Player2 = Thoth;
                    }
                    else if(selection2 == 2)
                    {
                        Dwarf Player2 = IDK;
                    }
                    else if(selection2 == 3)
                    {
                        Elf Player2 = IDK;
                    }
                    else if(selection2 == 4)
                    {
                        UnDead Player2 = IDK;
                    }
                }

                contador++;
                Console.WriteLine($"Turno {contador} \n");   
            }
        }
    }
}