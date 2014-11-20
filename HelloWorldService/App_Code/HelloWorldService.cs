using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceProcess;
//using Couchbase;
//using Couchbase.Configuration;

namespace HelloWorld
{
    static class Program
    {
        static void Main()
        {
#if TRACE
            ServiceHost Host = new ServiceHost(typeof(HelloWorldService));
            Host.Open();
            Console.WriteLine(String.Format("Wcf Service is start"));
            Console.ReadLine();
            Host.Close();
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }

    public class HelloWorldService : IHelloWorldService 
    {
        public string GetMessage(string name)
        {
            //var config = new CouchbaseClientConfiguration();
            //config.Urls.Add(new Uri("http://localhost:8091/pools/"));
            //config.Bucket = "default";

            //var client = new CouchbaseClient(config);
            ////client.ExecuteStore(Enyim.Caching.Memcached.StoreMode.Set, "test");
            //var itemA = client.Get<string>("test");
            //return itemA;

            return "insert ok";

            //using (var context = new testEntities())
            //{
            //    var query = from p in context.Set<user>() where p.id == "111" select p;
            //    return query.ToList().ElementAt(0).name;
            //}

            //using (var context = new testEntities())
            //{
            //    user aa = new user { id="3", name="33333", phone="33333"};
            //    context.user.Add(aa);
            //    context.SaveChanges();
            //    return "insert ok";
            //}
        }

        public testContact GetTestContact(string name)
        {
            testContact aa = new testContact();
            aa.Phone = "777666555";
            return aa;

        }
    }
}
