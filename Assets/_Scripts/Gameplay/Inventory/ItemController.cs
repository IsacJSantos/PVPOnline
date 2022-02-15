using BraveHunter.Utils;
using UnityEngine;

namespace BraveHunter.Gameplay
{

    public class ItemController : MonoBehaviour
    {
        Collider _itemCollectArea;
        public ItemData ItemData;

        private void Awake()
        {
            _itemCollectArea = GetComponent<Collider>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Events.OnItemView?.Invoke(ItemData, gameObject);
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Events.OnItemOutOfView?.Invoke(ItemData, gameObject);
            }

        }
    }
}

