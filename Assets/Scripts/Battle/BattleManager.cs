using UnityEngine;
using System.Collections.Generic;
using Game.Data;

namespace Game.Battle
{
    public class BattleManager : MonoBehaviour
    {
        [Header("Managers")]
        public HandManager handManager;

        [Header("Debug Deck")]
        public List<CardData> testDeck; // Сюда перетащишь свои ScriptableObjects (Рыцаря, Мага...)

        private void Start()
        {
            StartBattle();
        }

        public void StartBattle()
        {
            Debug.Log("Battle Started!");
            
            // Тестовая выдача карт: просто вываливаем всю тестовую колоду в руку
            foreach (var cardData in testDeck)
            {
                handManager.AddCardToHand(cardData);
            }
        }
    }
}