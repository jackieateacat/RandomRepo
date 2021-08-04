/*
 * SCOPE
 * Additional attributes for power up shard scriptable objects
 */

using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewPowerUpShard", menuName = "Inventory Item/Power-Up Shard", order = 0)]
public class PowerUpShardScriptable : AInventoryScriptable
{
    [Tooltip("Which number of shard is this.")]
    [Range(0, 9)]
    public int shardNumber;

    [Tooltip("Which shards are related to this shard.")]
    public List<PowerUpShardScriptable> relatedShards;


    private void OnEnable()
    {
        itemType = ItemEnum.PowerupShard;
        ValidateItems();
    }
}
