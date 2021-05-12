using AutoMapper;
using FaleConoscoBizapp.Domain;
using FaleConoscoBizapp.Models.Interfaces;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System.Configuration;

namespace FaleConoscoBizapp.Services
{
    public class FaleConoscoServices : IFaleConoscoRepository
    {
        private CrmServiceClient client = new CrmServiceClient(ConfigurationManager.ConnectionStrings["BizAppConnection"].ConnectionString);

        public void Insert(FaleConoscoModel model)
        {

            using (CrmServiceClient service = client)
            {
                if (service != null && service.IsReady)
                {
                    Entity entity = new Entity("lead");
                    entity["firstname"] = model.firstname;
                    entity["lastname"] = model.lastname;
                    entity["telephone1"] = model.telephone1;
                    entity["mobilephone"] = model.mobilephone;
                    entity["emailaddress1"] = model.emailaddress1;
                    entity["companyname"] = model.companyname;
                    entity["subject"] = model.subject;
                    service.Create(entity);

                }

            }
        }
    }
}