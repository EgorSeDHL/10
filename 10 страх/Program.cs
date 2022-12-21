namespace _10_страх
{
    internal class Program
    {
       

        public static void Main(string[] args)
        {
            Console.SetCursorPosition(55, 0);
            Console.WriteLine("Autorize");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(0,2);
            Console.WriteLine("Enter login: ");
            string log = Console.ReadLine();
            string password = "";
            if (log == Admin.login)
            {
                Console.WriteLine("Enter password: ");
                while (true)
                {
                    var key = Console.ReadKey(true);//не отображаем клавишу - true
                    if (key.Key == ConsoleKey.Enter) break; //enter - выходим из цикла
                    Console.Write("*");//рисуем звезду вместо нее
                    password += key.KeyChar; //копим в пароль символы
                }
                if (password == Admin.password)
                {
                    Console.WriteLine("\nWelcome " + Admin.name + ", you enter as Admin");
                    Admin.cursor_for_menu();
                    
                }
                else
                {
                    Console.WriteLine("Wrong Password or Login. Try again!");
                    Main(args);
                }
            }
            else if (log == Cashier.login)
            {
                Console.WriteLine("enter password");
                while (true)
                {
                    var key = Console.ReadKey(true);//не отображаем клавишу - true
                    if (key.Key == ConsoleKey.Enter) break; //enter - выходим из цикла
                    Console.Write("*");//рисуем звезду вместо нее
                    password += key.KeyChar; //копим в пароль символы
                }

                if (password == Cashier.password)
                {
                    Console.WriteLine("\nWelcome " + Cashier.name +", you enter as Cashier");
                }
                else
                {
                    Console.WriteLine("Wrong Password or Login. Try again!");
                    Main(args);
                }
            }
            else if (log == Personnel_manager.login)
            {
                Console.WriteLine("enter password");
                while (true)
                {
                    var key = Console.ReadKey(true);//не отображаем клавишу - true
                    if (key.Key == ConsoleKey.Enter) break; //enter - выходим из цикла
                    Console.Write("*");//рисуем звезду вместо нее
                    password += key.KeyChar; //копим в пароль символы
                }
                if (password == Personnel_manager.password)
                {
                    Console.WriteLine("\nWelcome,," + Personnel_manager.name + ", you enter as Personnel_manager");
                }
                else
                {
                    Console.WriteLine("Wrong Password or Login. Try again!");
                    Main(args);
                }
            }
            else if (log == Warehouse_manager.login)
            {
                Console.WriteLine("enter password");
                while (true)
                {
                    var key = Console.ReadKey(true);//не отображаем клавишу - true
                    if (key.Key == ConsoleKey.Enter) break; //enter - выходим из цикла
                    Console.Write("*");//рисуем звезду вместо нее
                    password += key.KeyChar; //копим в пароль символы
                }
                if (password == Warehouse_manager.password)
                {
                    Console.WriteLine("\nWelcome," + Warehouse_manager.name + ", you enter as Warehouse_manager");
                }
                else
                {
                    Console.WriteLine("Wrong Password or Login. Try again!");
                    Main(args);
                }
            }
            else if (log == Accountant.login)
            {
                Console.WriteLine("enter password");
                while (true)
                {
                    var key = Console.ReadKey(true);//не отображаем клавишу - true
                    if (key.Key == ConsoleKey.Enter) break; //enter - выходим из цикла
                    Console.Write("*");//рисуем звезду вместо нее
                    password += key.KeyChar; //копим в пароль символы
                }
                if (password == Accountant.password)
                {
                    Console.WriteLine("\nWelcome," + Accountant.name + " you enter as Accountant");
                }
                else
                {
                    Console.WriteLine("Wrong Password or Login. Try again!");
                    Main(args);
                }
            }
            else
            {
                Console.WriteLine("Wrong Login. Try again! Press Enter!");
                Console.ReadLine();
                Console.Clear();
                Main(args);
            }
        }  
         
    }
}