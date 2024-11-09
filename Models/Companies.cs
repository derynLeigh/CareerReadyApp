namespace CareerReadyApp.Models
{
    public class Companies
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? CareersUrl { get; set; }
        public string? Sector { get; set; }
        public bool Hiring { get; set; }
        public required string HireContact { get; set; }
        public bool Applied { get; set; }
        public string? Notes { get; set; }
    }
}