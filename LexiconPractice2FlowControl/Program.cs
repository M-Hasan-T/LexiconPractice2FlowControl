namespace LexiconPractice2FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                MainMenu();
            } while (true);
        }

        public static void MainMenu()
        {
            Console.WriteLine("Huvudmeny:");
            Console.WriteLine("Skriva in siffror för att testa olika funktioner nedan");
            Console.WriteLine("==================");
            Console.WriteLine("0: Stäng ner programmet");
            Console.WriteLine("1: Bygg ut menyn med val att exekvera de övriga övningarna");
            string firstInput = Console.ReadLine();
            switch (firstInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    do
                    {
                    } while (ExpandMenu() != "0");

                    break;
                default:
                    Console.WriteLine("Det är felaktig input");
                    break;
            }
        }

        public static string ExpandMenu()
        {
            Console.WriteLine("==================");
            Console.WriteLine("Undermeny:");
            Console.WriteLine("1: Ungdom eller pensionär");
            Console.WriteLine("2: Räkna ut priset för ett helt sällskap");
            Console.WriteLine("3: Upprepa tio gånger");
            Console.WriteLine("4: Det tredje ordet");
            Console.WriteLine("0: Huvudmeny");
            string secondInput = Console.ReadLine();
            Console.WriteLine("==================");
            switch (secondInput)
            {
                case "0":
                    MainMenu();
                    break;
                case "1":
                    CalculatePris();
                    break;
                case "2":
                    Console.WriteLine("Hur många är ni som ska gå på bio?: ");
                    bool checkParty = int.TryParse(Console.ReadLine(), out int numOfPeople);
                    if (checkParty)
                    {
                        int sum = 0;
                        for (int i = 0; i < numOfPeople; i++)
                        {
                            int pris = CalculatePris();
                            sum += pris;
                        }
                        Console.WriteLine($"För {numOfPeople} personer:  totalkostnad för hela sällskapet: {sum}");
                    }

                    break;
                case "3":
                    Console.WriteLine("Ange din text: ");
                    string inputText = Console.ReadLine();
                    for (int i = 1; i < 10; i++)
                    {
                        Console.Write($"{i}: {inputText}, ");
                    }
                    Console.WriteLine($"10: {inputText}");
                    break;
                case "4":
                    Console.WriteLine("Ange en mening: ");
                    var inputMening = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (inputMening.Length >= 3)
                    {
                        Console.WriteLine($"Den tredje strängen(ordet): {inputMening[2]}");
                    }
                    break;
                default:
                    Console.WriteLine("Det är felaktig input!");
                    break;
            }
            return secondInput;
        }

        public static int CalculatePris()
        {
            int pris = 0;
            Console.WriteLine("Ange din ålder i siffror: ");
            bool checkAge = byte.TryParse(Console.ReadLine(), out byte age);
            if (checkAge)
            {
                if (age < 5 || age > 100)
                {
                    Console.WriteLine("Barn under fem och pensionärer över 100 går gratis!");
                }
                else if (age < 20)
                {
                    Console.WriteLine("Ungdomspris: 80kr!");
                    pris = 80;
                }
                else if (age > 64)
                {
                    Console.WriteLine("Pensionärspris: 90kr!");
                    pris = 90;
                }
                else
                {
                    Console.WriteLine("Standardpris: 120kr!");
                    pris = 120;
                }
            }
            else Console.WriteLine("Det är felaktig input");
            return pris;
        }

    }
}