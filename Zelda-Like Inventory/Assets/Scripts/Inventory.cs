/*
 * SCOPE
 * Maintains a list of inventory items and slots
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    [Header("Inventory Slots")]

    [SerializeField]
    private List<InventoryItem> weaponSlot = new List<InventoryItem>();

    [SerializeField]
    private List<InventoryItem> armorSlot = new List<InventoryItem>();

    [SerializeField]
    private List<InventoryItem> consumableSlot = new List<InventoryItem>();

    [SerializeField]
    private List<InventoryItem> powerUpShardSlot = new List<InventoryItem>();

    [SerializeField]
    private List<InventoryItem> abilityItemSlot = new List<InventoryItem>();

    [SerializeField]
    private List<InventoryItem> keyItemSlot = new List<InventoryItem>();


    [Header("Inventory Items")]

    [SerializeField]
    private List<WeaponScriptable> activeWeaponList = new List<WeaponScriptable>();

    [SerializeField]
    private List<ArmorScriptable> activeArmorList = new List<ArmorScriptable>();

    [SerializeField]
    private List<ConsumableScriptable> activeConsumableList = new List<ConsumableScriptable>();

    [SerializeField]
    private List<PowerUpShardScriptable> activePowerUpShardList = new List<PowerUpShardScriptable>();

    [SerializeField]
    private List<AbilityItemScriptable> activeAbilityItemList = new List<AbilityItemScriptable>();

    [SerializeField]
    private List<KeyItemScriptable> activeKeyItemList = new List<KeyItemScriptable>();


    private void Start()
    {
        UpdateInventorySlots();
    }


    public void AddItem(AInventoryScriptable item)
    {
        //Check item type. Add to inventory if free slots available
        switch (item.itemType)
        {
            case ItemEnum.Armor:
                if(activeArmorList.Count < armorSlot.Count)
                {
                    activeArmorList.Add(item as ArmorScriptable);
                    UpdateInventorySlots();
                }
                else
                {
                    //TODO: How to handle cases where no open inventory slots available
                    Debug.Log("Inventory full. Cannot add item: " + item.itemName);
                }
                break;

            case ItemEnum.Weapon:
                if (activeWeaponList.Count < weaponSlot.Count)
                {
                    activeWeaponList.Add(item as WeaponScriptable);
                    UpdateInventorySlots();
                }
                else
                {
                    //TODO: How to handle cases where no open inventory slots available
                    Debug.Log("Inventory full. Cannot add item: " + item.itemName);
                }
                break;

            case ItemEnum.Consumable:
                if (activeConsumableList.Count < consumableSlot.Count)
                {
                    activeConsumableList.Add(item as ConsumableScriptable);
                    UpdateInventorySlots();
                }
                else
                {
                    //TODO: How to handle cases where no open inventory slots available
                    Debug.Log("Inventory full. Cannot add item: " + item.itemName);
                }
                break;

            case ItemEnum.PowerupShard:
                if (activePowerUpShardList.Count < powerUpShardSlot.Count)
                {
                    activePowerUpShardList.Add(item as PowerUpShardScriptable);
                    UpdateInventorySlots();
                }
                else
                {
                    //TODO: How to handle cases where no open inventory slots available
                    Debug.Log("Inventory full. Cannot add item: " + item.itemName);
                }
                break;

            case ItemEnum.AbilityItem:
                if (activeAbilityItemList.Count < abilityItemSlot.Count)
                {
                    activeAbilityItemList.Add(item as AbilityItemScriptable);
                    UpdateInventorySlots();
                }
                else
                {
                    //TODO: How to handle cases where no open inventory slots available
                    Debug.Log("Inventory full. Cannot add item: " + item.itemName);
                }
                break;

            case ItemEnum.KeyItem:
                if (activeKeyItemList.Count < keyItemSlot.Count)
                {
                    activeKeyItemList.Add(item as KeyItemScriptable);
                    UpdateInventorySlots();
                }
                else
                {
                    //TODO: How to handle cases where no open inventory slots available
                    Debug.Log("Inventory full. Cannot add item: " + item.itemName);
                }
                break;
        }
    }

    private void UpdateInventorySlots()
    {
        //Add items to item slots
        for(int i = 0; i < activeWeaponList.Count; i++)
        {
            weaponSlot[i].SetInventoryItem(activeWeaponList[i]);
        }

        for (int i = 0; i < activeArmorList.Count; i++)
        {
            armorSlot[i].SetInventoryItem(activeArmorList[i]);
        }

        for (int i = 0; i < activeConsumableList.Count; i++)
        {
            consumableSlot[i].SetInventoryItem(activeConsumableList[i]);
        }

        for (int i = 0; i < activePowerUpShardList.Count; i++)
        {
            powerUpShardSlot[i].SetInventoryItem(activePowerUpShardList[i]);
        }

        for (int i = 0; i < activeAbilityItemList.Count; i++)
        {
            abilityItemSlot[i].SetInventoryItem(activeAbilityItemList[i]);
        }

        for (int i = 0; i < activeKeyItemList.Count; i++)
        {
            keyItemSlot[i].SetInventoryItem(activeKeyItemList[i]);
        }
    }
}
