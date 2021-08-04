using UnityEngine;

//This only calls for scripts to update when boundaries or base value is changed. 
//If you need to do something any time the current value changes, you need to get current value in an update loop

[CreateAssetMenu(fileName = "NewFloat", menuName = "DataManager/Float", order = 1)]
public class FloatDataScriptable : ADataScriptable
{
    [SerializeField] float baseValue; //base value like current health or strength attribute
    [SerializeField] float currentValue; //Base value plus modifiers
    [SerializeField] float minimum;
    [SerializeField] float maximum;


       public float GetBaseValue()
    {
        UpdateModifiers();
        return baseValue;
    }


    public float GetCurrentValue()
    {
        UpdateModifiers();
        return currentValue;
    }


    public float GetMinimum()
    {
        UpdateModifiers();
        return minimum;
    }


    public float GetMaximum()
    {
        UpdateModifiers();
        return maximum;
    }


    //Base value is value before any modifiers. Value is only accepted if it is between bounds
    public void SetBaseValue(float newValue, ADataManagedScript caller)
    {
        if (newValue <= maximum && newValue >= minimum)
        {
            baseValue = newValue;
        }

        UpdateModifiers();
        UpdateSubscribers(caller);
    }


    public void SetBounds(float newMinimum, float newMaximum, ADataManagedScript caller)
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

    //TODO: List of modifiers and duration
    //TODO: get and add modifier methods
}
