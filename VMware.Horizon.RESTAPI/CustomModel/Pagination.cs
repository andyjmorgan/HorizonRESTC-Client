using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMware.Horizon.RESTAPI.CustomModel
{
    public class Pagination
    {
        public int page { get; set; }
        /// <summary>
        /// Size is limited to a maximum of 1000
        /// </summary>
        public int size { get; set; }
        public Pagination(int PageNumber, int PageSize)
        {
            if (PageNumber < 0 || PageSize < 0 || PageSize > 1000)
            {
                throw new Exception("Page number and page size cannot be negative, page size has a max limit of 1000");
            }
            page = PageNumber;
            size = PageSize;
        }
        public Pagination()
        {
            page = 1;
            size = 1000;
        }
    }
}
