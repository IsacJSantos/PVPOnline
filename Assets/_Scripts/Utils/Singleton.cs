using UnityEngine;

public class Singleton<T> : MonoBehaviour
{
    public static T Instance { get => _instance; }
    private static T _instance;
    private void Awake()
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
