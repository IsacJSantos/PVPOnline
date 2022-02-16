using UnityEngine.UI;
using UnityEngine;
using TMPro;
using BraveHunter.Utils;
using System.Collections.Generic;

namespace BraveHunter.Gameplay
{
    public class ItemRadarEntry : MonoBehaviour
    {
        public int ItemId { get => _itemData.ItemId; }
        public int ItemCount { get => _itemCount; }


        [SerializeField] Image _itemIcon;
        [SerializeField] TextMeshProUGUI _itemNametext;
        [SerializeField] TextMeshProUGUI _itemCountText;
        [SerializeField] int _itemCount;

        [SerializeField] List<GameObject> _objects = new List<GameObject>();
        ItemData _itemData;

        private void Awake()
        {
            Events.OnConfirmItemCollect += RemoveItem;
        }

        private void OnDestroy()
        {
            Events.OnConfirmItemCollect -= RemoveItem;
        }
        #region Public Methods
        public void SetView(ItemData itemData, GameObject go)
        {
            _itemData = itemData;
            _itemIcon.sprite = _itemData.ItemIcon;
            _itemNametext.text = _itemData.Name;
            _itemCount = 1;
            _objects.Add(go);
            _itemCountText.gameObject.SetActive(false);
        }

        public void IncreaseItemCount(GameObject go)
        {
            _itemCount++;
            _objects.Add(go);
            if (_itemCount > 1)
            {
                _itemCountText.text = $"{_itemCount}x";
                _itemCountText.gameObject.SetActive(true);
            }

        }
        public void DecreaseItemCount(GameObject go)
        {
            _itemCount--;
            _objects.Remove(go);

            if (_itemCount > 1)
                _itemCountText.text = $"{_itemCount}x";
            else
                _itemCountText.gameObject.SetActive(false);

            if (_itemCount <= 0)
                HideItem();

        }

        public void CollectItem()
        {
            Events.OnItemCollect(_itemData, _objects[_objects.Count - 1]);         
        }
        #endregion

        #region Private Methods
        void RemoveItem(ItemData itemData, GameObject go)
        {
            if (itemData.ItemId != _itemData.ItemId) return;

            DecreaseItemCount(go);
        }

        void HideItem() 
        {
            Destroy(gameObject);
        }
        #endregion
    }
}

