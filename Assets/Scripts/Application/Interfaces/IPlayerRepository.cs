using Game.Domain.Player;

namespace Game.Application.Interfaces
{
    public interface IPlayerRepository
    {
        PlayerStats Load();
        void Save(PlayerStats stats);
    }
}
