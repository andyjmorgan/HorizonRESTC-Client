using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMware.Horizon.RESTAPI.CustomModel
{
    public class Filter
    {
        public class BaseFilter
        {
            public string StringifyFilter()
            {
                return JsonConvert.SerializeObject(this, Formatting.None);
            }
        }
        public enum FilterTypes
        {
            Equals,
            NotEquals,
            Contains,
            StartsWith,
            Between,
            Not,
            And,
            Or
        }
        public class SingleFilter : BaseFilter
        {

            public string type { get; set; }
            public string name { get; set; }
            public object value { get; set; }

            public SingleFilter(FilterTypes FilterType)
            {
                type = FilterType.ToString();
            }

            public SingleFilter(FilterTypes FilterType, String Name, String Value)
            {
                type = FilterType.ToString();
                name = Name;
                value = Value;
            }

        }
        public class RangeFilter : BaseFilter
        {
            public string type { get; set; }
            public string name { get; set; }
            public object fromValue { get; set; }
            public object toValue { get; set; }


            public RangeFilter()
            {
                type = FilterTypes.Between.ToString();
            }
        }
        public class ChainFilter : BaseFilter
        {
            public string type { get; set; }
            public List<object> filters { get; set; }

            public ChainFilter(FilterTypes filterType)
            {
                if (filterType != FilterTypes.And && filterType != FilterTypes.Or)
                {
                    throw new NotSupportedException("Chain Filters only support AND or OR");
                }
                type = filterType.ToString();
                filters = new List<object>();
            }
        }
        public class NotFilter : BaseFilter
        {
            public string type { get; set; }
            public object filter { get; set; }
            public NotFilter()
            {
                type = FilterTypes.Not.ToString();
            }
        }
    }
}
