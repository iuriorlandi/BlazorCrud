namespace BlazorCrud.Data.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public void Update(Game game)
        {
            Name = game.Name;
        }
    }
}
