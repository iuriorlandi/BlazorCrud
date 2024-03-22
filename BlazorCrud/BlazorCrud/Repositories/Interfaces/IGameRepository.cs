using BlazorCrud.Entities;

namespace BlazorCrud.Repositories
{
    public interface IGameRepository
    {
        Task<List<Game>> GetGames();
        Task<Game> AddGame(Game game);
    }
}