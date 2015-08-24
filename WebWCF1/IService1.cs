﻿using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using WebWCF1.Model;

namespace WebWCF1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,RequestFormat =WebMessageFormat.Json)]
        List<Coffee> sayHello();
    }
}
