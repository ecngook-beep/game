using UnityEngine;

namespace Game.Presentation.Bootstrap
{
    [CreateAssetMenu(menuName = "Game/Config", fileName = "GameConfig")]
    public class GameConfig : ScriptableObject
    {
        [Header("Player")]
        [Min(1)] public int defaultMaxHealth = 100;
        [Min(0f)] public float defaultMoveSpeed = 6f;

        [Header("Economy")]
        [Min(0)] public int startupCurrencyReward = 25;
    }
}
