using UnityEngine;
using System.Collections.Generic;
using BraveHunter.Utils;
using UnityEngine.InputSystem;

namespace BraveHunter.Gameplay
{
    public class ItemRadarManager : MonoBehaviour
    {
        [SerializeField] GameObject _itemEntryPrefab;
        [SerializeField] Transform _itemsContainer;

        [SerializeField] List<ItemRadarEntry> _radarEntries = new List<ItemRadarEntry>();

        MyPlayerInput inputActions;
        private void Awake()
        {
            inputActions = new MyPlayerInput();

            Events.OnItemView += OnItemView;
            Events.OnItemOutOfView += OnItemOutOfView;
            Events.OnConfirmItemCollect += RemoveCollectedItem;

            inputActions.HUDController.CollectItem.started += CollectItem;
        }

        private void OnEnable()
        {
            inputActions.HUDController.Enable();
        }

        private void OnDisable()
        {
            inputActions.HUDController.Disable();
        }
        private void OnDestroy()
        {
            Events.OnItemView -= OnItemView;
            Events.OnItemOutOfView -= OnItemOutOfView;
            Events.OnConfirmItemCollect -= RemoveCollectedItem;
        }

        #region Public Methods

        #endregion

        #region Private Methods

        void CollectItem(InputAction.CallbackContext context)
        {
            if (_radarEntries != null && _radarEntries.Count > 0)
                _radarEntries[0].CollectItem();
        }

        void OnItemView(ItemData itemData, GameObject go)
        {
            if (_radarEntries.Count >= 1)
            {
                ItemRadarEntry itemRadarEntry = _radarEntries.Find(x => x.ItemId == itemData.ItemId);
                if (itemRadarEntry != null)
                {
                    itemRadarEntry.IncreaseItemCount(go);
                }
                else
                    CreateNewItemEntry(itemData, go);
            }
            else
                CreateNewItemEntry(itemData, go);
        }
        void OnItemOutOfView(ItemData itemData, GameObject go)
        {
            if (_radarEntries.Count >= 1)
            {
                ItemRadarEntry itemRadarEntry = _radarEntries.Find(x => x.ItemId == itemData.ItemId);
                if (itemRadarEntry == null) return;

                if (itemRadarEntry.ItemCount <= 1) _radarEntries.Remove(itemRadarEntry);


                itemRadarEntry.DecreaseItemCount(go);

            }

        }

        void RemoveCollectedItem(ItemData itemData, GameObject go)
        {
            ItemRadarEntry itemRadarEntry = _radarEntries.Find(x => x.ItemId == itemData.ItemId);
            if (itemRadarEntry == null) return;


            if (itemRadarEntry.ItemCount <= 1)
                _radarEntries.Remove(itemRadarEntry);


        }

        void CreateNewItemEntry(ItemData itemData, GameObject go)
        {
            GameObject obj = Instantiate(_itemEntryPrefab);
            ItemRadarEntry entry = obj.GetComponent<ItemRadarEntry>();

            entry.SetView(itemData, go);
            obj.transform.SetParent(_itemsContainer);
            _radarEntries.Add(entry);
        }
        #endregion

    }
}