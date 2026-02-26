using UnityEngine;

namespace Game.Domain.Player
{
    public class PlayerStats
    {
        public int Health { get; private set; }
        public int MaxHealth { get; private set; }
        public int Currency { get; private set; }
        public float MoveSpeed { get; private set; }

        public PlayerStats(int maxHealth, int startCurrency, float moveSpeed)
        {
            MaxHealth = Mathf.Max(1, maxHealth);
            Health = MaxHealth;
            Currency = Mathf.Max(0, startCurrency);
            MoveSpeed = Mathf.Max(0.1f, moveSpeed);
        }

        public void AddCurrency(int amount)
        {
            Currency = Mathf.Max(0, Currency + amount);
        }

        public void RemoveHealth(int amount)
        {
            Health = Mathf.Max(0, Health - Mathf.Max(0, amount));
        }

        public void RestoreFullHealth()
        {
            Health = MaxHealth;
        }
    }
}
