using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGame newGame = new MyGame();

            newGame.ShowMenu();
        }
    }
}
public class MyGame
{
    public User CurrentUser { get; set; }
   
   

    private Action theAttackAction;

    public void ShowMenu()
    {
        
        ConsoleKey key = ConsoleKey.Enter;

        while(key != ConsoleKey.E)
        {
            Console.WriteLine("P -> Punch");
            Console.WriteLine("S -> Attack with Sword");
            Console.WriteLine("K -> Kick");
            Console.WriteLine("B -> Punch and Kick");
            Console.WriteLine("E -> Exit");


            Console.WriteLine("");
            Console.WriteLine("Please Select An Option: ");
            key = Console.ReadKey().Key;

            Console.WriteLine(key);
            switch (key)
            {
                case ConsoleKey.P:
                    theAttackAction = Punch;
                    break;
                case ConsoleKey.S:
                    theAttackAction = AttackWithSword;
                    break;
                case ConsoleKey.K:
                    theAttackAction = Kick;
                    break;
                case ConsoleKey.B:
                    theAttackAction = Punch;
                    theAttackAction += Kick;
                    break;
            }
            HandleAttack();
        }
       
    }
    public void Punch()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("");
        Console.WriteLine("You have been punched");
    }
    public void AttackWithSword()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("");
        Console.WriteLine("You have been attacked with a sword");
    }
    public void Kick()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("");
        Console.WriteLine("You have been kicked");
        
    }
    
    public void HandleAttack()
    {
        theAttackAction();
        
    }

    public bool CanUserBeAttacked(User enemy)
    {
        if (enemy.IsGamer)
            return true;
        if (enemy.ClanInfo.ClanName != CurrentUser.ClanInfo.ClanName)
            return true;

        return false;

    }
    public bool DidEnemyWin(User user)
    {
        if (user.IsGamer)
            return true;

        if (user.ClanInfo.ClanName !=
            CurrentUser.ClanInfo.ClanName)
            return true;

        return false;
    }
    public bool DidEnemyPunch(User user)
    {
        if (user.DidPunch)
            return true;

        if (user.ClanInfo.ClanName != CurrentUser.ClanInfo.ClanName)
            return true;

       return false;
    }
    public bool KickedEnemy(User user)
    {
        if (user.DidKick)
            return false;

        if (user.ClanInfo.ClanName != CurrentUser.ClanInfo.ClanName)
            return false;

        return true;
    }

}
public class User
{
    public string UserName { get; set; }
    public bool DidPunch { get; set; }
    public bool DidKick { get; set; }
    public bool IsGamer { get; set; }
    public Clan ClanInfo { get; set; }
}
public class Clan
{
    public string ClanName { get; set; }
}