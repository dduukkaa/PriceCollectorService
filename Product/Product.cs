using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCollectorService.Product
{
    public class Formats
    {
        public int width { get; set; }
        public string url { get; set; }
        public int height { get; set; }
    }

    public class Format
    {
        public Formats formats { get; set; }
    }

    public class Thumbnail
    {
        public List<Format> formats { get; set; }
        public int width { get; set; }
        public string url { get; set; }
        public int height { get; set; }
    }

    public class Link2
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Link
    {
        public Link2 link { get; set; }
    }

    public class Useraveragerating
    {
        public string rating { get; set; }
        public int numcomments { get; set; }
        public List<Link> links { get; set; }
    }

    public class Rating
    {
        public Useraveragerating useraveragerating { get; set; }
    }

    public class Item2
    {
        public string label { get; set; }
        public List<string> value { get; set; }
    }

    public class Item
    {
        public Item2 item { get; set; }
    }

    public class Link4
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Link3
    {
        public Link4 link { get; set; }
    }

    public class Specification
    {
        public List<Item> item { get; set; }
        public List<Link3> links { get; set; }
    }

    public class Link6
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Link5
    {
        public Link6 link { get; set; }
    }

    public class Currency
    {
        public string abbreviation { get; set; }
    }

    public class Product2
    {
        public Thumbnail thumbnail { get; set; }
        public string pricemax { get; set; }
        public int quantity { get; set; }
        public Rating rating { get; set; }
        public Specification specification { get; set; }
        public string productshortname { get; set; }
        public bool hasmetasearch { get; set; }
        public string pricemin { get; set; }
        public bool eco { get; set; }
        public int numoffers { get; set; }
        public int totalsellers { get; set; }
        public string productname { get; set; }
        public List<Link5> links { get; set; }
        public bool fulldescription { get; set; }
        public Currency currency { get; set; }
        public int id { get; set; }
        public int categoryid { get; set; }
    }

    public class Product
    {
        public Product2 product { get; set; }
    }

    public class Eonandyear
    {
        public int lowestsetbit { get; set; }
    }

    public class Xmlschematype
    {
        public string prefix { get; set; }
        public string localpart { get; set; }
        public string namespaceuri { get; set; }
    }

    public class Date
    {
        public bool valid { get; set; }
        public Eonandyear eonandyear { get; set; }
        public int hour { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public int timezone { get; set; }
        public int millisecond { get; set; }
        public Xmlschematype xmlschematype { get; set; }
        public int day { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
    }

    public class Details
    {
        public Date date { get; set; }
        public int code { get; set; }
        public string applicationid { get; set; }
        public int elapsedtime { get; set; }
        public string message { get; set; }
        public string status { get; set; }
    }

    public class Thumbnail2
    {
        public string url { get; set; }
    }

    public class Link8
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Link7
    {
        public Link8 link { get; set; }
    }

    public class Category
    {
        public bool concatenatecategoryname { get; set; }
        public Thumbnail2 thumbnail { get; set; }
        public bool hasoffer { get; set; }
        public int parentcategoryid { get; set; }
        public bool isfinal { get; set; }
        public string name { get; set; }
        public List<Link7> links { get; set; }
        public int id { get; set; }
    }

    public class ProductData
    {
        public List<Product> product { get; set; }
        public int totallooseoffers { get; set; }
        public bool schk { get; set; }
        public string match { get; set; }
        public Details details { get; set; }
        public int totalpages { get; set; }
        public int page { get; set; }
        public int totalresultsavailable { get; set; }
        public int totalresultsreturned { get; set; }
        public Category category { get; set; }
    }
}
