using System.Collections.Generic;
using UnityEngine;

public abstract class ADataScriptable : ScriptableObject
{
    public string variableName;
    public List<ADataManagedScript> subscribers = new List<ADataManagedScript>();


    public string GetFieldName()
    {
        return variableName;
    }


    public virtual void UpdateSubscribers(ADataManagedScript caller)
    {
        //Call UpdatedEvent method in each subscriber
        foreach (ADataManagedScript subscriber in subscribers)
        {
            // Remove any null references
            if (subscriber == null)
            {
                subscribers.Remove(subscriber);
            }
            else if (subscriber != caller)
            {
                subscriber.UpdatedValue(this);
            }
        }
        //TODO: Test for null reference handling
    }


    public void Subscribe(ADataManagedScript newSubscriber)
    {
        //Add subscriber if it is not a duplicate
        if (!subscribers.Contains(newSubscriber))
        {
            subscribers.Add(newSubscriber);
        }
    }


    public void Unsubscribe(ADataManagedScript removeSubscriber)
    {
        //Find and remove all subscribers that match
        subscribers.Remove(removeSubscriber);
    }
}
