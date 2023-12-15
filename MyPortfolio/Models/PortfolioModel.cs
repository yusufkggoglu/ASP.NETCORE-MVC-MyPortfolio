namespace MyPortfolio.Models
{
    public class PortfolioModel
    {
        public int PortfolioID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }

        public bool Status { get; set; }
    }
}
