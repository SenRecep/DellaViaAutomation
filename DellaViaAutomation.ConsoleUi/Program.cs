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
            Console.ReadLine();
            // Calistirmadan evel DellaViaAutomation.Dal.ComplexType.EntityFramework.DellaViaAutomationDbModel in olusturucusundaki base kismindaki 
            // @"Data Source=DESKTOP-F562OK2\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DellaViaAutomationDb" ifadesindeki  Catalog Kismini Database ini olusturduktan sonra ve 
            // Source kismindaki yeri duzeltmen lazim 

            //User user = new User
            //{
            //    CreateUserid = 1,
            //    Email="67rsen00@gmail.com",
            //    FirstName="Recep",
            //    LastName="Şen",
            //    IsAdmin = true,
            //    Password="Bubirsifre",
            //    Telephone="+90 531 964 9002",
            //};

            //ManagerBuilder.UserManager.Add(user);
            //DataController.DbSave();
            Console.WriteLine("Islemler bitmistir");
            Console.ReadLine();
        }

    }
}
