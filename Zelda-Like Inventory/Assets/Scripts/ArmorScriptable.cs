/*
 * SCOPE
 * Additional attributes for armor scriptable items
 */
 
using UnityEngine;

[CreateAssetMenu(fileName = "NewArmor", menuName = "Inventory Item/Armor", order = 0)]
public class ArmorScriptable : AInventoryScriptable
{
    [Tooltip("How much base armor is provided")]
    [Range(0, 99999)]
    public float baseArmor;


    private void OnEnable()
    {
        itemType = ItemEnum.Armor;
        ValidateItems();
    }
}
