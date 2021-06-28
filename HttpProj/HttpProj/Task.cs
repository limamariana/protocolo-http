using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpProj
{
    class Task
    {

        public int userId;
        public int id;
        public string title;
        public bool completed;

        public void Show()
        {
            Console.WriteLine("Task Object");
            Console.WriteLine($"User Id: {userId}");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Completed: {completed}");
            Console.WriteLine(" ");
            Console.WriteLine("====================");


        }
    
    }
}
