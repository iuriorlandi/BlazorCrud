using BlazorCrud.Data.Entities;

namespace BlazorCrud.Data.Repositories
{
    public interface IGameRepository
    {
        Task<List<Game>> GetGames();
        Task<Game> AddGame(Game game);
        Task<Game> GetGameById(int id);
        Task<Game> UpdateGame(Game game);
        Task<bool> Delete(int id);
    }
}