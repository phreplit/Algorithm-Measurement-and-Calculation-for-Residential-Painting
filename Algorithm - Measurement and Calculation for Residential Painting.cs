
//  Author: PHNO - Technologist | Postgraduate
//  Release Date: 29/11/2024
//  Version: 0.0.0.2v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algorithm: Measurement and Calculation for Residential Painting, algorithm built in c sharp, built for professionals in the area.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

    namespace Algorithm_Measurement_and_Calculation_for_Residential_Painting
    {
        class Program
        { // classe

            public static void Main(string[] args)
            {

                while (true)
                {
                    // class, method, string
                    Console.WriteLine("\n");
                    Console.WriteLine(" Measurement and Calculation for Residential Painting ");
                    Console.WriteLine("");
                    Console.WriteLine("\n\t     Menu    \n");
                    Console.WriteLine("");
                    Console.WriteLine("1. Calculate Square Meter of a Wall");
                    Console.WriteLine("2. Calculate Quantity of Cans per M²");
                    Console.WriteLine("3. Calculate Quantity of Coats per Can(s)");
                    Console.WriteLine("4. Calculate Quantity of Coats per M²");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("[8] Info");
                    Console.WriteLine("[9] About");

                    Console.WriteLine("\nEnter your choice: "); // choice

                    try
                    {
                        int choice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the height of the wall: ");
                                int v1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.WriteLine("Enter the wall width: ");
                                int v2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                int resultado = v1 * v2;
                                Console.WriteLine("The wall is " + (resultado) + " square meters.");
                                Console.WriteLine();
                                Console.WriteLine("Press enter to return to the menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 2:
                                int qtdtinta = 3600; // 1 can has 3600ml (3.6)
                                int v4 = 360; // amount of paint per 1 square meter
                                Console.WriteLine("Enter how many square meters the wall has: ");
                                int v3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                int resultado2 = (v3 * v4); // amount of paint per (n) so many m²
                                int resultado3 = (resultado2 / qtdtinta); // amount of cans
                                Console.WriteLine();
                                Console.WriteLine("The amount of paint to paint " + (v3) + " M² is " + (resultado2) + " milliliter(s) and the amount of can(s) is " + (resultado3) + " can(s).");
                                Console.WriteLine();
                                Console.WriteLine("Press enter to return to the menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 3:
                                int lata1 = 3600; // 1 can of paint
                                int mq1 = 360; // one square meter
                                int v6 = 3; // 3600ml(3.6) divided by 3 will be 1200ml equivalent to 3 coats
                                Console.WriteLine("Enter the amount of paint cans obtained per M²: ");
                                int v5 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                int resultado4 = (v5 * v6); // coat
                                int calcqtdlitro = (v5 * lata1); // amount of paint
                                int calcmq = (calcqtdlitro / mq1); // square meter
                                Console.WriteLine();
                                Console.WriteLine("The number of coats per " + (v5) + " cans) of paint will be " + (resultado4) + " coat(s).");
                                Console.WriteLine();
                                Console.WriteLine("Press enter to return to the menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 4:                        
                                int lata01 = 3600; // 1 can of paint
                                int mq01 = 360; // one square meter
                                int v8 = 3; // 3600ml(3.6) divided by 3 will be 1200ml equivalent to 3 coats
                                Console.WriteLine("Enter the amount of paint cans obtained per M²: ");
                                int v7 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                int resultado5 = (v7 * v8); // coat
                                int calcqtdlitro01 = (v7 * lata01); // amount of paint
                                int calcmq01 = (calcqtdlitro01 / mq01); // square meter
                                Console.WriteLine();
                                Console.WriteLine("The number of coats to paint " + (calcmq01) + " square meters will be " + (resultado5) + " coat(s).");
                                Console.WriteLine();
                                Console.WriteLine("Press enter to return to the menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 5:
                                Exit();
                                break;
                            case 8:
                                Clear();
                                Console.WriteLine();
                                Console.WriteLine("Info");
                                Console.WriteLine();
                                Console.WriteLine("To Calculate Painting with Undiluted Paint:");
                                Console.WriteLine("Taking a example on a 3.6L paint can and based on a wall with (H 2.70 meters x W 3.70 meters) we have that A x L = a 10M², ");
                                Console.WriteLine("and then we have that 1 can with 3600ml of paint divided by 10 will give 360ml for each 1M², this will be the standard for the calculation 360ml = 1M², ");
                                Console.WriteLine("so, any (N) square meters x 360ml = (N) liters of paint and this result divided by 3600ml will be equal to (N) number of cans of paint.");
                                Console.WriteLine("To calculate one coat: ");
                                Console.WriteLine("To paint one coat we have that a paint tray has 1000ml as a reference per coat, and a can of paint has 3600ml so we have that one can has 1200ml per coat since 1200ml vs 3 = 3600ml (3.6L). ");
                                Console.WriteLine("One coat is equivalent to a complete painting of a wall. Generally it is necessary to paint two to three coats.");
                                Console.WriteLine();
                                Console.WriteLine("Important information: ");
                                Console.WriteLine();
                                Console.WriteLine("This algorithm was built with integer variables so it does not accept numbers with commas, example: 2.90 meters change to 3 meters.");
                                Console.WriteLine();
                                Console.WriteLine("Press enter to return to the menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 9:
                                Clear();
                                Console.WriteLine();
                                Console.WriteLine("Algorithm: Measurement and Calculation for Residential Painting");
                                Console.WriteLine();
                                Console.WriteLine("Author: PHNO");
                                Console.WriteLine("Release Date: 29/11/2024");
                                Console.WriteLine("Version: 0.0.0.2v");
                                Console.WriteLine("Replit: @PHNO, @PHREPLIT");
                                Console.WriteLine("E-mail: phreplit@gmail.com");
                                Console.WriteLine();
                                Console.WriteLine("Press enter to return to the menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            default:
                                Console.WriteLine("Error, choose again! ");
                                Console.WriteLine();
                                Console.WriteLine("Press enter to return to the menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error, system failure.");
                        Console.WriteLine();
                        Console.WriteLine("Press enter to return to the menu...");
                        Console.ReadKey();
                        Clear();
                    }
                }
            }
            public static void Exit()
            { // exit method
                Console.WriteLine();
                Console.WriteLine(" Finished Algorithm! ");
                System.Environment.Exit(-1);
                return;
            }
            public static void Clear()
            { // method 
                Console.Clear();
                return;
            }
        }
    }
