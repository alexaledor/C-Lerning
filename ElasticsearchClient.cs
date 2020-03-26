using Nest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MyFirstProject.model;

namespace MyFirstProject
{
    public class ElasticsearchClient
    {
        private ElasticClient client = null;
        //private string serchString;

        public ElasticsearchClient()
        {
            var uri = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(uri);
            client = new ElasticClient(settings);
            settings.DefaultIndex("test");
            
            //serchString = condition;
            
            var response = client.Cluster.Health();
            Console.WriteLine(response.Status);            
        }

        public List<Test> GetResult()        
        {
            if (client.Indices.Exists("test").Exists) {                

                /*var searchResponse = client.Search<Test>(s => s
                    .MatchAll(m => m));*/

                var searchResponse = client.Search<Test>();
                return searchResponse.Documents.ToList();
            }
            else {
                return null;
            }                          
        }

        public List<Test> GetResult(string condition)
        {
            if (client.Indices.Exists("test").Exists)
            {
                //var query = serchString;

                return client.Search<Test>(s => s
                .AllIndices()
                .Query(q => q
                    .Match(m => m
                        .Field("title")
                        .Query(condition)// "my first test"
                        .Operator(Operator.And)))).Documents.ToList();
            }
            return null;
        }

        public void ShowResult(List<Test> result)
        {
            foreach (var one in result)
            {
                Console.WriteLine(one.title + " -- " + one.categoty);
            }
        }
    }
}
