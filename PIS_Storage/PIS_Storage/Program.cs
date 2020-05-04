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
                /*
                var good = new Good()
                {
                    Name = "Samsung Galaxy S3",
                    Price = 30000
                };
                context.Goods.Add(good); // добавление в промежуточный кэш

                context.SaveChanges(); // добавление в саму бд

                Console.WriteLine($"id: {good.GoodID}, name: {good.Name}, price: {good.Price}");
                */

                /*
                 * Update:
                 * var g = context.Goods.Single(x => x.GoodID = good.GoodID);
                 * g.Name = "Asus 370";
                 * context.SaveChanges();
                 */
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }
    }
}
