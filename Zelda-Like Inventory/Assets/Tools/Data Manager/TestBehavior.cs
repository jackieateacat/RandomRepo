using UnityEngine;

public class TestBehavior : ADataManagedScript
{
    public IntDataScriptable healthTemplate;
    public IntDataScriptable healthActive;

    public FloatDataScriptable shieldTemplate;
    public FloatDataScriptable shieldActive;

    private void Start()
    {
        healthActive = SubscribeToInt(healthTemplate);
        shieldActive = SubscribeToFloat(shieldTemplate);
    }


    public override void UpdatedValue(ADataScriptable dataScriptableRef)
    {
        Debug.Log("Update on test behavior called");
    }
}
