using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Couchbase;
using Couchbase.Configuration;

namespace HelloWorldService
{
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

            //return "insert ok";

            using (var context = new testEntities())
            {
                var query = from p in context.Set<user>() where p.id == "111" select p;
                return query.ToList().ElementAt(0).name;
            }

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
