using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInventoryAdd : MonoBehaviour
{
    public List<AInventoryScriptable> inventoryItems = new List<AInventoryScriptable>();
    public Inventory invRef;

    private void Start()
    {
        foreach (AInventoryScriptable item in inventoryItems)
        {
            invRef.AddItem(item);
        }
    }
}
