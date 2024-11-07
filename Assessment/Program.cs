using Assessment;

//Question 1
Console.WriteLine("Printing out even numbers");
OutputHandler.PrintEvenNumbers(17, 4);
OutputHandler.PrintEvenNumbers(21, 7);
OutputHandler.PrintEvenNumbers(5, 20);
OutputHandler.PrintEvenNumbers(3, 10);
OutputHandler.PrintEvenNumbers(2, 2);
Console.WriteLine("");
Console.WriteLine("Press anything to continue");
Console.ReadLine();


//Question 2
//A List<Vehicle> would be used to iterate through all the different vehicle types to determine the
//where a vehicle could park, according to the rules. I imagined it would call ad database and have the 
//'WHERE' clause key on the 'AllowedParkingTypes' defined in each derived class property list.