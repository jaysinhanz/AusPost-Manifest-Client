using System;
using System.Collections.Generic;
using System.Text;

namespace ECFDataLayer.Mappings
{

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class PCMSManifest
        {

            private string merchantLocationIdField;

            private ushort manifestNumberField;

            private System.DateTime dateSubmittedField;

            private System.DateTime dateLodgedField;

            private PCMSManifestPCMSConsignment[] pCMSConsignmentField;

            /// <remarks/>
            public string MerchantLocationId
            {
                get
                {
                    return this.merchantLocationIdField;
                }
                set
                {
                    this.merchantLocationIdField = value;
                }
            }

            /// <remarks/>
            public ushort ManifestNumber
            {
                get
                {
                    return this.manifestNumberField;
                }
                set
                {
                    this.manifestNumberField = value;
                }
            }

            /// <remarks/>
            public System.DateTime DateSubmitted
            {
                get
                {
                    return this.dateSubmittedField;
                }
                set
                {
                    this.dateSubmittedField = value;
                }
            }

            /// <remarks/>
            public System.DateTime DateLodged
            {
                get
                {
                    return this.dateLodgedField;
                }
                set
                {
                    this.dateLodgedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("PCMSConsignment")]
            public PCMSManifestPCMSConsignment[] PCMSConsignment
            {
                get
                {
                    return this.pCMSConsignmentField;
                }
                set
                {
                    this.pCMSConsignmentField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PCMSManifestPCMSConsignment
        {

            private string consignmentNumberField;

            private string chargeCodeField;

            private string deliveryNameField;

            private string deliveryCompanyNameField;

            private string emailNotificationField;

            private string deliveryAddressLine1Field;

            private object deliveryAddressLine2Field;

            private string deliveryAddressLine3Field;

            private object deliveryAddressLine4Field;

            private string deliverySuburbField;

            private string deliveryStateCodeField;

            private ushort deliveryPostcodeField;

            private string deliveryCountryCodeField;

            private bool isInternationalDeliveryField;

            private string returnNameField;

            private string returnAddressLine1Field;

            private string returnAddressLine2Field;

            private object returnAddressLine3Field;

            private object returnAddressLine4Field;

            private string returnSuburbField;

            private string returnStateCodeField;

            private ushort returnPostcodeField;

            private string returnCountryCodeField;

            private System.DateTime createdDateTimeField;

            private uint postChargeToAccountField;

            private string isSignatureRequiredField;

            private string deliverPartConsignmentField;

            private bool containsDangerousGoodsField;

            private PCMSManifestPCMSConsignmentPCMSDomesticArticle[] pCMSDomesticArticleField;

            /// <remarks/>
            public string ConsignmentNumber
            {
                get
                {
                    return this.consignmentNumberField;
                }
                set
                {
                    this.consignmentNumberField = value;
                }
            }

            /// <remarks/>
            public string ChargeCode
            {
                get
                {
                    return this.chargeCodeField;
                }
                set
                {
                    this.chargeCodeField = value;
                }
            }

            /// <remarks/>
            public string DeliveryName
            {
                get
                {
                    return this.deliveryNameField;
                }
                set
                {
                    this.deliveryNameField = value;
                }
            }

            /// <remarks/>
            public string DeliveryCompanyName
            {
                get
                {
                    return this.deliveryCompanyNameField;
                }
                set
                {
                    this.deliveryCompanyNameField = value;
                }
            }

            /// <remarks/>
            public string EmailNotification
            {
                get
                {
                    return this.emailNotificationField;
                }
                set
                {
                    this.emailNotificationField = value;
                }
            }

            /// <remarks/>
            public string DeliveryAddressLine1
            {
                get
                {
                    return this.deliveryAddressLine1Field;
                }
                set
                {
                    this.deliveryAddressLine1Field = value;
                }
            }

            /// <remarks/>
            public object DeliveryAddressLine2
            {
                get
                {
                    return this.deliveryAddressLine2Field;
                }
                set
                {
                    this.deliveryAddressLine2Field = value;
                }
            }

            /// <remarks/>
            public string DeliveryAddressLine3
            {
                get
                {
                    return this.deliveryAddressLine3Field;
                }
                set
                {
                    this.deliveryAddressLine3Field = value;
                }
            }

            /// <remarks/>
            public object DeliveryAddressLine4
            {
                get
                {
                    return this.deliveryAddressLine4Field;
                }
                set
                {
                    this.deliveryAddressLine4Field = value;
                }
            }

            /// <remarks/>
            public string DeliverySuburb
            {
                get
                {
                    return this.deliverySuburbField;
                }
                set
                {
                    this.deliverySuburbField = value;
                }
            }

            /// <remarks/>
            public string DeliveryStateCode
            {
                get
                {
                    return this.deliveryStateCodeField;
                }
                set
                {
                    this.deliveryStateCodeField = value;
                }
            }

            /// <remarks/>
            public ushort DeliveryPostcode
            {
                get
                {
                    return this.deliveryPostcodeField;
                }
                set
                {
                    this.deliveryPostcodeField = value;
                }
            }

            /// <remarks/>
            public string DeliveryCountryCode
            {
                get
                {
                    return this.deliveryCountryCodeField;
                }
                set
                {
                    this.deliveryCountryCodeField = value;
                }
            }

            /// <remarks/>
            public bool IsInternationalDelivery
            {
                get
                {
                    return this.isInternationalDeliveryField;
                }
                set
                {
                    this.isInternationalDeliveryField = value;
                }
            }

            /// <remarks/>
            public string ReturnName
            {
                get
                {
                    return this.returnNameField;
                }
                set
                {
                    this.returnNameField = value;
                }
            }

            /// <remarks/>
            public string ReturnAddressLine1
            {
                get
                {
                    return this.returnAddressLine1Field;
                }
                set
                {
                    this.returnAddressLine1Field = value;
                }
            }

            /// <remarks/>
            public string ReturnAddressLine2
            {
                get
                {
                    return this.returnAddressLine2Field;
                }
                set
                {
                    this.returnAddressLine2Field = value;
                }
            }

            /// <remarks/>
            public object ReturnAddressLine3
            {
                get
                {
                    return this.returnAddressLine3Field;
                }
                set
                {
                    this.returnAddressLine3Field = value;
                }
            }

            /// <remarks/>
            public object ReturnAddressLine4
            {
                get
                {
                    return this.returnAddressLine4Field;
                }
                set
                {
                    this.returnAddressLine4Field = value;
                }
            }

            /// <remarks/>
            public string ReturnSuburb
            {
                get
                {
                    return this.returnSuburbField;
                }
                set
                {
                    this.returnSuburbField = value;
                }
            }

            /// <remarks/>
            public string ReturnStateCode
            {
                get
                {
                    return this.returnStateCodeField;
                }
                set
                {
                    this.returnStateCodeField = value;
                }
            }

            /// <remarks/>
            public ushort ReturnPostcode
            {
                get
                {
                    return this.returnPostcodeField;
                }
                set
                {
                    this.returnPostcodeField = value;
                }
            }

            /// <remarks/>
            public string ReturnCountryCode
            {
                get
                {
                    return this.returnCountryCodeField;
                }
                set
                {
                    this.returnCountryCodeField = value;
                }
            }

            /// <remarks/>
            public System.DateTime CreatedDateTime
            {
                get
                {
                    return this.createdDateTimeField;
                }
                set
                {
                    this.createdDateTimeField = value;
                }
            }

            /// <remarks/>
            public uint PostChargeToAccount
            {
                get
                {
                    return this.postChargeToAccountField;
                }
                set
                {
                    this.postChargeToAccountField = value;
                }
            }

            /// <remarks/>
            public string IsSignatureRequired
            {
                get
                {
                    return this.isSignatureRequiredField;
                }
                set
                {
                    this.isSignatureRequiredField = value;
                }
            }

            /// <remarks/>
            public string DeliverPartConsignment
            {
                get
                {
                    return this.deliverPartConsignmentField;
                }
                set
                {
                    this.deliverPartConsignmentField = value;
                }
            }

            /// <remarks/>
            public bool ContainsDangerousGoods
            {
                get
                {
                    return this.containsDangerousGoodsField;
                }
                set
                {
                    this.containsDangerousGoodsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("PCMSDomesticArticle")]
            public PCMSManifestPCMSConsignmentPCMSDomesticArticle[] PCMSDomesticArticle
            {
                get
                {
                    return this.pCMSDomesticArticleField;
                }
                set
                {
                    this.pCMSDomesticArticleField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PCMSManifestPCMSConsignmentPCMSDomesticArticle
        {

            private string articleNumberField;

            private string barcodeArticleNumberField;

            private decimal actualWeightField;

            private decimal cubicWeightField;

            private string isTransitCoverRequiredField;

            private decimal transitCoverAmountField;

            private object contentsItemField;

            /// <remarks/>
            public string ArticleNumber
            {
                get
                {
                    return this.articleNumberField;
                }
                set
                {
                    this.articleNumberField = value;
                }
            }

            /// <remarks/>
            public string BarcodeArticleNumber
            {
                get
                {
                    return this.barcodeArticleNumberField;
                }
                set
                {
                    this.barcodeArticleNumberField = value;
                }
            }

            /// <remarks/>
            public decimal ActualWeight
            {
                get
                {
                    return this.actualWeightField;
                }
                set
                {
                    this.actualWeightField = value;
                }
            }

            /// <remarks/>
            public decimal CubicWeight
            {
                get
                {
                    return this.cubicWeightField;
                }
                set
                {
                    this.cubicWeightField = value;
                }
            }

            /// <remarks/>
            public string IsTransitCoverRequired
            {
                get
                {
                    return this.isTransitCoverRequiredField;
                }
                set
                {
                    this.isTransitCoverRequiredField = value;
                }
            }

            /// <remarks/>
            public decimal TransitCoverAmount
            {
                get
                {
                    return this.transitCoverAmountField;
                }
                set
                {
                    this.transitCoverAmountField = value;
                }
            }

            /// <remarks/>
            public object ContentsItem
            {
                get
                {
                    return this.contentsItemField;
                }
                set
                {
                    this.contentsItemField = value;
                }
            }
        }


    }

