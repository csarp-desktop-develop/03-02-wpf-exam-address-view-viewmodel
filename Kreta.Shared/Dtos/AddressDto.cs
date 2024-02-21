using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Shared.Dtos
{
    public class AddressDto
    {
        public int ZipCode { get; set; }
        public string Street { get; set; } = string.Empty;
        public int HouseNumber { get; set; }
    }
}
