using UnityEngine.UI;
using UnityEngine;

public class Slot : MonoBehaviour
{
   
    [SerializeField] Image _itemImage;

    [SerializeField] ItemData _itemData;

    private void Start()
    {
        _itemImage.enabled = false;  
    }

    public bool EnterItem(ItemData itemData)
    {
        if (_itemData == null)
        {
            _itemData = itemData;
            _itemImage.sprite = itemData.ItemIcon;
            _itemImage.enabled = true;
            return true;
        }
        else
        {
            return false;
        }
        
    }
}
