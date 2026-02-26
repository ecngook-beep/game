using Game.Infrastructure.Composition;
using UnityEngine;

namespace Game.Presentation.Bootstrap
{
    public class GameBootstrapper : MonoBehaviour
    {
        [SerializeField] private GameInstaller installer;

        private void Start()
        {
            installer.AddDebugCurrency(installer.StartupCurrencyReward);
        }
    }
}
