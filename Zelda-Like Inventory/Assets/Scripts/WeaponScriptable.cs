/*
 * SCOPE
 * Additional attributes for weapon scriptable objects
 */

using UnityEngine;


[CreateAssetMenu(fileName = "NewWeapon", menuName = "Inventory Item/Weapon", order = 0)]
public class WeaponScriptable : AInventoryScriptable
{
    [Tooltip("How much base damage this weapon does")]
    [Range(0, 9999)]
    public float baseAttack;


    private void OnEnable()
    {
        itemType = ItemEnum.Weapon;
        ValidateItems();
    }
}
