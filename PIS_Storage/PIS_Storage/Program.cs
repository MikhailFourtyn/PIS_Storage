using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_Storage
{
    static class Program
    {
        /// Главная точка входа для приложения.
        [STAThread]
        static void Main()
        {
            // С помощью Using можно не закрывать подключение к БД, происходит автоматически
            using(var context = new PIS_DbContext())
            {
                var good1 = new Good()
                {
                    Name = "Samsung Galaxy S3",
                    Price = 30000
                };
                var good2 = new Good()
                {
                    Name = "Xiaomi 4X",
                    Price = 20000
                };
                var good3 = new Good()
                {
                    Name = "Стол деревянный белый IKEA",
                    Price = 20000
                };
                var good4 = new Good()
                {
                    Name = "Клавиатура Genius",
                    Price = 1000
                };
                context.Goods.Add(good1); // добавление в промежуточный кэш
                context.Goods.Add(good2); // добавление в промежуточный кэш
                context.Goods.Add(good3); // добавление в промежуточный кэш
                context.Goods.Add(good4); // добавление в промежуточный кэш

                context.SaveChanges(); // добавление в саму бд

                /*
                User user1 = new User { Login = "soroka", Name = "Сорокин Михаил Максимович", Password = "qwertyu098", Status = 0 };

                context.Users.Add(user1);

                context.SaveChanges();

                Console.WriteLine($"id: {user1.UserId}, name; {user1.Name}, login: {user1.Login}");

                var good = new Good()
                {
                    Name = "Samsung Galaxy S3",
                    Price = 30000
                };
                context.Goods.Add(good); // добавление в промежуточный кэш

                context.SaveChanges(); // добавление в саму бд

                Console.WriteLine($"id: {good.GoodId}, name: {good.Name}, price: {good.Price}");
                

                
                 // Update:
                 var g = context.Goods.Single(x => x.GoodId == good.GoodId);
                 g.Name = "Asus 370";
                 context.SaveChanges();
                 */

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }
    }
}
