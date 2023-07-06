// See https://aka.ms/new-console-template for more information
Console.Write("Enter a number to convert into a boolean!  \r\n");
String userData = Console.ReadLine();
int userInt = Convert.ToInt32(userData);
bool userBool = Convert.ToBoolean(userInt);
Console.WriteLine("Here is the value as an Boolean: {0}", userBool);
