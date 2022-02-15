using UnityEngine;
using System.Collections.Generic;
using BraveHunter.Utils;

namespace BraveHunter.Gameplay
{
    public class ItemRadarManager : MonoBehaviour
    {
        [SerializeField] GameObject _itemEntryPrefab;
        [SerializeField] Transform _itemsContainer;

        List<ItemRadarEntry> _radarEntries = new List<ItemRadarEntry>();
        private void Awake()
        {
            Events.OnItemView += OnItemView;
            Events.OnItemOutOfView += OnItemOutOfView;
            Events.OnItemCollect += OnItemCollect;
        }
        private void OnDestroy()
        {
            Events.OnItemView -= OnItemView;
            Events.OnItemOutOfView -= OnItemOutOfView;
            Events.OnItemCollect -= OnItemCollect;
        }

        #region Public Methods

        #endregion

        #region Private Methods
        void OnItemView(ItemData itemData)
        {
            if (_radarEntries.Count >= 1)
            {
                ItemRadarEntry itemRadarEntry = _radarEntries.Find(x => x.ItemId == itemData.ItemId);
                if (itemRadarEntry != null)
                {
                    itemRadarEntry.IncreaseItemCount();
                }
                else
                    CreateNewItemEntry(itemData);
            }
            else
                CreateNewItemEntry(itemData);
        }
        void OnItemOutOfView(ItemData itemData)
        {
            if (_radarEntries.Count >= 1)
            {
                ItemRadarEntry itemRadarEntry = _radarEntries.Find(x => x.ItemId == itemData.ItemId);
                if (itemRadarEntry == null) return;

                if (itemRadarEntry.ItemCount <= 1)
                {
                    _radarEntries.Remove(itemRadarEntry);
                }

                itemRadarEntry.DecreaseItemCount();

            }

        }

        void OnItemCollect(ItemData itemData)
        {

        }

        void CreateNewItemEntry(ItemData itemData)
        {
            GameObject obj = Instantiate(_itemEntryPrefab);
            ItemRadarEntry entry = obj.GetComponent<ItemRadarEntry>();

            entry.SetView(itemData);
            obj.transform.SetParent(_itemsContainer);
            _radarEntries.Add(entry);
        }
        #endregion

    }
}