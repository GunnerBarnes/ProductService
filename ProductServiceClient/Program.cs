using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://localhost:57036/odata/");
            var container = new ProductService.Container(uri);

            container.SendingRequest2 += (s, e) => Console.WriteLine("{0} {1}", e.RequestMessage.Method, e.RequestMessage.Url);

            // Get the list of products
            foreach (var p in container.Products)
            {
                Console.WriteLine("{0} {1} {2} {3}", p.Name, p.Price, p.Category, p.OrgId);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }

    }
}
