using UnityEngine;
using System.Collections.Generic;
using Game.Data;
using Game.UI;

namespace Game.Battle
{
    public class HandManager : MonoBehaviour
    {
        [Header("Settings")]
        public GameObject cardPrefab; // Ссылка на твой префаб карты
        public Transform handContainer; // Ссылка на HandArea

        // Список созданных объектов карт (чтобы мы могли к ним обращаться)
        private List<GameObject> _spawnedCards = new List<GameObject>();

        // Метод: "Создай карту визуально"
        public void AddCardToHand(CardData data)
        {
            // 1. Создаем копию префаба внутри handContainer
            GameObject newCardObj = Instantiate(cardPrefab, handContainer);
            
            // 2. Получаем доступ к скрипту CardDisplay и заполняем данные
            CardDisplay display = newCardObj.GetComponent<CardDisplay>();
            if (display != null)
            {
                display.Setup(data);
            }

            // 3. Сохраняем в список
            _spawnedCards.Add(newCardObj);
        }

        // Метод для очистки руки (на всякий случай)
        public void ClearHand()
        {
            foreach (var card in _spawnedCards)
            {
                Destroy(card);
            }
            _spawnedCards.Clear();
        }
    }
}