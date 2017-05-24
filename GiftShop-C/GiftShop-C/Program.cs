/* Sasha Willden
  03/03/2016 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftShop_C
{//namespace starts
    class Program
    {//class starts
        static int choice;//integer value choice of switch
        const double limit = 1000;
        static int amount = 0;
        const double sun = 0.40;
        const double times = 1.20;
        const double independent = 1.60;
        const double mirror = 0.60;
        const double express = 0.55;
        const double fairy = 0.20;
        const double crisps = 0.50;
        const double bar = 0.60;
        const double sandwish = 1.00;
        const double scones = 0.80;
        const double tea = 1.00;
        const double gtea = 0.80;
        const double coffee = 1.10;
        const double lattee = 1.20;
        const double hchocolate = 0.80;
        const double water = 0.50;
        const double ribena = 0.55;
        const double milk = 0.50;
        const double cola = 0.60;
        const double sprite = 0.60;
        const double pen = 0.30;
        const double pencil = 0.20;
        const double rubber = 0.10;
        const double sharpiner = 0.15;
        const double book = 0.40;
        static double totalcost = 0;
        static void Main(string[] args)
        {//main starts

            try
            {

                char exitProgram = 'Y';

                while (exitProgram == 'Y')
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to The League of Friends Gift Shop!");//welcome message
                    Console.WriteLine("Charitable organisation runs at the heart of Kings Community Hospital.");//welcome message
                    Console.WriteLine("");
                    Console.WriteLine("1 - Papers/Magazines");
                    Console.WriteLine("2 - Food/Refreshers");
                    Console.WriteLine("3 - Hot Drinks");
                    Console.WriteLine("4 - Cold Drinks");
                    Console.WriteLine("5 - Gifts");
                    Console.WriteLine("6 - Pay");
                    choice = int.Parse(Console.ReadLine());
                    bool paid = false;
                    switch (choice)
                    {
                        case 1:
                            paper();
                            break;
                        case 2:
                            food();
                            break;
                        case 3:
                            hot();
                            break;
                        case 4:
                            cold();
                            break;
                        case 5:
                            gifts();
                            break;
                        case 6:
                            paid = pay();
                            break;
                        default:
                            Console.WriteLine("You've entered an incorrect number");
                            break;
                    }
                    Console.WriteLine();
                    if (!paid)
                    {
                        Console.WriteLine("If you want to continue, please enter Y to continue or N to exit the shop:");
                        exitProgram = char.Parse(Console.ReadLine());
                        if (exitProgram == 'N')
                            Environment.Exit(0);
                    }
                    if (paid)
                    {
                        totalcost = 0;
                        Console.WriteLine("If you want to continue, please enter Y to continue or N to exit the shop:");
                        exitProgram = char.Parse(Console.ReadLine());
                        if (exitProgram == 'N')
                            Environment.Exit(0);
                    }


                }
            }
            catch
            {
                Console.WriteLine("An unexpected error has occurred, program ended.");
                Console.ReadKey();
            }

        }

        static void paper()//paper/magazine list
        {
            int x = 0;
            do
            {

                x++;
                Console.WriteLine("");
                Console.WriteLine("Papers/Magazines");
                Console.WriteLine("");
                Console.WriteLine("{1} - The Sun £0.40");
                Console.WriteLine("{2} - The Times £1.20");
                Console.WriteLine("{3} - The Independent £1.60");
                Console.WriteLine("{4} - The Daily Mirror £0.60");
                Console.WriteLine("{5} - The Daily Express £0.55");


                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many papers would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (sun * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'The Sun', costing per item " + sun.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount <= limit)
                                Console.WriteLine("Credit Declined");

                        }
                        break;
                    case 2:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many papers would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (times * amount));
                            Console.WriteLine("You have purcased " + amount + " of 'The Times', costing per item " + times.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount <= limit)
                                Console.WriteLine("Credit Declined");


                        }
                        break;
                    case 3:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many papers would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (independent * amount));
                            Console.WriteLine("You have purcased " + amount + " of 'The Independent', costing per item " + independent.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount <= limit)
                                Console.WriteLine("Credit Declined");

                        }

                        break;
                    case 4:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many papers would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (mirror * amount));
                            Console.WriteLine("You have purcased " + amount + " of 'The Mirror', costing per item" + mirror.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount <= limit)
                                Console.WriteLine("Credit Declined");

                        }
                        break;
                    case 5:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many papers would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (express * amount));
                            Console.WriteLine("You have purcased " + amount + " of 'The Express', costing per item" + express.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount <= limit)
                                Console.WriteLine("Credit Declined");

                        }
                        break;
                    default:
                        Console.WriteLine("You've entered an incorrect number");
                        break;
                }

            } while (x < 0);//counts a loop by a number (optional)
        }
        static void food()//food list
        {
            int x = 0;
            do
            {

                x++;
                Console.WriteLine("");
                Console.WriteLine("Food/Refreshers");
                Console.WriteLine("");
                Console.WriteLine("{1} - Fairy Cakes £0.20");
                Console.WriteLine("{2} - Crisps £0.50");
                Console.WriteLine("{3} - Chocolate Bar £0.60");
                Console.WriteLine("{4} - Sandwish £1.00");
                Console.WriteLine("{5} - Scones with Jam £0.80");


                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Fairy Cakes would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (fairy * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Fairy Cakes', costing per item " + fairy.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));

                        }
                        break;
                    case 2:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Crisps would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (crisps * amount));
                            Console.WriteLine("You have purcased " + amount + " of Crisps, costing per item" + crisps.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }
                        break;
                    case 3:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Chocolate Bar would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (bar * amount));
                            Console.WriteLine("You have purcased " + amount + " of 'Chocolate Bar', costing per item " + bar.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }

                        break;
                    case 4:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Sandwish would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (sandwish * amount));
                            Console.WriteLine("You have purcased " + amount + " of 'Sandwish', costing per item " + sandwish.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }
                        break;
                    case 5:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Scones would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (scones * amount));
                            Console.WriteLine("You have purcased " + amount + " of 'Scones', costing per item " + scones.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }
                        break;
                    default:
                        Console.WriteLine("You've entered an incorrect number");
                        break;
                }

            } while (x < 0);//counts a loop by a number (optional)
        }
        static void hot()//hot drinks list
        {
            int x = 0;
            do
            {

                x++;
                Console.WriteLine("");
                Console.WriteLine("Hot Drinks");
                Console.WriteLine("");
                Console.WriteLine("{1} - Cup of Tea £1.00");
                Console.WriteLine("{2} - Cup of Green Tea £0.80");
                Console.WriteLine("{3} - Cup of Coffee £1.10");
                Console.WriteLine("{4} - Cup of Lattee £1.20");
                Console.WriteLine("{5} - Cup of Hot Chocolate £0.80");


                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Tea would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (tea * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Cup of Tea', costing per item " + tea.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");

                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));


                        }
                        break;
                    case 2:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Green Tea would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (gtea * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Green Tea', costing per item " + gtea.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }
                        break;
                    case 3:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Coffee would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (coffee * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Coffee', costing per item " + coffee.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }

                        break;
                    case 4:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Lattee would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (lattee * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Lattee', costing per item " + lattee.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }
                        break;
                    case 5:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Hot Chocolate would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (hchocolate * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Hot Chocolate', costing per item" + hchocolate.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                            Console.ReadKey();
                        }
                        break;
                    default:
                        Console.WriteLine("You've entered an incorrect number");
                        break;
                }

            } while (x < 0);//counts a loop by a number (optional)

        }
        static void cold()//cold drinks list
        {
            int x = 0;
            do
            {

                x++;
                Console.WriteLine("");
                Console.WriteLine("Cold Drinks");
                Console.WriteLine("");
                Console.WriteLine("{1} - Bottle of Water £0.50");
                Console.WriteLine("{2} - Carten of Ribena £0.55");
                Console.WriteLine("{3} - Carten of Milk £0.50");
                Console.WriteLine("{4} - Can of Cola £0.60");
                Console.WriteLine("{5} - Can of Sprite £0.60");


                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Bottle of Water would you like?");
                            amount = int.Parse(Console.ReadLine());


                            totalcost = (totalcost + (water * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Bottle of Water', costing per item " + water.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));

                        }
                        break;
                    case 2:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Carten of Ribena would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (ribena * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Carten of Ribena', costing per item " + ribena.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }
                        break;
                    case 3:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Milk would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (milk * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Milk', costing per item " + milk.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }

                        break;
                    case 4:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Can of Cola would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (cola * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Can of Cola', costing per item " + cola.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }
                        break;
                    case 5:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Can of Sprite would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (sprite * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Can of Sprite', costing per item " + sprite.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }
                        break;
                    default:
                        Console.WriteLine("You've entered an incorrect number");
                        break;
                }

            } while (x < 0);//counts a loop by a number (optional)
        }
        static void gifts()//gifts list
        {
            int x = 0;
            do
            {

                x++;
                Console.WriteLine("");
                Console.WriteLine("Gifts");
                Console.WriteLine("");
                Console.WriteLine("{1} - Pen £0.30");
                Console.WriteLine("{2} - Pencil £0.20");
                Console.WriteLine("{3} - Rubber £0.10");
                Console.WriteLine("{4} - Sharpiner £0.15");
                Console.WriteLine("{5} - Book Pad £0.40");


                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Pens would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (pen * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Pen', costing per item " + pen.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));

                        }
                        break;
                    case 2:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Pencils would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (pencil * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Pencil', costing per item " + pencil.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }
                        break;
                    case 3:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Rubbers would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (rubber * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Rubber', costing per item " + rubber.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }

                        break;
                    case 4:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Sharpiners would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (sharpiner * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Sharpiner', costing per item " + sharpiner.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }
                        break;
                    case 5:
                        if (amount <= limit)
                        {
                            Console.WriteLine("How many Book Pads would you like?");
                            amount = int.Parse(Console.ReadLine());

                            totalcost = (totalcost + (book * amount));
                            Console.WriteLine("You have purchased " + amount + " of 'Book Pad', costing per item " + book.ToString("C"));
                            if (amount <= limit)
                                Console.WriteLine("Credit Accepted");
                            else if (amount > limit)
                                Console.WriteLine("Credit Declined");


                            Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        }
                        break;
                    default:
                        Console.WriteLine("You've entered an incorrect number");
                        break;
                }

            } while (x < 0);//counts a loop by a number (optional)
        }
        static bool pay()//pay list
        {
            Console.WriteLine("");
            Console.WriteLine("Pay");
            Console.WriteLine("");
            Console.WriteLine("{1} Club Card & Pay");
            Console.WriteLine("{2} Finish & Pay");


            choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    string user, pass;
                    int count = 0;

                    Console.WriteLine("Do you own a Club Card member? Please enter your user and password.");
                    do
                    {
                        Console.Write("Enter username: ");
                        user = Console.ReadLine();

                        Console.Write("Enter password: ");
                        pass = Console.ReadLine();

                        count++;
                    }
                    while (((user != "username") || (pass != "password")) && (count != 5));

                    if (count == 5)
                    {
                        Console.Write("Login attemp fail!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("Password correct!");
                        Console.ReadKey();


                        totalcost = totalcost - ((totalcost / 100) * 15);
                        Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        Console.ReadKey();
                        return true;
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Total Price is " + totalcost.ToString("C"));
                        Console.ReadKey();
                        return true;
                    }
                default:
                    Console.WriteLine("You've entered an incorrect number");
                    return false;
            }
            return false;
        }//main ends
    }//class ends
}//namespace ends