using UnityEngine;
namespace BraveHunter.Gameplay 
{
    public class InventoryManager : MonoBehaviour
    {
        public ItemData tempItemSelected;
        public ItemData tempItemSelected2;
        public Slot[] Slots;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {

                AddItemToInventory(tempItemSelected);
            }
            else if (Input.GetKeyDown(KeyCode.J))
            {

                AddItemToInventory(tempItemSelected2);
            }
        }

        void AddItemToInventory(ItemData itemData)
        {

            for (int i = 0; i < Slots.Length; i++)
            {
                if (Slots[i].EnterItem(itemData)) break;
            }
        }
    }
}

