using System;
using Game.Domain.Core;

namespace Game.Application.Interfaces
{
    public interface IGameStateService
    {
        GameState Current { get; }
        event Action<GameState> StateChanged;
        void Set(GameState state);
    }
}
