using PAW3.Models.Entities;

namespace PAW3.Models.DTO
{
    public class ProductDTO
    {
        public IEnumerable<Product> Products { get; set; } = [];

        public List<SummaryViewModel> Summaries { get; set; } = [];
    }
}
