using UnityEngine.UI;
using UnityEngine;
using TMPro;
using BraveHunter.Utils;

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

        ItemData _itemData;
        private void Awake()
        {

        }

        private void OnDestroy()
        {

        }

        #region Public Methods
        public void SetView(ItemData itemData)
        {
            _itemData = itemData;
            _itemIcon.sprite = _itemData.ItemIcon;
            _itemNametext.text = _itemData.Name;
            _itemCount = 1;
            _itemCountText.gameObject.SetActive(false);
        }

        public void IncreaseItemCount()
        {
            _itemCount++;
            if (_itemCount > 1)
            {
                _itemCountText.text = $"{_itemCount}x";
                _itemCountText.gameObject.SetActive(true);
            }

        }
        public void DecreaseItemCount()
        {
            _itemCount--;

            if (_itemCount > 1)
                _itemCountText.text = $"{_itemCount}x";
            else if (_itemCount <= 0)
                gameObject.SetActive(false);

        }

        public void CollectItem()
        {
            Events.OnItemCollect(_itemData);

            if (_itemCount > 1)
                _itemCount--;
            else
                gameObject.SetActive(false);

        }
        #endregion

        #region Private Methods

        #endregion
    }
}

