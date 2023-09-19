using Slotmachine;
using System.Net.Security;
using System.Transactions;

var Costumer = new BankAccount("Pelle",1000);
var Casino = new BankAccount("Casino", 300);

Random rnd = new Random();
int rNum = rnd.Next(1, 10);
int WinNum = rnd.Next(1, 10);

int WinningNum = 50;
int CostPerRound = 25;
bool Game=false;



    Console.WriteLine("Hello Would you like to try your luck for 25 kr?PRESS ENTER");
Console.ReadLine();
    Costumer.Transfer(CostPerRound, Casino);
    Console.WriteLine("Current number is {0} Your lucky number is {1}",rNum,WinNum);
Console.WriteLine($"Costumer Saldo{Costumer.Saldo}Casino Saldo{Casino.Saldo}");





{

}
if (rNum == WinNum)
{
    Console.WriteLine("Winner ! HERE is your price");
    Casino.Transfer(WinningNum,Costumer);
    
}
else if(rNum != WinningNum)
{
    Console.WriteLine("Sorry better luck next time, Would you like to try again? y = Yes,n = No");
    string Choice = Console.ReadLine();
    if (Choice == "y")
    {
        Costumer.Transfer(CostPerRound,Casino);
        Console.WriteLine("Current number is {0} Your lucky number is {1}", rNum, WinNum);
        Console.WriteLine($"Costumer Saldo{Costumer.Saldo}Casino Saldo{Casino.Saldo}");
        return;

    }
    else
    {
        Console.WriteLine("Thank you for playing");
        
    }
    
}
