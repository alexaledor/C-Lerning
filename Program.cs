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

            var client = new ElasticsearchClient("my first test");
            
            Console.WriteLine("------------It's one result --------------");
            List<Test> result = client.GetResult("my first test");
            client.ShowResult(result);
            
            Console.WriteLine();
            Console.WriteLine("------------It's full result --------------");
            List<Test> resultFull = client.GetResult();
            client.ShowResult(resultFull);

            //string res = client.GetResult();

            //Console.WriteLine(res);

            /*var response = client.Search<Test>();
            return response.Documents.ToList();*/

            Console.WriteLine("--------------------------");
            var testArray = new ArrayExample();
            
            int len = testArray.ExampleWithArray();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Array have: " + len + " elements");


            Console.ReadKey();

        }
    }
}
