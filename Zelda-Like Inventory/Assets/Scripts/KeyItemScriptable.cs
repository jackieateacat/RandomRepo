/*
 * SCOPE
 * Additional attributes for key items
 */

using UnityEngine;

[CreateAssetMenu(fileName = "KeyItem", menuName = "Inventory Item/Key Item", order = 0)]
public class KeyItemScriptable : AInventoryScriptable
{
    //TODO: How is key item logic handled?
    
    private void OnEnable()
    {
        itemType = ItemEnum.KeyItem;
        ValidateItems();
    }
}
