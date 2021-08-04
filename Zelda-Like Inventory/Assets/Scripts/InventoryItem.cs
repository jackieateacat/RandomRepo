/*
 * SCOPE
 * Controls a single inventory slot
 */

using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    private AInventoryScriptable inventoryItem;
    private Image imageReference;

    private void Awake()
    {
        imageReference = GetComponent<Image>();
    }

    public void SetInventoryItem(AInventoryScriptable item)
    {
        inventoryItem = item;
        UpdateImage();
    }

    private void UpdateImage()
    {
        imageReference.sprite = inventoryItem.itemSprite;
    }

}
