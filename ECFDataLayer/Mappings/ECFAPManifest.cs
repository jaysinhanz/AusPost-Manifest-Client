using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ECFDataLayer.Mappings
{
    public class ECFAPManifest
    {
        public int XML_Id { get; set; }

        public int Manifest_no { get; set; }

        public string Merchant_Location_Id { get; set; }
        public XmlDocument XML_Contents { get; set; }
    }
}
