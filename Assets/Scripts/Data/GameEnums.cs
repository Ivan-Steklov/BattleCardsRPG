namespace Game.Data
{
    // Атрибуты (Сила, Ловкость, Интеллект)
    public enum UnitAttribute
    {
        Strength,   // Красные (Танки)
        Agility,    // Зеленые (ДД)
        Intelligence // Синие (Маги)
    }

    // Тип атаки
    public enum AttackType
    {
        Melee,  // Бьет только переднего
        Ranged, // Бьет любого
        Magic   // Бьет любого или лечит
    }

    // Редкость (для цвета рамки и гачи)
    public enum Rarity
    {
        Common,
        Rare,
        Epic,
        Legendary
    }
}