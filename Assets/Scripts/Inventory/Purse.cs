using System;
using Newtonsoft.Json.Linq;
using RPG.InventorySystem;
using RPG.SavingSystem;
using UnityEngine;

namespace RPG.InventorySystem {
    public class Purse : MonoBehaviour, IItemStore, IJsonSaveable
    {
        [SerializeField] float startingBalance = 400f;

        float balance = 0;

        public event Action onChange;

        private void Awake() {
            balance = startingBalance;
        }

        public float GetBalance()
        {
            return balance;
        }

        public void UpdateBalance(float amount)
        {
            balance += amount;
            if (onChange != null)
            {
                onChange();
            }
        }

        public int AddItems(InventoryItem item, int number)
        {
            if (item is CurrencyItem)
            {
                UpdateBalance(item.GetPrice() * number);
                return number;
            }
            return 0;
        }

        public JToken CaptureAsJToken()
        {
            return JToken.FromObject(balance);
        }

        public void RestoreFromJToken(JToken state)
        {
            balance = state.ToObject<float>();
        }
    }
}