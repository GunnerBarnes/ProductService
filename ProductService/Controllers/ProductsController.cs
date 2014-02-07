using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using System.Web.Routing;
using ProductService.Models;

namespace ProductService.Controllers
{
    public class ProductsController : ODataController
    {
        private ProductServiceContext db = new ProductServiceContext();

        // GET api/Products
        [Queryable]
        public IQueryable<Product> GetProducts()
        {
            User user = new User();
            user.Name = "Testing";
            user.OrgId = 2;

            return db.Products.AsQueryable().Where(p => p.OrgId == user.OrgId);
        }

        // GET api/Products/5
        public Product GetProduct([FromODataUri] int key)
        {
            Product product = db.Products.SingleOrDefault(p => p.ID == key);
            if (product == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return product;
        }

        // GET /Products(1)/Supplier
        public Supplier GetSupplier([FromODataUri] int key)
        {
            Product product = db.Products.SingleOrDefault(p => p.ID == key);
            if (product == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            if (product.Supplier == null)
            {
                Supplier newSupplier = new Supplier();
                newSupplier.Key = "test";
                newSupplier.Name = "This product doesn't have a supplier";
                return newSupplier;
            }

            return product.Supplier;
        }


        // PUT odata/Products(5)
        public HttpResponseMessage PutProduct([FromODataUri] int key, Product product)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (key != product.ID)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.Entry(product).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST odata/Products
        public HttpResponseMessage PostProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, product);
                response.Headers.Location = new Uri(Url.ODataLink(new EntitySetPathSegment("Product")));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE odata/Products(5)
        public HttpResponseMessage DeleteProduct([FromODataUri] int key)
        {
            Product product = db.Products.Find(key);
            if (product == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Products.Remove(product);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, product);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}