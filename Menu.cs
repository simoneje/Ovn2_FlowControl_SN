using Ovn2_FlowControl.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ovn2_FlowControl
{
    class Menu
    {
        public const string menu = "Välkommen till huvudmenyn.\n" +
            "Skriv en siffra för att välja funktion. \n" +
            "0 = Avsluta \n" +
            "1 = Ungdom eller pensionär \n" +
            "2 = Pris för sällskap \n" +
            "3 = Upprepa tio gånger \n" +
            "4 = Det tredje ordet.";
        public const string inputMenu = "Ditt val: ";

        
        public static void ConsoleMenu()
        {
            try
            {
                bool running = true;

                while (running)
                {
                    Console.WriteLine(menu);
                    Console.Write(inputMenu);

                    string? input = Console.ReadLine();

                    switch (input)
                    {
                        case "0":
                            running = false;
                            Console.WriteLine("Programmet avslutas.");
                            break;

                        case "1":
                            CinemaServices.ShowPriceForOnePerson();
                            break;

                        case "2":
                            CinemaServices.ShowPriceForMany();
                            break;

                        case "3":
                            TextService.WordRepeater();
                            break;

                        case "4":
                            TextService.ThirdWordExtractor();
                            break;

                        default:
                            Console.WriteLine("Felaktig input, välj 0-4.");
                            break;
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception err)
            {
                Validation.PrintErrorMessage(err.Message);
            }
        }
    }
}
