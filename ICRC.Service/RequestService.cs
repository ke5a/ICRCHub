using ICRC.Data.Infrastructures;
using ICRC.Domain.Entities;
using ICRC.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICRC.Service
{
   public class RequestService : Service <Request>, IRequestService
    {
        private static DataBaseFactory dbf = new DataBaseFactory();
        private static UnitOfWork utw = new UnitOfWork(dbf);

        public RequestService(): base(utw)
        {

        }
    }
}
