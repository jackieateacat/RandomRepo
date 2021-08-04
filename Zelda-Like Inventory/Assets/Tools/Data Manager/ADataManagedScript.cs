using UnityEngine;

public abstract class ADataManagedScript : MonoBehaviour
{
    DataManager dataManagerRef;


    private void Awake()
    {
        GetDataManager();
    }


    // Get a reference to DataManager and cache it
    private void GetDataManager()
    {
        dataManagerRef = GetComponent<DataManager>();
    }


    public virtual IntDataScriptable SubscribeToInt(IntDataScriptable template)
    {
        // Return a reference to an active copy of the template
        return dataManagerRef.IntSubscription(this, template);
    }


    public virtual FloatDataScriptable SubscribeToFloat(FloatDataScriptable template)
    {
        // Return a reference to an active copy of the template
        return dataManagerRef.FloatSubscription(this, template);
    }


    //Unsubscribes from the target float data object
    public virtual void UnsubscribeToFloat (FloatDataScriptable floatToUnsubscribeFrom)
    {
        floatToUnsubscribeFrom.Unsubscribe(this);
    }


    //Unsubscribes from the target float data object
    public virtual void UnsubscribeToInt(IntDataScriptable intToUnsubscribeFrom)
    {
        intToUnsubscribeFrom.Unsubscribe(this);
    }


    // Called by the scriptable object when data is updated
    // Run any calculations/operations in this method
    public abstract void UpdatedValue(ADataScriptable dataScriptableRef);
}
