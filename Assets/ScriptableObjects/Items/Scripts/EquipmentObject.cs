using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Default Object", menuName = "Inventory System/Items/Equipment")]
public class EquipmentObject : ItemObject
{
    public float durability;
    public float attackRate;
    public void Awake()
    {
        type = ItemType.Equipment;
    }
}
