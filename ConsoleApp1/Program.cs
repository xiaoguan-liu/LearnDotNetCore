using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { Name = "1" });
            list.Add(new Student() { Name = "2" });
            list.Add(new Student() { Name = "3" });

            //using (var host = WebHost.Start("http://localhost:8080", app => app.Response.WriteAsync("Hello, World!")))
            //{
            //    Console.WriteLine("Use Ctrl-C to shutdown the host...");
            //    host.WaitForShutdown();
            //}

            foreach (var item in list)
            {
                item.Name = item.Name + "1";
            }

            Console.ReadKey();
        }


    }

    public class Student
    {
        public string Name { set; get; }
    }
}
