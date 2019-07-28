using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program basladi");
            //for (int i = 0; i < 10; i++)
            //{
            //    test();
            //}

            //Food food = new Food()
            //{
            //    CreateUserid = 1,
            //    Name="Pilav"
            //};
            //ManagerBuilder.FoodManager.Add(food);
            //ManagerBuilder.FoodManager.Delete(x=> x.Name=="Pilav");

            //Ticket ticket = new Ticket()
            //{
            //    user = ManagerBuilder.UserManager.GetById(1),
            //    product = null,
            //    Message = "Hey"
            //};
            //ManagerBuilder.TicketManager.Add(ticket);
            //DataController.DbSave();


            foreach (var item in ManagerBuilder.TicketManager.GetAll())
            {
                Console.WriteLine(item.Message);
            }

            Console.WriteLine("Islemler bitmistir");
            Console.ReadLine();
        }
        static void test()
        {
            var T1 = DateTime.Now;
            var x = ManagerBuilder.FoodManager.GetAll(); 
            var y = ManagerBuilder.UserManager.GetAll();
            foreach (var item in x)
                Console.WriteLine(item.Name);
            foreach (var item in y)
                Console.WriteLine(item.FirstName);
            var res = DateTime.Now -T1;
            Console.WriteLine(res.ToString());

        }

    }
}
