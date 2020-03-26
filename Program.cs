using System;
using System.Collections.Generic;
using MyFirstProject.model;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Message mes = new Message();
            string str = mes.HelloMessage();
            Console.WriteLine(str);*/
                                   
            var client = new ElasticsearchClient();

            Console.WriteLine("Input serch string:");
            string inpStr = Console.ReadLine();

            if (inpStr != "")
            {
                Console.WriteLine("------------It's search result --------------");
                List<Test> result = client.GetResult(inpStr);
                client.ShowResult(result);
            } 
            else
            {
                Console.WriteLine();
                Console.WriteLine("------------It's full result --------------");
                List<Test> resultFull = client.GetResult();
                client.ShowResult(resultFull);
            }

            
            /*Console.WriteLine("--------------------------");
            var testArray = new ArrayExample();
            
            int len = testArray.ExampleWithArray();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Array have: " + len + " elements");*/

            Console.ReadKey();

        }
    }
}
