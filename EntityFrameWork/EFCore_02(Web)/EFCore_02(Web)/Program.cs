using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_02_Web_
{
    public class Program  
    {

        //EFCore ile oluþturacaðýmýz EF projelerinde
        //Ef.net frameworkte yaptýðýmýz gibi sihirbaz ile
        //EF'i projeye dahil edemeyiz!
        //Bunun için KOD YAZMALIYIZ!


        //Yazacaðýmýz kod, context ve entity classlarýný 
        //oluþturarak modelimizi yaratacak.


        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
