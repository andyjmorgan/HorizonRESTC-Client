using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.CustomModel;

namespace VMware.Horizon.RESTAPI.CustomHelpers
{
    class PaginationHelpers
    {
        public static bool HasMoreRecords(IDictionary<string,string> Headers)
        {
            string RemainingCount = "";
            return Headers.TryGetValue("HAS_MORE_RECORDS", out RemainingCount);           
        }

        public static Pagination ValidatePagination(Pagination Pagination)
        {
            if(Pagination== null)
            {
                return new Pagination();
            }
            else
            {
                return Pagination;
            }
        }
    }
}
