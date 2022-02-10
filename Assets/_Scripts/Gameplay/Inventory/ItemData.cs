using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Create Item", order = 51)]
public class ItemData : ScriptableObject
{
    public string Name;
    public int itemId;
    public Sprite ItemIcon;
}
