using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCollectorService.ProductOffer
{
    public class Thumbnail
    {
        public string url { get; set; }
    }

    public class Useraveragerating
    {
        public string rating { get; set; }
        public int numcomments { get; set; }
    }

    public class Ebitrating
    {
        public string ratingid { get; set; }
        public string rating { get; set; }
        public string ratingnew { get; set; }
        public int numcomments { get; set; }
        public int ebitid { get; set; }
    }

    public class Rating
    {
        public Useraveragerating useraveragerating { get; set; }
        public Ebitrating ebitrating { get; set; }
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

    public class Contact2
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Contact
    {
        public Contact2 contact { get; set; }
    }

    public class Seller
    {
        public Thumbnail thumbnail { get; set; }
        public bool istrustedstore { get; set; }
        public bool pagamentodigital { get; set; }
        public Rating rating { get; set; }
        public List<Link> links { get; set; }
        public string sellername { get; set; }
        public bool cpcdifferentiated { get; set; }
        public bool oneclickbuy { get; set; }
        public int oneclickbuyvalue { get; set; }
        public int id { get; set; }
        public int advertiserid { get; set; }
        public List<Contact> contacts { get; set; }
        public string extra { get; set; }
    }

    public class Thumbnail2
    {
        public string url { get; set; }
    }

    public class Currency
    {
        public string abbreviation { get; set; }
    }

    public class Parcel
    {
        public int number { get; set; }
        public int interest { get; set; }
        public string value { get; set; }
    }

    public class Price
    {
        public Currency currency { get; set; }
        public string value { get; set; }
        public Parcel parcel { get; set; }
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

    public class Offer2
    {
        public Seller seller { get; set; }
        public Thumbnail2 thumbnail { get; set; }
        public string offername { get; set; }
        public Price price { get; set; }
        public List<Link3> links { get; set; }
        public string offershortname { get; set; }
        public int id { get; set; }
        public string sku { get; set; }
        public int categoryid { get; set; }
        public int? productid { get; set; }
    }

    public class Offer
    {
        public Offer2 offer { get; set; }
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

    public class ProductOfferData
    {
        public List<Offer> offer { get; set; }
        public int totallooseoffers { get; set; }
        public int totalresultssellers { get; set; }
        public Details details { get; set; }
        public int totalpages { get; set; }
        public int page { get; set; }
        public int totalresultsavailable { get; set; }
        public int totalresultsreturned { get; set; }
        public Category category { get; set; }
    }
}
