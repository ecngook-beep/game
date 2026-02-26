using System.Collections.Generic;
using Game.Application.Interfaces;
using Game.Application.Services;
using Game.Application.UseCases;
using Game.Infrastructure.Persistence;
using Game.Infrastructure.UnityAdapters;
using Game.Presentation.Bootstrap;
using Game.Presentation.UI;
using UnityEngine;

namespace Game.Infrastructure.Composition
{
    public class GameInstaller : MonoBehaviour
    {
        [SerializeField] private CharacterControllerMover playerMover;
        [SerializeField] private HudView hudView;
        [SerializeField] private GameConfig config;

        private readonly List<ITickable> _tickables = new();

        private GameStateService _gameStateService;
        private PlayerService _playerService;
        private AddCurrencyUseCase _addCurrencyUseCase;

        private void Awake()
        {
            Compose();
        }

        private void Update()
        {
            var deltaTime = Time.deltaTime;
            for (var i = 0; i < _tickables.Count; i++)
            {
                _tickables[i].Tick(deltaTime);
            }

            hudView.Bind(_playerService.Stats);
        }

        public void AddDebugCurrency(int value)
        {
            _addCurrencyUseCase.Execute(value);
        }

        public int StartupCurrencyReward => config != null ? config.startupCurrencyReward : 25;

        private void Compose()
        {
            var maxHealth = config != null ? config.defaultMaxHealth : 100;
            var moveSpeed = config != null ? config.defaultMoveSpeed : 6f;

            ISaveService saveService = new PlayerPrefsSaveService();
            IPlayerRepository playerRepository = new LocalPlayerRepository(saveService, maxHealth, moveSpeed);
            IInputService inputService = new UnityInputService();

            _gameStateService = new GameStateService();
            _playerService = new PlayerService(playerRepository);
            _addCurrencyUseCase = new AddCurrencyUseCase(_playerService);

            var movePlayerUseCase = new MovePlayerUseCase(inputService, playerMover, _playerService);
            var startGameUseCase = new StartGameUseCase(_gameStateService);

            _tickables.Add(movePlayerUseCase);
            startGameUseCase.Execute();
        }
    }
}
