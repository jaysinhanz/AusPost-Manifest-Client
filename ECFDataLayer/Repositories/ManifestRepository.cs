using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using Dapper;
using ECFDataLayer.Helper;
using ECFDataLayer.Mappings;
using Microsoft.Extensions.Configuration;

namespace ECFDataLayer.Repositories
{
    public class ManifestRepository: IManifestRepository
    {
        private readonly IConfiguration _configuration;
       
        public ManifestRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Order GetFirstManifest()
        {
           
                using (var db = new SqlConnection(_configuration.GetConnectionString("ECFCentralCon")))
                {
                    var sql = "Select top 1 XML_Id, Manifest_no, Merchant_Location_Id, XML_Contents from OUT_AP_XML;";
                    var result = db.Query<ECFAPManifest>(sql).SingleOrDefault();
                   
                    XmlDocument xmlContents = result.XML_Contents;
                   // var cleanXmlDocument = XMLHelper.RemoveAllNamespaces(xmlContents.ToString());

               // XmlSerializer serializer = new XmlSerializer(typeof(PCMS));
                //MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(xmlContents.ToString()));
                //var resultingMessage = (PCMS)serializer.Deserialize(memStream);

                //var x = (PCMS)serializer.Deserialize(xmlContents.ToString());

                
                var nodes = xmlContents.GetElementsByTagName("PCMSManifest");
                var xmlVal = XMLHelper.RemoveAllNamespaces(nodes[0].OuterXml);
               // XmlDocument xmlDoc = new XmlDocument();
               // xmlDoc.LoadXml(xmlVal);
                XmlSerializer serializer = new XmlSerializer(typeof(PCMSManifest));
                MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(xmlVal));
                var resultingMessage = (PCMSManifest)serializer.Deserialize(memStream);
               // var myOrder = _mapper.Map<PCMSManifest, Order>(resultingMessage);
               Order myOrder = ExtractOrderFromXml(resultingMessage);
              
               return myOrder;
            }
           
        }

        private Order ExtractOrderFromXml(PCMSManifest resultingMessage)
        {
            var myOrder = new Order();
            myOrder.MerchantLocationID = resultingMessage.MerchantLocationId;
            myOrder.ManifestNumber = resultingMessage.ManifestNumber;


               List<Shipment> shipments = new List<Shipment>();
            foreach (var o in resultingMessage.PCMSConsignment)
            {
                List<string> fromlines = new List<string>();

                if (o.ReturnAddressLine1.GetType().Name == "String")
                {
                    if (o.ReturnAddressLine1 != null) fromlines.Add((string)o.ReturnAddressLine1);
                }
                if (o.ReturnAddressLine2.GetType().Name == "String")
                {
                    if (o.ReturnAddressLine2 != null) fromlines.Add((string)o.ReturnAddressLine2);
                }
                if (o.ReturnAddressLine3.GetType().Name == "String")
                {
                    if (o.ReturnAddressLine3 != null) fromlines.Add((string)o.ReturnAddressLine3);
                }
                if (o.ReturnAddressLine4.GetType().Name == "String")
                {
                    if (o.ReturnAddressLine4 != null) fromlines.Add((string)o.ReturnAddressLine4);
                }

                List<string> tolines = new List<string>();

                if (o.DeliveryAddressLine1 != null && o.DeliveryAddressLine1.GetType().Name == "String")
                {
                    if (o.DeliveryAddressLine1 != null) tolines.Add((string)o.DeliveryAddressLine1);
                }
                if (o.DeliveryAddressLine2 != null && o.DeliveryAddressLine2.GetType().Name == "String")
                {
                    if (o.DeliveryAddressLine2 != null) tolines.Add((string)o.DeliveryAddressLine2);
                }
                if (o.DeliveryAddressLine3 != null && o.DeliveryAddressLine3.GetType().Name == "String")
                {
                    if (o.DeliveryAddressLine3 != null) tolines.Add((string)o.DeliveryAddressLine3);
                }
                if (o.DeliveryAddressLine4 != null && o.DeliveryAddressLine4.GetType().Name == "String")
                {
                    if (o.DeliveryAddressLine4 != null) tolines.Add((string)o.DeliveryAddressLine4);
                }
                var shipment = new Shipment
                {
                    from = new From
                    {
                        country = o.ReturnCountryCode,
                        name = o.ReturnName,
                        postcode = o.ReturnPostcode.ToString(),
                        state = o.ReturnStateCode,
                        suburb = o.ReturnSuburb,
                        lines = fromlines.ToArray()
                    },
                    to = new To
                    {
                        business_name = o.DeliveryCompanyName,
                        country = o.DeliveryCountryCode,
                        lines = tolines.ToArray()
                       ,
                        name = o.DeliveryName,
                        postcode = o.DeliveryPostcode.ToString(),
                        state = o.DeliveryStateCode,
                        suburb = o.DeliverySuburb
                    },
                    items = GetItemArray(o, o.ConsignmentNumber)

                };
                shipments.Add(shipment);
            }

            myOrder.shipments = shipments.ToArray();
            return myOrder;
        }

        private Item[] GetItemArray(PCMSManifestPCMSConsignment consignment, string consignmentNumber)
        {
            List<Item> items = new List<Item>();
            foreach (var article in consignment.PCMSDomesticArticle)
            {
                items.Add( new Item
                {
                    article_id = article.ArticleNumber,barcode_id = article.BarcodeArticleNumber
                    ,consignment_id = consignmentNumber,height=10,length = 10,product_id = "7E55",
                    weight = article.ActualWeight.ToString("00.00"), width = 10
                });
                
            }

            return items.ToArray();
        }
    }
}
