using BlazorCrud.Data.Entities;

namespace BlazorCrud.Data.Repositories
{
    public interface IGameRepository
    {
        Task<List<Game>> GetGames();
        Task<Game> AddGame(Game game);
    }
}