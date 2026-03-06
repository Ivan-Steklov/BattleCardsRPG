using UnityEngine;

namespace Game.Data
{
    [CreateAssetMenu(fileName = "NewCard", menuName = "Game/Card Data")]
    public class CardData : ScriptableObject
    {
        [Header("General Info")]
        public string cardName;
        public Sprite icon; // Картинка
        public Rarity rarity;
        public UnitAttribute attribute;
        
        [Header("Battle Stats")]
        public AttackType attackType;
        public int leadershipCost; // Сколько лидерства тратит герой для вызова
        
        [Header("Base Attributes (Level 1)")]
        public int health;
        public int damage;
        public float attackSpeed = 1.0f; // Или инициатива
        
        [Header("Description")]
        [TextArea] public string description;

        // Метод для расчета статов при слиянии (уровень существа)
        public int GetHealth(int level)
        {
            // Например, +20% за уровень
            return Mathf.FloorToInt(health * Mathf.Pow(1.2f, level - 1));
        }

        public int GetDamage(int level)
        {
            return Mathf.FloorToInt(damage * Mathf.Pow(1.2f, level - 1));
        }
    }
}