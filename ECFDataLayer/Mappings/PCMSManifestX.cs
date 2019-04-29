using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ECFDataLayer.Mappings
{
    [XmlRoot("PCMSManifest")]
    public class PCMSManifestX
    {
        [XmlElement("MerchantLocationId")]
        public string MerchantLocationId { get; set; }

        [XmlElement("ManifestNumber")]
        public ushort ManifestNumber { get; set; }

        [XmlElement("dateSubmitted")]
        public DateTime dateSubmitted { get; set; }

        [XmlElement("dateLodged")]
        public DateTime dateLodged { get; set; }

        [XmlArray("PCMSConsignment"), XmlElement("PCMSConsignment")]
        public List<PCMSConsignment> PCMSConsignments { get; set; }
    }

    
    public class PCMSConsignment
    {
        [XmlElement("consignmentNumber")]
        public string consignmentNumber { get; set; }
        [XmlElement("chargeCode")]
        public string chargeCode { get; set; }
        [XmlElement("deliveryName")]
        public string deliveryName { get; set; }
        [XmlElement("deliveryCompanyName")]
        public string deliveryCompanyName { get; set; }
        [XmlElement("emailNotification")]

        public string emailNotification { get; set; }
        [XmlElement("deliveryAddressLine1")]
        public string deliveryAddressLine1 { get; set; }
        [XmlElement("deliveryAddressLine2")]
        public object deliveryAddressLine2 { get; set; }
        [XmlElement("deliveryAddressLine3")]
        public string deliveryAddressLine3 { get; set; }
        [XmlElement("deliveryAddressLine4")]
        public object deliveryAddressLine4 { get; set; }
        [XmlElement("deliverySuburb")]
        public string deliverySuburb { get; set; }
        [XmlElement("deliveryStateCode")]
        public string deliveryStateCode { get; set; }
        [XmlElement("deliveryPostcode")]
        public ushort deliveryPostcode { get; set; }
        [XmlElement("deliveryCountryCode")]
        public string deliveryCountryCode { get; set; }
        [XmlElement("isInternationalDelivery")]
        public bool isInternationalDelivery { get; set; }
        [XmlElement("returnName")]
        public string returnName { get; set; }
        [XmlElement("returnAddressLine1")]
        public string returnAddressLine1 { get; set; }
        [XmlElement("returnAddressLine2")]
        public string returnAddressLine2 { get; set; }
        [XmlElement("returnAddressLine3")]
        public string returnAddressLine3 { get; set; }
        [XmlElement("returnAddressLine4")]
        public string returnAddressLine4 { get; set; }
        [XmlElement("returnSuburb")]
        public string returnSuburb { get; set; }
        [XmlElement("returnStateCode")]
        public string returnStateCode { get; set; }
        [XmlElement("returnPostcode")]
        public ushort returnPostcode { get; set; }
        [XmlElement("returnCountryCode")]
        public string returnCountryCode { get; set; }
        [XmlElement("createdDateTime")]
        public System.DateTime createdDateTime { get; set; }
        [XmlElement("postChargeToAccount")]
        public uint postChargeToAccount { get; set; }
        [XmlElement("isSignatureRequired")]
        public string isSignatureRequired { get; set; }
        [XmlElement("deliverPartConsignment")]
        public string deliverPartConsignment { get; set; }
        [XmlElement("containsDangerousGoods")]
        public bool containsDangerousGoods { get; set; }
        [XmlElement("PCMSDomesticArticle")]
        public List<PCMSDomesticArticle> PCMSDomesticArticles { get; set; }
    }

    public class PCMSDomesticArticle
    {
        [XmlElement("articleNumber")]
        public string articleNumber { get; set; }
        [XmlElement("barcodeArticleNumber")]
        public string barcodeArticleNumber { get; set; }
        [XmlElement("actualWeight")]
        public decimal actualWeight { get; set; }
        [XmlElement("cubicWeight")]
        public decimal cubicWeight { get; set; }
        [XmlElement("isTransitCoverRequired")]
        public string isTransitCoverRequired { get; set; }
        [XmlElement("transitCoverAmount")]
        public decimal transitCoverAmount { get; set; }
        [XmlElement("contentsItem")]
        public object contentsItem { get; set; }


    }

}