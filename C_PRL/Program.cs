using A_DAL.Models;
using C_PRL.MainForms;
using C_PRL.SubForms;
using Microsoft.EntityFrameworkCore;

namespace C_PRL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static public void CreateDatabase()
        {
            using var dbContext = new Duan1Context();
            string dbname = dbContext.Database.GetDbConnection().Database;
            var da = dbContext.Database.EnsureCreated();
            if (da)
                Console.WriteLine($"Tao thanh cong {dbname}");
            else
                Console.WriteLine($"Tao that bai {dbname}");
        }

        static public void DeleteDatabase()
        {
            using var dbContext = new Duan1Context();
            //string dbname = dbContext.Database.GetDbConnection().Database;
            var da = dbContext.Database.EnsureDeleted();
            if (da)
                Console.WriteLine($"Xoa thanh cong");
            else
                Console.WriteLine($"Xoa that bai");
        }
        [STAThread]
        static void Main()
        {
            CreateDatabase();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new DangNhap());
        }
    }
}