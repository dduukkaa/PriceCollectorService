using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace PriceCollectorService
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();

            Category.CategoryData categoryData = GetProductCategories();

            if (categoryData != null)
            {
                categoryData.top5category.ForEach(c =>
                {
                    produ products = RequestProductPrice(c.top5category.id.ToString());

                    productList.AddRange(products);
                });

                if (productList.Any())
                {

                }
            }
        }

        //public static List<Product> RequestProductPrice(string url)
        //{
        //    List<Product> productsList = new List<Product>();
        //    Console.WriteLine("- Requesting product price...");

        //    var client = new RestClient(url);

        //    var request = new RestRequest(Method.POST);
            
        //    // execute the request
        //    IRestResponse response = client.Execute(request);
        //    var content = response.Content; // raw content as string
        //    Console.WriteLine("- Processing response...");

        //    //var response2 = client.Execute(request);

        //    JToken token = JObject.Parse(content);

        //    var products = token.SelectToken("product");

        //    if (products != null)
        //    {
        //        Console.WriteLine("- Products received: {0}...", products.Count());
        //        Console.WriteLine("- Adding products to list...");

        //        foreach (var item in products)
        //        {
        //            var product = item.SelectToken("product").ToObject<Product>();

        //            if (product != null)
        //            {
        //                Console.WriteLine("- Adding product {0}...", product.productname);
        //                productsList.Add(product);
        //            }
        //        }
        //    }
        //    else
        //        Console.WriteLine("- Products received: 0...");

        //    return productsList;
        //}

        public static ProductOffer.ProductOfferData RequestProductPrice(string categoryId)
        {
            ProductOffer.ProductOfferData productData = new ProductOffer.ProductOfferData();
            Console.WriteLine("- Requesting Products for category {0}...", categoryId);

            var client = new RestClient("http://sandbox.buscape.com.br/service/findOfferList/");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("{token}/BR/", Method.POST);
            request.AddParameter("categoryId", categoryId); // adds to POST or URL querystring based on Method
            request.AddParameter("format", "json"); // adds to POST or URL querystring based on Method
            request.AddParameter("sourceId", "9262544");
            request.AddUrlSegment("token", "4f714f6c423865466654413d"); // replaces matching token in request.Resource

            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string
            Console.WriteLine("- Processing response...");

            //var response2 = client.Execute(request);

            //JToken token = JObject.Parse(content);

            //var products = token.SelectToken("product");

            productData = JsonConvert.DeserializeObject<Product.ProductData>(content);

            //if (products != null)
            //{
            //    Console.WriteLine("- Products received: {0}...", products.Count());
            //    Console.WriteLine("- Adding products to list...");

            //    foreach (var item in products)
            //    {
            //        var product = item.SelectToken("product").ToObject<Product>();

            //        if (product != null)
            //        {
            //            Console.WriteLine("- Adding product {0}...", product.productname);
            //            productsList.Add(product);
            //        }
            //    }
            //}
            //else
            //    Console.WriteLine("- Products received: 0...");

            return productData;
        }

        public static Category.CategoryData GetProductCategories()
        {
            Category.CategoryData categoryData = new Category.CategoryData();

            var client = new RestClient("http://sandbox.buscape.com/service/findCategoryList/buscape/");

            Console.WriteLine("- Requesting Categories");

            var request = new RestRequest("{token}/BR/", Method.POST);
            request.AddParameter("CategoryId", "0"); // adds to POST or URL querystring based on Method
            request.AddParameter("format", "json"); // adds to POST or URL querystring based on Method
            request.AddUrlSegment("token", "4f714f6c423865466654413d"); // replaces matching token in request.Resource

            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            Console.WriteLine("- Processing response...");

            categoryData = JsonConvert.DeserializeObject<Category.CategoryData>(content);

            //JToken token = JObject.Parse(content);
            //var categories = token.SelectToken("subcategory");
            //var top5categories = token.SelectToken("top5category");

            //if (top5categories!= null)
            //{
            //    Console.WriteLine("- Top5categories received: {0}...", top5categories.Count());
            //    Console.WriteLine("- Adding Top5Categories to list...");

            //    foreach (var item in top5categories)
            //    {
            //        var category = item.SelectToken("top5category").ToObject<CategoryData>();

            //        if (category != null)
            //        {
            //            Console.WriteLine("- Adding category {0}...", category.name);
            //            productCategories.Add(category);
            //        }
            //    }
            //}
            //else
            //    Console.WriteLine("- Top5categories received: 0...");

            //if (categories != null)
            //{
            //    Console.WriteLine("- Categories received: {0}...", categories.Count());
            //    Console.WriteLine("- Adding Categories to list...");

            //    foreach (var item in categories)
            //    {
            //        var category = item.SelectToken("subcategory").ToObject<CategoryData>();

            //        if (category != null && !productCategories.Any(c => c.id == category.id))
            //        {
            //            Console.WriteLine("- Adding category {0}...", category.name);
            //            productCategories.Add(category);
            //        }
            //    }
            //}
            //else
            //    Console.WriteLine("- Categories received: 0...");

            return categoryData;
        }
    }
}
