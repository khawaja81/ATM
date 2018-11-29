
using System;
class program
{
    public static void Main()
    {

        int AMOUNT = 500, DEPOSIT, WITHDRAW;
        int CHOICE, PIN = 0, X = 0;
        Console.WriteLine("ENTER  YOUR  PIN  NUMBER ");
        PIN = int.Parse(Console.ReadLine());
        while (true)
        {
            Console.WriteLine("********W E L C O M  TO  A T M  S E R V I C E**********\n");
            Console.WriteLine("1. CHECK  BALANCE\n");
            Console.WriteLine("2. WITHDRAW  BALANCE  CASH\n");
            Console.WriteLine("3. DEPOSIT  CASH\n");
            Console.WriteLine("4. QUIT\n");
            Console.WriteLine("*********************************************\n\n");
            Console.WriteLine("ENTER  YOUR  CHOICE : ");
            CHOICE = int.Parse(Console.ReadLine());
            switch (CHOICE)
            {
                case 1:
                    Console.WriteLine("\n YOUR  BALANCE  IN Rs : {0} ", AMOUNT);
                    break;
                case 2:
                    Console.WriteLine("\n ENTER  THE  AMOUNT  TO  WITHDRAW: ");
                    WITHDRAW = int.Parse(Console.ReadLine());
                    if (WITHDRAW % 100 != 0)
                    {
                        Console.WriteLine("\n PLEASE  ENTER  THE  AMOUNT  IN  MULTIPLES  OF  100 ");
                    }
                    else if (WITHDRAW > (AMOUNT - 500))
                    {
                        Console.WriteLine("\n INSUFFICENT  BALANCE");
                    }
                    else
                    {
                        AMOUNT = AMOUNT - WITHDRAW;
                        Console.WriteLine("\n\n PLEASE  COLLECT  CASH");
                        Console.WriteLine("\n YOUR  CURRENT  BALANCE  IS {0}", AMOUNT);
                    }
                    break;
                case 3:
                    Console.WriteLine("\n ENTER  THE  AMOUNT  TO  DEPOSIT");
                    DEPOSIT = int.Parse(Console.ReadLine());
                    AMOUNT = AMOUNT + DEPOSIT;
                    Console.WriteLine("YOUR  BALANCE  IS {0}", AMOUNT);
                    break;
                case 4:
                    Console.WriteLine("\n THANK U USING  A T M");
                    break;
            }
        }
        Console.WriteLine("\n\n THANKS  FOR  USING  OUT  A T M  SERVICE");
    }
}