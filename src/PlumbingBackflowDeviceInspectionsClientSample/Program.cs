using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace PlumbingBackflowDeviceInspectionsClientSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Update the variables as provided
            var tenantId = "{Enter provided}";
            var resource = "{Enter provided}";
            var clientId = "{Enter provided}";
            var clientSecret = "{Enter provided}";
            var apiUrl = "{Enter provided}";

            // Get the token
            var authHttpClient = new HttpClient();
            var authResponse = authHttpClient.PostAsync("https://login.microsoftonline.com/" + tenantId + "/oauth2/token",
                new FormUrlEncodedContent(new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("resource", resource),
                    new KeyValuePair<string, string>("client_id", clientId),
                    new KeyValuePair<string, string>("client_secret", clientSecret),
                    new KeyValuePair<string, string>("grant_type", "client_credentials")
                })).GetAwaiter().GetResult();
            authResponse.EnsureSuccessStatusCode();
            var authContent = authResponse.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            dynamic contentJson = JsonConvert.DeserializeObject(authContent);
            string accessToken = contentJson.access_token.ToString();

            // Post an Inspection
            var hc = new HttpClient();
            hc.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var inspection = new Inspection
            {
                Application = new Application
                {
                    ModelNumber = "string",
                    SerialNumber = "string",
                    PlumbingApplicationNumber = "string",
                    BackFlowDeviceReferenceNumber = "string",
                    ByPassModelNumber = "string",
                    ByPassSerialNumber = "string",
                    ByPassPlumbingApplicationNumber = "string",
                    ByPassBackFlowDeviceReferenceNumber = "string",
                    Address = "string",
                    City = "string",
                    State = "string",
                    Postcode = "string",
                    Location = "string",
                    MakeId = "string",
                    MakeDescription = "string",
                    ByPassMakeId = "string",
                    ByPassMakeDescription = "string",
                    TypeId = "string",
                    TypeDescription = "string",
                    ProtectionId = "string",
                    ProtectionDescription = "string",
                    TruckId = "string",
                    TruckDescription = "string",
                },
                Company = new Company
                {
                    VendorMappingInUse = "string",
                    CompanyId = "string",
                    CompanyDescription = "string",
                },
                Appendix = "string",
                TestComment = "string",
                TestDateTime = new DateTime(2018, 10, 10, 8, 0, 0),
                TestKitLastVerified = new DateTime(2018, 10, 10, 8, 0, 0),
                TestResult = "string",
                TesterFirstName = "string",
                TesterLastName = "string",
                TesterLicenceNo = "string",
                PdfDocumentInBase64 = null,
                PdfDocument2InBase64 = null,
                SerialNumberPhotoInBase64 = null,
                DevicePhotoInBase64 = null,
                LocationPhotoInBase64 = null
            };
            var body = JsonConvert.SerializeObject(inspection);
            var response = hc.PostAsync(apiUrl, new StringContent(body, Encoding.UTF8, "application/json")).GetAwaiter().GetResult();
            var statusCode = response.StatusCode.ToString();
            Console.WriteLine("Status Code: " + statusCode);
            var responseContent = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            Console.WriteLine(responseContent);
            Console.ReadKey();
        }
    }
}
