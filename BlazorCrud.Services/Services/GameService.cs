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

        public async Task<List<Game>> GetGames()
            => await _gameRepository.GetGames();
    }
}
