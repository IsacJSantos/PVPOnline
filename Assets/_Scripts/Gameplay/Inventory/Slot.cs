using UnityEngine.UI;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public ItemData tempItemSelected;
    [SerializeField] Image _itemImage;

    [SerializeField] ItemData _itemData;

    private void Start()
    {
        _itemImage.enabled = false;    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (tempItemSelected != null) 
            {
                EnterItem(tempItemSelected);
                _itemImage.enabled = true;
            }
            
        }
    }

    public void EnterItem(ItemData itemData)
    {
        _itemData = itemData;
        _itemImage.sprite = itemData.ItemIcon;
    }
}
