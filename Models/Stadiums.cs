namespace Worldcup.Models
{
    public class Stadiums
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Capacity { get; set; }
        public string City { get; set; }
        public string Type { get; set; }
        public DateTime ConstructionDate { get; set; }
        public string Owner { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public List<string> Facilities { get; set; } = new List<string>();
        public string Image { get;set; }
    }
}
