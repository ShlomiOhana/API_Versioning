using Web_API_Versioning.Models;

namespace Web_API_Versioning
{
    public class CountriesData
    {
        public static List<CountryModel> Get()
        {
            var countries = new[]
            {
                new { Id = 1, Name = "United States"},
                new { Id = 2, Name = "Germany"},
                new { Id = 3, Name = "Brazil"},
                new { Id = 4, Name = "China"},
                new { Id = 5, Name = "Italy"},
                new { Id = 6, Name = "Israel"},
                new { Id = 7, Name = "Mexico"},
                new { Id = 8, Name = "Japan"},
                new { Id = 9, Name = "Russia"},
                new { Id = 10, Name = "Australia"}
            };

            return countries.Select(x => new CountryModel { Id = x.Id, Name = x.Name, }).ToList();
        }
    }
}
