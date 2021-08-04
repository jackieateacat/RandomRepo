/*
 * SCOPE
 * Additional attributes for ability item scriptable objects
 */

using UnityEngine;


[CreateAssetMenu(fileName = "NewAbilityItem", menuName = "Inventory Item/Ability Item", order = 0)]
public class AbilityItemScriptable : AInventoryScriptable
{
    //TODO: How to implement ability logic?


    private void OnEnable()
    {
        itemType = ItemEnum.AbilityItem;
        ValidateItems();
    }
}
