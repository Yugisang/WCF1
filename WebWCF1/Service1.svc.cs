using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebWCF1.Model;

namespace WebWCF1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Coffee> sayHello()
        {
            List<Coffee> lc = new List<Coffee>();
            lc.Add(new Coffee { Id = 1, Name = "StartBug", Volume = 5 });
            lc.Add(new Coffee { Id = 2, Name = "CoffMan", Volume = 2 });

            return lc;
        }
    }
}
