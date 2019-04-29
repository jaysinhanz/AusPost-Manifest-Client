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

        public PCMSManifest GetFirstManifest()
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

                return null;
                }
            
        }
    }
}
