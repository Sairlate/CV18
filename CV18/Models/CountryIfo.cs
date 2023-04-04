using System;
using System.Collections.Generic;
using System.Text;

namespace CV18.Models
{
    internal class CountryIfo : PlaceInfo
    {
        public IEnumerable<ProvinceInfo> ProvinceCounts { get; set; }
    }
}
