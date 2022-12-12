// Deliverable 1
// Jeff Santucci 
// 12/10/22

{
    int people;
    bool choice = true;
    
    while (choice) 
         
    {
        
        Console.WriteLine("How many people are we making PB and J sandwiches for?");

        people = int.Parse(Console.ReadLine());
        decimal slices = people * 2;
        decimal tablespoonsPB = people * 2;
        decimal teaspoonsJ = people * 4;
        decimal loaves = slices / 28;
        decimal jarPB = tablespoonsPB / 32;
        decimal jarJ = teaspoonsJ / 48;
        Console.WriteLine("");
        Console.WriteLine("You need:");
        Console.WriteLine("");
        Console.Write("\t");
        Console.Write(slices);
        Console.WriteLine(" slices of bread");
        Console.Write("\t");
        Console.Write(tablespoonsPB);
        Console.WriteLine(" tablespoons of peanut butter");
        Console.Write("\t");
        Console.Write(teaspoonsJ);
        Console.WriteLine(" teaspoons of jelly");
        Console.WriteLine("");
        Console.Write("\t");
        Console.WriteLine("which is ...");
        Console.WriteLine("");
        Console.Write("\t");
        Console.Write(Math.Ceiling(loaves));
        Console.WriteLine(" loaves of bread");
        Console.Write("\t");
        Console.Write(Math.Ceiling(jarPB));
        Console.WriteLine(" jars of peanut butter");
        Console.Write("\t");
        Console.Write(Math.Ceiling(jarJ));
        Console.WriteLine(" jars of jelly");
        Console.WriteLine("");
        Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
        string decision = (Console.ReadLine());
      
        if (decision != "yes" && decision != "y") { choice = false; }

        if (choice == false)
        {
            Console.WriteLine("Goodbye!");
        } 
       
    } 

}