using Game.Domain.Player;
using TMPro;
using UnityEngine;

namespace Game.Presentation.UI
{
    public class HudView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI healthValue;
        [SerializeField] private TextMeshProUGUI currencyValue;

        public void Bind(PlayerStats stats)
        {
            if (stats == null)
            {
                return;
            }

            healthValue.text = $"HP: {stats.Health}/{stats.MaxHealth}";
            currencyValue.text = $"Gold: {stats.Currency}";
        }
    }
}
