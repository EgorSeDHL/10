using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10_страх
{

    internal class Admin: ICRUD
    {
        ConsoleKeyInfo key;
        public int position = 2;
        public string login = "admin.shop";
        public string password = "1qaz2wsx3edc";
        public string name = "Ekaterina";

        public  List<string> all_passwords = new List<string>(){
            "1qaz2wsx3edc",
            "zxcvbnm",
            "qpwoeiruty",
            "qwertyuiop",
            "asdfghjkl"};
        public  List<string> all_roles = new List<string>() {
            "Admin",
            "Warehouse_manager",
            "Accountant",
            "Cashier",
            "Personnel_manager"};
        public  List<string> all_names = new List<string>() {
            "Ekaterina",
            "Anastasia",
            "Ekaterina",
            "Alexander",
            "Ivan",
            };
        public  List<int> all_IDs = new List<int> {
            1111,
            2222,
            3333,
            4444,
            5555};
        int max_names;
        int max;
        public Admin()
        {
            max_names = all_names.Count;
            max = all_names.Count + 5;
        }

        public void Workers()
        {
            Console.Clear();
            Console.SetCursorPosition(55, 0);
            Console.WriteLine("MENU");
            Console.SetCursorPosition(113, 0);
            Console.WriteLine("ADMIN");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            foreach (string i in all_names)
            {
                Console.WriteLine("  " + i);
            }
            Console.WriteLine("  Create");
            Console.WriteLine("  Read");
            Console.WriteLine("  Update");
            Console.WriteLine("  Delete");
        }
        public  void cursor_for_menu()
        {
            Console.CursorVisible = false;
            while (key.Key != ConsoleKey.Enter & position<max_names+1)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position > max)
                    {
                        position = max;
                    }
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position < 2)
                    {
                        position = 2;
                    }
                }
                Console.Clear();
                Workers();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
            }
            read();

            if (position > max_names+1 & key.Key == ConsoleKey.Enter)
            {
                if (position == max_names + 1)
                {
                    create();
                }
                else if (position == max_names + 2)
                {
                    read();
                }
                else if (position == max_names + 3)
                {
                    update();
                }
                else if (position == max_names + 4)
                {
                    delete();
                }
            }

        }
        public  void choose()
        {
            Console.Clear();
            Console.SetCursorPosition(55, 0);
            Console.WriteLine("MENU");
            Console.SetCursorPosition(113, 0);
            Console.WriteLine("ADMIN");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Id: " + all_IDs[position - 2]);
            Console.WriteLine("Name: " + all_names[position - 2]);
            Console.WriteLine("Password: " + all_passwords[position - 2]);
            Console.WriteLine("Role: " + all_roles[position - 2]);
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                cursor_for_menu();
            }
        }
        public void create()
        {
            Console.WriteLine("Enter name");
            all_names.Add(Console.ReadLine());

            Console.WriteLine("Enter password");
            all_passwords.Add(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Enter role");
            all_roles.Add(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Enter ID in format XXXX");
            all_IDs.Add(Console.Read());

            Console.Clear();
            Console.WriteLine("Access!");
        }
        public void read()
        {

        }
        public void update()
        {

        }
        public void delete()
        {

        }
    }
   

    internal interface ICRUD
    {
        void create();
        void read();
        void update();
        void delete();
    }
    public class Chelik
    {   
        public int Id;
        public string Name;
        public post post;
    }
    internal enum ID
    {
        ID_02 = 2,
        ID_03 = 3,
        ID_04 = 4,
        ID_05 = 5
    }
    internal enum workers
    {
        Ekaterina = 2,
        Alexander = 3,
        Ivan = 4,
        Anastasia = 5
    }
    public enum post
    {
        Accounted = 2,
        Cashier = 3,
        Personnel_manager = 4,
        Warehouse_manager = 5 
    }

}
