using BlazorCrud.Data.Entities;
using BlazorCrud.Data.Repositories;

namespace BlazorCrud.Services
{
    public class GameService(IGameRepository gameRepository) : IGameService
    {
        private readonly IGameRepository _gameRepository = gameRepository;

        public async Task<Game> AddGame(Game game)
        {
            return await _gameRepository.AddGame(game);
        }

        public async Task<bool> Delete(int id)
            => await _gameRepository.Delete(id);
            
        

        public async Task<Game> GetGameById(int id)
            => await _gameRepository.GetGameById(id);

        public async Task<List<Game>> GetGames()
            => await _gameRepository.GetGames();

        public async Task<Game> UpdateGame(Game game)
            => await _gameRepository.UpdateGame(game);
    }
}
