using BlazorCrud.Data.Entities;

namespace BlazorCrud.Services
{
    public interface IGameService
    {
        Task<Game> AddGame(Game game);
        Task<bool> Delete(int id);
        Task<Game> GetGameById(int id);
        Task<List<Game>> GetGames();
        Task<Game> UpdateGame(Game game);
    }
}
