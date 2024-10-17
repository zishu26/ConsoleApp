using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using static System.Net.WebRequestMethods;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            string connectionString = @"AuthType=OAuth;

                                        Username=MdZishanAnsari@Optum075.onmicrosoft.com;

                                        Password=ZadeHyderabad@026;

                                        Url=https://org3f8c7334.crm8.dynamics.com;

                                        AppId=51f81489-12ee-4a9e-aaae-a2591f45987d;

                                        RedirectUri=app://58145B91-0C36-4500-8554-080854F2AC97";

            CrmServiceClient crmServiceClient = new CrmServiceClient(connectionString);

            if (crmServiceClient.IsReady)
            {

                string query = "<fetch version='1.0' output-format='xml-platform' mapping='logical' savedqueryid='00000000-0000-0000-00aa-000010001003' no-lock='false' distinct='true'>\r\n\t<entity name='contact'>\r\n\t\t<attribute name='fullname'/>\r\n\t\t<attribute name='parentcustomerid'/>\r\n\t\t<attribute name='telephone1'/>\r\n\t\t<attribute name='emailaddress1'/>\r\n\t\t<attribute name='contactid'/>\r\n\t\t<order attribute='fullname' descending='false'/>\r\n\t\t<filter type='and'>\r\n\t\t\t<condition attribute='statecode' operator='eq' value='0'/>\r\n\t\t\t<condition attribute='address1_city' operator='eq' value='Redmond'/>\r\n\t\t</filter>\r\n\t</entity>\r\n</fetch>";
                try
                {
                    //********************************************************************************************************************************

                    //    Entity contact = new Entity("contact");
                    //    contact.Attributes.Add("lastname", "Console App");
                    //    contact.Attributes.Add("mobilephone", "1234567890");
                    //    Guid guid = crmServiceClient.Create(contact);
                    //    Console.WriteLine(guid);

                    //*********************************************************************************************************************************

                    //EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(new FetchExpression(query));
                    //foreach (Entity contact in entityCollection.Entities)
                    //{
                    //    Console.WriteLine(contact.Attributes["fullname"].ToString());
                    //}

                    //***********************************************************************************************************************************

                    //using (OrganizationServiceContext context = new OrganizationServiceContext(crmServiceClient))
                    //{
                    //    var records = from contact in context.CreateQuery("contact")
                    //                  select contact;
                    //    foreach (var record in records)
                    //    {
                    //        {
                    //                Console.WriteLine(record.Attributes["fullname"].ToString());
                    //        }
                    //    }
                    //}

                    //*******************************************************************************************************************************************

                    //Entity newContact = new Entity("contact");
                    //newContact.Attributes.Add("lastname", "Deba2");
                    //newContact.Attributes.Add("mobilephone", "8900396137");

                    //CreateRequest createRequest = new CreateRequest();
                    //createRequest.Target = newContact;

                    //CreateResponse createResponse = (CreateResponse)crmServiceClient.Execute(createRequest);
                    //Console.WriteLine("Generated Id : " + createResponse.id);

                    //*********************************************************************************************************************************************

                    //ExecuteMultipleRequest executeMultipleRequest = new ExecuteMultipleRequest();
                    //executeMultipleRequest.Requests = new OrganizationRequestCollection();

                    //Entity newContact1 = new Entity("contact");
                    //newContact1.Attributes.Add("lastname", "Khadija1");
                    //newContact1.Attributes.Add("mobilephone", "8900396137");

                    //CreateRequest createRequest1 = new CreateRequest();
                    //createRequest1.Target = newContact1;

                    //Entity newContact2 = new Entity("contact");
                    //newContact2.Attributes.Add("lastname", "Khadija2");
                    //newContact2.Attributes.Add("mobilephone", "8900396137");

                    //CreateRequest createRequest2 = new CreateRequest();
                    //createRequest2.Target = newContact2;

                    //executeMultipleRequest.Requests.Add(createRequest1);
                    //executeMultipleRequest.Requests.Add(createRequest2);
                    //executeMultipleRequest.Settings = new ExecuteMultipleSettings()
                    //{
                    //    ContinueOnError = true,
                    //    ReturnResponses = true
                    //};

                    //ExecuteMultipleResponse multipleResponse = (ExecuteMultipleResponse)crmServiceClient.Execute(executeMultipleRequest);

                    //************************************************************************************************************************************************

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occured : " + ex.Message);
                }


            }
            else
            {
                Console.WriteLine("Failed to connect to CRM" + crmServiceClient.LastCrmError);
            }

            Console.Read();
        }
    }
}
