using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ECFDataLayer.Mappings
{
    public class Order
    {
        public string order_reference => MerchantLocationID + '_' + ManifestNumber.ToString();
        [JsonIgnore]
        public int ManifestNumber { get; set; }
        [JsonIgnore]
        public string MerchantLocationID { get; set; }
        public Shipment[] shipments { get; set; }
    }

    public class Shipment
    {
        public From from { get; set; }
        public To to { get; set; }
        public Item[] items { get; set; }
    }

    public class From
    {
        public string name { get; set; }
        public string[] lines { get; set; }
        public string suburb { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
    }

    public class To
    {
        public string name { get; set; }
        public string business_name { get; set; }
        public string[] lines { get; set; }
        public string suburb { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
    }

    public class Item
    {
        public string product_id { get; set; }
        public int length { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string weight { get; set; }
        public string consignment_id { get; set; }
        public string article_id { get; set; }
        public string barcode_id { get; set; }
    }
}

