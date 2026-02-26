using Game.Application.Interfaces;
using Game.Domain.Core;

namespace Game.Application.UseCases
{
    public class StartGameUseCase
    {
        private readonly IGameStateService _gameStateService;

        public StartGameUseCase(IGameStateService gameStateService)
        {
            _gameStateService = gameStateService;
        }

        public void Execute()
        {
            _gameStateService.Set(GameState.Playing);
        }
    }
}
