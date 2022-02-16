using BraveHunter.Utils;
using System;
using System.Collections;
using UnityEngine;
using UnityEditor;

namespace BraveHunter.Gameplay
{
    public class SpawnPointController : MonoBehaviour
    {
        [SerializeField] string _path;
        [SerializeField] ItemSpawn[] _items;

        private void Start()
        {
            StartCoroutine(_SpawnItem());
        }

        #region Public Methods

        #endregion

        #region Private Methods
        IEnumerator _SpawnItem()
        {
            print("_SpawnItem()");
            foreach (var item in _items)
            {
                float value = UnityEngine.Random.Range(0, 101);
                bool isInRange = value >= item.Chance.Min && value <= item.Chance.Max;
                if (isInRange)
                {
                    print($"_SpawnItem() Spawning: {item.ItemType}. Value: {value}");
                    Instantiate(Resources.Load<GameObject>($"{_path}/{item.ItemType}"), transform.position, Quaternion.identity);
                    break;
                }
                yield return null;
            }
        }
        #endregion

    }

    [System.Serializable]
    public class ItemSpawn
    {
        public ItemType ItemType;
        public Chance Chance;

    }

    [System.Serializable]
    public class Chance
    {
        public float Min;
        public float Max;

    }

}

