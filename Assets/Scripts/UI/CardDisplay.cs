using UnityEngine;
using UnityEngine.UI;
using TMPro; // Важно для текста
using Game.Data;

namespace Game.UI
{
    public class CardDisplay : MonoBehaviour
    {
        [Header("UI References")]
        public Image iconImage;
        public Image borderImage;
        public TMP_Text nameText;
        public TMP_Text statsText; // Например "ATK: 10 | HP: 100"
        public TMP_Text costText;
        
        [Header("Colors")]
        public Color commonColor = Color.white;
        public Color rareColor = Color.blue;
        public Color epicColor = Color.magenta;
        public Color legendaryColor = Color.yellow;

        private CardData _data;

        // Метод, который заполнит карту данными
        public void Setup(CardData data)
        {
            _data = data;

            // 1. Иконка и текст
            if(data.icon != null) iconImage.sprite = data.icon;
            nameText.text = data.cardName;
            costText.text = data.leadershipCost.ToString();
            
            // 2. Статы (показываем базовые)
            statsText.text = $"{data.damage} / {data.health}";

            // 3. Цвет рамки в зависимости от редкости
            switch (data.rarity)
            {
                case Rarity.Common: borderImage.color = commonColor; break;
                case Rarity.Rare: borderImage.color = rareColor; break;
                case Rarity.Epic: borderImage.color = epicColor; break;
                case Rarity.Legendary: borderImage.color = legendaryColor; break;
            }
        }
    }
}