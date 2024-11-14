using System.Threading.Tasks;

namespace VerticalDi.Handlers
{
    public class GetHeroHandler
    {
        public async Task<Hero> GetHeroById(int id)
        {
            // Implementation to get hero by id
            // This is just a placeholder implementation
            await Task.Delay(100); // Simulate async work
            return new Hero { Id = id, Name = "Anti-Mage" };
        }
    }

    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}