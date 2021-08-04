using UnityEngine;

//This only calls for scripts to update when boundaries or base value is changed. 
//If you need to do something any time the current value changes, you need to get current value in an update loop


[CreateAssetMenu(fileName = "NewInt", menuName = "DataManager/Int", order = 0)]
public class IntDataScriptable :ADataScriptable
{

    
    [SerializeField] int baseValue; //base value like current health or strength attribute
    [SerializeField] int currentValue; //Base value plus modifiers
    [SerializeField] int minimum;
    [SerializeField] int maximum;

    
    public int GetBaseValue()
    {
        UpdateModifiers();
        return baseValue;
    }


    public int GetCurrentValue()
    {
        UpdateModifiers();
        return currentValue;
    }


    public int GetMinimum()
    {
        UpdateModifiers();
        return minimum;
    }


    public int GetMaximum()
    {
        UpdateModifiers();
        return maximum;
    }
       

    //Base value is value before any modifiers. Value is only accepted if it is between bounds
    public void SetBaseValue(int newValue, ADataManagedScript caller)
    {
        if (newValue <= maximum && newValue >= minimum)
        {
            baseValue = newValue;
        }

        UpdateModifiers();
        UpdateSubscribers(caller);
    }

    public void SetBounds(int newMinimum, int newMaximum, ADataManagedScript caller)
    {
        //Check for reversed boundaries
        if (newMinimum < newMaximum)
        {
            minimum = newMinimum;
            maximum = newMaximum;
        }
        else
        {
            maximum = newMinimum;
            minimum = newMaximum;
        }

        UpdateModifiers();
        UpdateSubscribers(caller);
    }


    private void UpdateModifiers()
    {
        //TODO: Check for expiring modifiers on each data object to keep numbers up to date
        //TODO: Does a modifier apply to min and max bounds?
        currentValue = baseValue;
    }
}
