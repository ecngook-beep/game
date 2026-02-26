using Game.Application.Interfaces;
using Game.Application.Services;

namespace Game.Application.UseCases
{
    public class MovePlayerUseCase : ITickable
    {
        private readonly IInputService _inputService;
        private readonly IPlayerMover _playerMover;
        private readonly PlayerService _playerService;

        public MovePlayerUseCase(IInputService inputService, IPlayerMover playerMover, PlayerService playerService)
        {
            _inputService = inputService;
            _playerMover = playerMover;
            _playerService = playerService;
        }

        public void Tick(float deltaTime)
        {
            var moveInput = _inputService.GetMoveInput();
            _playerMover.Move(moveInput, _playerService.Stats.MoveSpeed, deltaTime);
        }
    }
}
