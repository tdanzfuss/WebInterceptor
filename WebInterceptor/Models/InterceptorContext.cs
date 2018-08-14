using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebInterceptor.Models
{
    public class InterceptorContext
    {
        public bool staff;
        public string authenticationToken;
        public string dataType;
        public string audience;
        public string segment;
        public string partyId;
        public object dataModel;
    }
}