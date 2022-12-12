// See https://aka.ms/new-console-template for more information
// Deliverable 2
// Jeff Santucci 
// 12/10/22

{
    bool validpeople = false;
   // bool choice = false;
    int people;
    int largeLemonade = 0;
    int largeWater = 0;
    double buffet = 9.99;
    double lemonade = 0.00;
    double total;
    string water = "free";


    Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99!  We only charge extra ");
    Console.WriteLine("for lemonade.  How many people are in your group?  Please parties of 6 or lower.");
    while (validpeople == false)
    {
        string input = Console.ReadLine();
        if (int.TryParse(input, out people)) { 
          validpeople = true;
          people = int.Parse(input);
        }
        else
        { Console.WriteLine("You entered a value that is not a number.  Please enter a number from 1 to 6"); 
        }
        if (people > 0 && people < 6)
        {
            double NumBuffets = (people * buffet);
            Console.WriteLine("");
            Console.Write("A table for ");
            Console.Write(people);
            Console.WriteLine("! Please follow me and take a seat.");
            Console.Write("Let's get everyone started with some drinks.");
            Console.WriteLine("  We've got lemonade or water.");
            for (int i = 1; i <= people; i++)
            {
                Console.WriteLine("");
                Console.Write("Alright, person number ");
                Console.Write((int)i);
                Console.WriteLine(", lemonade or water?");
                string indrink = Console.ReadLine();
                bool choice = false;
                while (!choice)
                {
                    if (indrink != "lemonade" && indrink != "water")
                    {
                        Console.WriteLine("Sorry we only have lemonade or water. Please try again.");
                        choice = true;
                        i--;
                    }
                    else
                    {
                        Console.WriteLine(indrink + ", good choice!");
                        if (indrink == "lemonade")
                        {
                            lemonade = lemonade + 2;
                            largeLemonade = largeLemonade + 1;
                            choice = true;
                        }
                        if (indrink == "water")
                        {
                            largeWater = largeWater + 1;
                            choice = true;
                        }
                    }
                }
            }
            if (largeLemonade > 0 && largeWater > 0)
            {
                Console.WriteLine("");
                Console.Write("Okay, so that's ");
                Console.Write(largeLemonade);
                Console.Write(" large Lemonades and ");
                Console.Write(largeWater);
                Console.Write(" large Waters. I'll be right back. Feel free to grab");
                Console.WriteLine(" your food!");
            } 
            else if (largeLemonade > 0)
            {
                Console.WriteLine("");
                Console.Write("Okay, so that's ");
                Console.Write(largeLemonade);
                Console.Write(" large Lemonades");
                Console.Write(" I'll be right back. Feel free to grab");
                Console.WriteLine(" your food!");
            }
            else
            {
                Console.WriteLine("");
                Console.Write("Okay, so that's ");
                Console.Write(largeWater);
                Console.Write(" large Waters.");
                Console.Write(" I'll be right back. Feel free to grab");
                Console.WriteLine(" your food!");
            }

            total = (NumBuffets + lemonade);
            Console.WriteLine("");
            Console.Write("Here's your bill! Total Price: ");
            Console.WriteLine(total.ToString("C2"));
            Console.WriteLine("");
            Console.WriteLine(people + " buffets         = " + people + " X 9.99 = " + NumBuffets);
            if (largeLemonade > 0)
            {
                lemonade = Math.Round(lemonade, 2);
                Console.WriteLine(largeLemonade + " large lemonades = " + largeLemonade + " X 2.00 = " + lemonade + ".00");
            }
            if(largeWater > 0)
            {
                Console.WriteLine(largeWater + " large waters    = free" );
            }
            Console.WriteLine("total = " + total.ToString("C"));
        }
        else 
        { Console.Write("I'm sorry we cannot seat ");
               Console.Write(people);
               Console.WriteLine(" today!");
        }
        
    } 
   
}




