// See https://aka.ms/new-console-template for more information
Console.Write("Enter a Value to !");
string userData = Console.ReadLine();
int userInt = Convert.ToInt32(userData);
//long userLong = Convert.Tolong; ;
float userFloat = (float)Convert.ToDecimal(userInt,3);
Console.WriteLine("Here is the value as an Int: {0}", userInt);
Console.WriteLine("Here is the value as an Float: {0}", userFloat);
