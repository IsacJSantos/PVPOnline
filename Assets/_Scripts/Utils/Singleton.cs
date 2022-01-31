using UnityEngine;

namespace OnlyOneGameDev.Utils
{
    public class Singleton<T> : MonoBehaviour
    {
        [SerializeField] public static T Instance { get => _instance; }
        private static T _instance;
        protected virtual void Awake()
        {
            if (_instance == null)
            {
                _instance = this.GetComponent<T>();
            }
            else
            {
                Destroy(gameObject);
            }

        }
    }
}

