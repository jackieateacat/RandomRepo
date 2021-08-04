/*
 * SCOPE
 * Abstract class for basic inventory fields and functions
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AInventoryScriptable : ScriptableObject
{
    [Tooltip("The name of the item")]
    public string itemName;

    [Tooltip("Background information on the item")]
    public string itemDescription;

    [Tooltip("What is the type of item")]
    public ItemEnum itemType;

    [Tooltip("Can this item be stacked?")]
    public bool stackable;

    [Tooltip("A sprite for the object")]
    public Sprite itemSprite;

    public virtual void ValidateItems()
    {
        //TODO: check that consumable and stackable setting is compatible with type
        //TODO: All required item fields are populated
    }
}
