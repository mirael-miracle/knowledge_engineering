using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IP_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Поле логiн заповнене?");
            string login1 = Console.ReadLine();
            bool login;
            if (login1 == "y")
            {
                
                login = true;
            }
            else {
                login = false;
            }

            Console.WriteLine("Поле пароль заповнене?");
            string password1 = Console.ReadLine();
            bool password;
            if (password1 == "y")
            {
                
                password = true;
            }
            else
            {
                password = false;
            }

            Console.WriteLine("Логін збігається із регистром бази даних?");
            string login_register1 = Console.ReadLine();
            bool login_register;
            if (login_register1 == "y")
            {
                
                login_register = true;
            }
            else
            {
                login_register = false;
            }

            Console.WriteLine("Пароль збігається із регистром бази даних?");
            string password_register1 = Console.ReadLine();
            bool password_register;
            if (password_register1 == "y")
            {
                
                password_register = true;
            }
            else
            {
                password_register = false;
            }

            Console.WriteLine("Користувач з таким логіном и паролем існує у системі?");
            string login_password_in_system1 = Console.ReadLine();
            bool login_password_in_system;
            if (login_password_in_system1 == "y")
            {
                
                login_password_in_system = true;
            }
            else
            {
                login_password_in_system = false;
            }

            Console.WriteLine("Користувач має доступ до цієї системи?");
            string access1 = Console.ReadLine();
            bool access;
            if (access1 == "y")
            {
                
                access = true;
                
            }
            else
            {
                access = false;
            }
            Console.ReadKey();
            if (((login == true)) &&
   ((password == true)) &&
   ((login_register == true)) &&
   ((password_register == true)) &&
   ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 1 
                Console.WriteLine("Авторизацiя виконана успiшно;");

            }
            // 2  
            if (((login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 2 
                Console.WriteLine("Користувач не має доступу до цієї системи;");

            }
            // 3  
            if (((login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 3 
               Console.WriteLine(" Користувача з таким ім'ям не існує;");

}
            // 4  
            if (((login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 4 
               Console.WriteLine(" Користувача з таким ім'ям не існує;");

}
            // 5  
            if (((login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 5 
                Console.WriteLine("Авторизацiя виконана успішно;");

            }
            // 6  
            if (((login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 6 
                Console.WriteLine("Користувач не має доступу до цієї системи;");

            }
            // 7  
            if (((login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 7 
               Console.WriteLine(" Користувача з таким ім'ям не існує;");

}
            // 8  
            if (((login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 8 
                Console.WriteLine("Користувач не має доступу до цієї системи;");
                Console.WriteLine(" Невірний пароль або логін;");

            }
            // 9  
            if (((login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 9 
                Console.WriteLine("Авторизацiя виконана успішно;");

            }
            // 10  
            if (((login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 10 
                Console.WriteLine("Користувач не має доступу до цієї системи;");

            }
            // 11  
            if (((login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 11 
               Console.WriteLine(" Користувача з таким ім'ям не існує;");

}
            // 12  
            if (((login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 12 
               Console.WriteLine(" Користувача з таким ім'ям не існує;");

}
            // 13  
            if (((login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 13 
                Console.WriteLine(" Невірний пароль або логін;");

            }
            // 14  
            if (((login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 14 
               Console.WriteLine(" Користувача з таким ім'ям не існує;");
            Console.WriteLine("Користувач не має доступу до цієї системи;");

            }
            // 15  
            if (((login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 15 
                Console.WriteLine(" Невірний пароль або логін;");

            }
            // 16  
            if (((login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 16 
               Console.WriteLine(" Користувача з таким ім'ям не існує;");
            Console.WriteLine(" Невірний пароль або логін;");

            }
            // 17  
            if (((login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 17 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 18  
            if (((login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 18 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 19  
            if (((login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 19 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 20  
            if (((login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 20 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 21  
            if (((login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 21 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 22  
            if (((login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 22 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 23  
            if (((login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 23 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 24  
            if (((login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 24 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 25  
            if (((login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 25 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 26  
            if (((login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 26 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 27  
            if (((login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 27 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 28  
            if (((login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 28 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 29  
            if (((login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 29 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 30  
            if (((login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 30 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 31  
            if (((login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 31 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 32  
            if (((login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 32 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 33  
            if ((!(login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 33 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 34  
            if ((!(login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 34 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 35  
            if ((!(login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 35 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 36  
            if ((!(login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 36 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 37  
            if ((!(login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 37 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 38  
            if ((!(login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 38 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 39  
            if ((!(login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 39 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 40  
            if ((!(login == true)) &&
               ((password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 40 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 41  
            if ((!(login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 41 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 42  
            if ((!(login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 42 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 43  
            if ((!(login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 43 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 44  
            if ((!(login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 44 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 45  
            if ((!(login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 45 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 46  
            if ((!(login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 46 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 47  
            if ((!(login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 47 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 48  
            if ((!(login == true)) &&
               ((password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 48 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 49  
            if ((!(login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 49 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 50  
            if ((!(login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 50 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 51  
            if ((!(login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 51 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 52  
            if ((!(login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 52 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 53  
            if ((!(login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 53 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 54  
            if ((!(login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 54 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 55  
            if ((!(login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 55 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 56  
            if ((!(login == true)) &&
               (!(password == true)) &&
               ((login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 56 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 57  
            if ((!(login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 57 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 58  
            if ((!(login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 58 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 59  
            if ((!(login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 59 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 60  
            if ((!(login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               ((password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 60 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 61  
            if ((!(login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 61 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 62  
            if ((!(login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               ((login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 62 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 63  
            if ((!(login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    ((access ==true)) ) {
                // rule 63 
                Console.WriteLine(" Обов`язкові поля не заповнені;;");

}
            // 64  
            if ((!(login == true)) &&
               (!(password == true)) &&
               (!(login_register == true)) &&
               (!(password_register == true)) &&
               (!(login_password_in_system == true)) 
&&
    (!(access ==true)) ) {
                // rule 64 
                Console.WriteLine(" Обов`язкові поля не заповнені;");

}
            Console.ReadKey();
        }
    }
    
}
