using Game.Application.Interfaces;
using Game.Domain.Player;

namespace Game.Application.Services
{
    public class PlayerService
    {
        private readonly IPlayerRepository _repository;

        public PlayerStats Stats { get; private set; }

        public PlayerService(IPlayerRepository repository)
        {
            _repository = repository;
            Stats = _repository.Load();
        }

        public void Save()
        {
            _repository.Save(Stats);
        }
    }
}
