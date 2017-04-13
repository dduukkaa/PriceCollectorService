using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCollectorService.Category
{
    public class Thumbnail
    {
        public string url { get; set; }
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

    public class Top5category2
    {
        public bool concatenatecategoryname { get; set; }
        public Thumbnail thumbnail { get; set; }
        public bool hasoffer { get; set; }
        public int parentcategoryid { get; set; }
        public bool isfinal { get; set; }
        public string name { get; set; }
        public List<Link> links { get; set; }
        public int id { get; set; }
    }

    public class Top5category
    {
        public Top5category2 top5category { get; set; }
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

    public class Link4
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Link3
    {
        public Link4 link { get; set; }
    }

    public class Subcategory2
    {
        public bool concatenatecategoryname { get; set; }
        public Thumbnail2 thumbnail { get; set; }
        public bool hasoffer { get; set; }
        public int parentcategoryid { get; set; }
        public bool isfinal { get; set; }
        public string name { get; set; }
        public List<Link3> links { get; set; }
        public int id { get; set; }
    }

    public class Subcategory
    {
        public Subcategory2 subcategory { get; set; }
    }

    public class Thumbnail3
    {
        public string url { get; set; }
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

    public class Category
    {
        public bool concatenatecategoryname { get; set; }
        public Thumbnail3 thumbnail { get; set; }
        public bool hasoffer { get; set; }
        public int parentcategoryid { get; set; }
        public bool isfinal { get; set; }
        public string name { get; set; }
        public List<Link5> links { get; set; }
        public int id { get; set; }
    }

    public class CategoryData
    {
        public int totallooseoffers { get; set; }
        public List<Top5category> top5category { get; set; }
        public Details details { get; set; }
        public int totalresultsavailable { get; set; }
        public int totalresultsreturned { get; set; }
        public List<Subcategory> subcategory { get; set; }
        public Category category { get; set; }
    }
}
