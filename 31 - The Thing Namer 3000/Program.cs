Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); // Gets the thing
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); // Gets the thing's description
string c = "Doom"; // Stores the "Doom" string value on the c variable
string d = "3000"; // Stores the "3000" string value on the d variable

/* Finally concatenates string chunks with variable 
 * values and prints a meaningful and powerful title */
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");