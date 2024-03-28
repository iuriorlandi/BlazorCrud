using BlazorCrud.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Data.Repositories
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

        public async Task<bool> Delete(int id)
        {
            var game = await _context.Games.FindAsync(id);
            _context.Games.Remove(game);
            var result = _context.SaveChanges();

            return result == 1;
        }

        public async Task<Game> GetGameById(int id) 
            => await _context.Games.FindAsync(id);

        public async Task<List<Game>> GetGames() 
            => await _context.Games.ToListAsync();

        public async Task<Game> UpdateGame(Game game)
        {
            var storedGame  = await _context.Games.FindAsync(game.Id);
            storedGame.Update(game);
            await _context.SaveChangesAsync();

            return storedGame;
        }
    }
}
