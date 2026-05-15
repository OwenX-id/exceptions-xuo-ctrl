// exercise 3

/// <summary>
/// Write a program that:
/// The user is prompted to enter a number, and the code checks if the number is even or odd.
/// If an error occurs (e.g., if the user enters a non-numeric value), it will catch the exception and display an error message.
/// The finally block will execute regardless of whether an exception was thrown or not.
try:
    Console.WriteLine("Enter a number: ");
    n = Console.ReadLine();


    if n//2 == 0
        Console.WriteLine("Even");
    else
        Console.WriteLine("Odd");
catch (Exception ex)    Console.WriteLine("An error occurred: " + ex.Message);
finally    Console.WriteLine("This block will always execute.");
