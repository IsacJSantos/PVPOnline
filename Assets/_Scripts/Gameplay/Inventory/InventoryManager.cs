using UnityEngine;
using BraveHunter.Utils;

namespace BraveHunter.Gameplay
{
    public class InventoryManager : MonoBehaviour
    {
        public ItemData tempItemSelected;
        public ItemData tempItemSelected2;
        public Slot[] Slots;

        private void Awake()
        {
            Events.OnItemCollect += AddItemToInventory;
        }

        private void OnDestroy()
        {
            Events.OnItemCollect -= AddItemToInventory;
        }

        #region Private Methods

        void AddItemToInventory(ItemData itemData, GameObject go)
        {
            bool collected = false;
            for (int i = 0; i < Slots.Length; i++)
            {
                if (Slots[i].EnterItem(itemData))
                {
                    go.SetActive(false);
                    go.transform.position = new Vector3(10000, 10000, 10000);
                    collected = true;
                    break;
                }

            }

            if (collected) Events.OnConfirmItemCollect?.Invoke(itemData, go);
            else
                Debug.LogWarning("Inventory is full");
        }
        #endregion

    }
}

