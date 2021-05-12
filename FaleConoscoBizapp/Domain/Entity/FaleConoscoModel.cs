using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FaleConoscoBizapp.Domain
{
    public class FaleConoscoModel
    {

        public string firstname { get; set; }
        public string lastname { get; set; }
        public string telephone1 { get; set; }
        public string mobilephone { get; set; }
        public string emailaddress1 { get; set; }
        public string companyname { get; set; }
        public string subject { get; set; }
    }
}