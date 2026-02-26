using Game.Application.Services;

namespace Game.Application.UseCases
{
    public class AddCurrencyUseCase
    {
        private readonly PlayerService _playerService;

        public AddCurrencyUseCase(PlayerService playerService)
        {
            _playerService = playerService;
        }

        public void Execute(int amount)
        {
            _playerService.Stats.AddCurrency(amount);
            _playerService.Save();
        }
    }
}
