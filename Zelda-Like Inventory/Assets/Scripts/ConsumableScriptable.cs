/*
 * SCOPE
 * Additional attributes for consumable scriptable items
 */

using UnityEngine;

[CreateAssetMenu(fileName = "NewConsumable", menuName = "Inventory Item/Consumable", order = 0)]
public class ConsumableScriptable : AInventoryScriptable
{
    [Tooltip("Which variable does this modify/buff?")]
    public ADataScriptable variableToModify;

    [Tooltip("Is this effect permenent (healing) or a temporary buff?")]
    public bool permanentBuff;

    [Tooltip("How long does the temporary buff last. Does not apply to permenant effects")]
    [Range(0,999)]
    public float tempBuffDuration;

    [Tooltip("The consumable is applied proportionally over this time period")]
    [Range(0, 99)]
    public float applicationTime;

    [Tooltip("Can this buff exceed the variable maximum value?")]
    public bool exceedMax;


    private void OnEnable()
    {
        itemType = ItemEnum.Consumable;
        ValidateItems();
    }
}
