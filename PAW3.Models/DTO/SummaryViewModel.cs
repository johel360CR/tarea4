using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW3.Models.DTO
{
    public class SummaryViewModel
    {
        public decimal? Id { get; set; }     
        public string Name { get; set; } = string.Empty;
        public decimal? Value { get; set; }   // valor genérico (Price, Rating, UnitPrice, etc.)
        public int Count { get; set; }        
    }
}
