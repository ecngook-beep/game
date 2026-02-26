using Game.Application.Interfaces;
using Game.Domain.Player;

namespace Game.Infrastructure.Persistence
{
    public class LocalPlayerRepository : IPlayerRepository
    {
        private const string MaxHealthKey = "player.maxHealth";
        private const string CurrencyKey = "player.currency";
        private const string MoveSpeedKey = "player.moveSpeed";

        private readonly ISaveService _saveService;
        private readonly int _defaultMaxHealth;
        private readonly float _defaultMoveSpeed;

        public LocalPlayerRepository(ISaveService saveService, int defaultMaxHealth, float defaultMoveSpeed)
        {
            _saveService = saveService;
            _defaultMaxHealth = defaultMaxHealth;
            _defaultMoveSpeed = defaultMoveSpeed;
        }

        public PlayerStats Load()
        {
            var maxHealth = _saveService.LoadInt(MaxHealthKey, _defaultMaxHealth);
            var currency = _saveService.LoadInt(CurrencyKey, 0);
            var moveSpeed = _saveService.LoadFloat(MoveSpeedKey, _defaultMoveSpeed);

            return new PlayerStats(maxHealth, currency, moveSpeed);
        }

        public void Save(PlayerStats stats)
        {
            _saveService.SaveInt(MaxHealthKey, stats.MaxHealth);
            _saveService.SaveInt(CurrencyKey, stats.Currency);
            _saveService.SaveFloat(MoveSpeedKey, stats.MoveSpeed);
        }
    }
}
