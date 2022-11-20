
string userName;
int password;
Console.WriteLine("Enter the username");
userName = Console.ReadLine();
Console.WriteLine("Enter the password") ;
password = Convert.ToInt32(Console.ReadLine());

if (userName=="admin" && password==12345)
{
    Console.WriteLine("Successful");
}
else
{
    Console.WriteLine("Error");
}