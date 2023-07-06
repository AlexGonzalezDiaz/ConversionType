// Program that takes the users numbers and converts them to boolean values.


Console.Write("Enter a number to convert into a boolean!  \r\n");
String userData = Console.ReadLine();
int userInt = Convert.ToInt32(userData);
bool newBool = Convert.ToBoolean(userInt);
Console.WriteLine("Here is the value as an Boolean: {0}", newBool);
