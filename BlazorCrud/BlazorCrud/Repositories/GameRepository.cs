using BlazorCrud.Data;
using BlazorCrud.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Repositories
{
    public class GameRepository(DataContext context) : IGameRepository
    {
        private readonly DataContext _context = context;

        public async Task<Game> AddGame(Game game)
        {
            var result = _context.Games.Add(game);
            await _context.SaveChangesAsync();

            return result.Entity; 
        }

        public async Task<List<Game>> GetGames() 
            => await _context.Games.ToListAsync();
    }
}
