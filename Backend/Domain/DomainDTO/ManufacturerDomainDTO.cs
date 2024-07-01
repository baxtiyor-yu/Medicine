using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainDTO
{
    public class ManufacturerDomainDTO
    {
        public int ManufacturerId { get; set; }
        public string? ManufacturerName { get; set; }
        public string? ManufacturerAddress { get; set;}
        public CountryDomainDTO ManufacturerCountry { get; set; } = null!;
    }
}
