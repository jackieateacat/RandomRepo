using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public List<IntDataScriptable> intTemplates = new List<IntDataScriptable>();
    public List<FloatDataScriptable> floatTemplates = new List<FloatDataScriptable>();

    public List<IntDataScriptable> intDataActive = new List<IntDataScriptable>();
    public List<FloatDataScriptable> floatDataActive = new List<FloatDataScriptable>();


    private void Awake()
    {
        // Clone all existing templated into active data holders
        foreach (IntDataScriptable dataObject in intTemplates) 
        {
            IntTemplateToActive(dataObject);
        }

        // Clone all existing templated into active data holders
        foreach (FloatDataScriptable dataObject in floatTemplates) 
        {
            FloatTemplateToActive(dataObject);
        }
    }


    private void IntTemplateToActive(IntDataScriptable dataObject)
    {
        // Create a clone of the template and save clone to active
        intDataActive.Add(Instantiate(dataObject));  
    }


    private void FloatTemplateToActive(FloatDataScriptable dataObject)
    {
        // Create a clone of the template and save clone to active
        floatDataActive.Add(Instantiate(dataObject));  
    }


    public IntDataScriptable IntSubscription(ADataManagedScript subscriber, IntDataScriptable targetIntTemplate)
    {
        //If the data manager already contains the template
        if(intTemplates.Contains(targetIntTemplate))
        {
            //Get the matching index value
            var index = intTemplates.IndexOf(targetIntTemplate);

            //Send the subscriber ref to the data object for caching
            intDataActive[index].Subscribe(subscriber);

            //Return the associated active data object
            return intDataActive[index];
        }
        else
        {
            //Add the template to the template list
            intTemplates.Add(targetIntTemplate);

            // Create a clone of the template, save clone to active
            var clone = Instantiate(targetIntTemplate);
            intDataActive.Add(clone);

            //Send the subscriber ref to the data object for caching
            clone.Subscribe(subscriber);

            //Return the cloned object
            return clone;
        }
    }


    public FloatDataScriptable FloatSubscription(ADataManagedScript subscriber, FloatDataScriptable targetFloatTemplate)
    {
        //If the data manager already contains the template
        if (floatTemplates.Contains(targetFloatTemplate))
        {
            //Get the matching index value
            var index = floatTemplates.IndexOf(targetFloatTemplate);

            //Send the subscriber ref to the data object for caching
            floatDataActive[index].Subscribe(subscriber);

            //Return the associated active data object
            return floatDataActive[index];
        }
        else
        {
            //Add the template to the template list
            floatTemplates.Add(targetFloatTemplate);

            // Create a clone of the template, save clone to active
            var clone = Instantiate(targetFloatTemplate);
            floatDataActive.Add(clone);

            //Send the subscriber ref to the data object for caching
            clone.Subscribe(subscriber);

            //Return the cloned object
            return clone;
        }
    }
}
