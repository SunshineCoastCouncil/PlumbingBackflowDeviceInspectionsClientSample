using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PlumbingBackflowDeviceInspectionsClientSample
{
    class Inspection
    {
        [JsonProperty("company")]
        public Company Company { get; set; }

        [JsonProperty("application")]
        public Application Application { get; set; }

        [JsonProperty("testDateTime")]
        public DateTimeOffset TestDateTime { get; set; }

        [JsonProperty("testKitLastVerified")]
        public DateTimeOffset TestKitLastVerified { get; set; }

        [JsonProperty("testResult")]
        public string TestResult { get; set; }

        [JsonProperty("appendix")]
        public string Appendix { get; set; }

        [JsonProperty("testerFirstName")]
        public string TesterFirstName { get; set; }

        [JsonProperty("testerLastName")]
        public string TesterLastName { get; set; }

        [JsonProperty("testerLicenceNo")]
        public string TesterLicenceNo { get; set; }

        [JsonProperty("testComment")]
        public string TestComment { get; set; }

        [JsonProperty("pdfDocumentInBase64")]
        public string PdfDocumentInBase64 { get; set; }

        [JsonProperty("pdfDocument2InBase64")]
        public string PdfDocument2InBase64 { get; set; }

        [JsonProperty("serialNumberPhotoInBase64")]
        public string SerialNumberPhotoInBase64 { get; set; }

        [JsonProperty("devicePhotoInBase64")]
        public string DevicePhotoInBase64 { get; set; }

        [JsonProperty("locationPhotoInBase64")]
        public string LocationPhotoInBase64 { get; set; }
    }

    public class Company
    {
        [JsonProperty("vendorMappingInUse")]
        public string VendorMappingInUse { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("companyDescription")]
        public string CompanyDescription { get; set; }
    }

    public class Application
    {

        [JsonProperty("modelNumber")]
        public string ModelNumber { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("plumbingApplicationNumber")]
        public string PlumbingApplicationNumber { get; set; }

        [JsonProperty("backFlowDeviceReferenceNumber")]
        public string BackFlowDeviceReferenceNumber { get; set; }

        [JsonProperty("byPassModelNumber")]
        public string ByPassModelNumber { get; set; }

        [JsonProperty("byPassSerialNumber")]
        public string ByPassSerialNumber { get; set; }

        [JsonProperty("byPassPlumbingApplicationNumber")]
        public string ByPassPlumbingApplicationNumber { get; set; }

        [JsonProperty("byPassBackFlowDeviceReferenceNumber")]
        public string ByPassBackFlowDeviceReferenceNumber { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("makeId")]
        public string MakeId { get; set; }

        [JsonProperty("makeDescription")]
        public string MakeDescription { get; set; }

        [JsonProperty("byPassMakeId")]
        public string ByPassMakeId { get; set; }

        [JsonProperty("byPassMakeDescription")]
        public string ByPassMakeDescription { get; set; }

        [JsonProperty("typeId")]
        public string TypeId { get; set; }

        [JsonProperty("typeDescription")]
        public string TypeDescription { get; set; }

        [JsonProperty("protectionId")]
        public string ProtectionId { get; set; }

        [JsonProperty("protectionDescription")]
        public string ProtectionDescription { get; set; }

        [JsonProperty("truckId")]
        public string TruckId { get; set; }

        [JsonProperty("truckDescription")]
        public string TruckDescription { get; set; }
    }

}
