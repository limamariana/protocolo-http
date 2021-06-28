using System;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace HttpProj
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReqList();
            ReqUnica();
            Console.ReadLine();


        }    
            static void ReqList()
            {
                var requisition = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/");
                requisition.Method = "GET";
                var response = requisition.GetResponse();
                using (response)
                {
                    var stream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(stream);
                    object data = reader.ReadToEnd();

                    //Console.WriteLine(data.ToString());

                    List<Task> tasks = JsonConvert.DeserializeObject<List<Task>>(data.ToString());

                    foreach (Task task in tasks)
                    {
                        task.Show();
                    }

                    stream.Close();
                    response.Close();
                }
            }
            
            static void ReqUnica()
            {
                var requisition = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/5");
                requisition.Method = "GET";
                var response = requisition.GetResponse();
                 using (response)
                 {
                    var stream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(stream);
                    object data = reader.ReadToEnd();

                    Task task = JsonConvert.DeserializeObject<Task>(data.ToString());
                    task.Show();
                    
                    stream.Close();
                    response.Close();
                 }
            }
    }
}
