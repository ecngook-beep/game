using System;
using Game.Application.Interfaces;
using Game.Domain.Core;

namespace Game.Application.Services
{
    public class GameStateService : IGameStateService
    {
        public GameState Current { get; private set; } = GameState.Boot;
        public event Action<GameState> StateChanged;

        public void Set(GameState state)
        {
            if (state == Current)
            {
                return;
            }

            Current = state;
            StateChanged?.Invoke(Current);
        }
    }
}
