using System;
using System.Collections.Generic;
using UnityEngine;



public class DecideLight : MonoBehaviour
{
    
    public List<GameObject> lights;
    //public float Priority { get; set; }


    public GameObject target;

   // public List<GameObject> onLights;
    //public float Priority { get; set; }



    private void Update()
    {
        DetermineOnLight();
    }
    public void DetermineOnLight()
    {

         foreach (GameObject light in lights)
         {
             if (light.GetComponent<Light>().isActiveAndEnabled == true)
             {
                 if (target == null) target = light;
                 if (light.GetComponent<Light>().intensity > target.GetComponent<Light>().intensity) target = light;
             }
             //if (light.GetComponent<Light>().intensity > target.GetComponent<Light>().intensity) target = light;

         }
        if (target != null) if (target.GetComponent<Light>().isActiveAndEnabled == false) target = null;

    }

    /*public int CompareTo(object obj)
    {
        foreach (GameObject.FindObjectOfType(). item in onLights)
        {
            Priority = item.GetComponent<Light>().intensity;
        }
        throw new NotImplementedException();
    }*/
}
/*void onLightList(GameObject light)
{
    foreach (GameObject obj in onLights)
    {   if (target == null) target = obj;
        if (obj.GetComponent<Light>().intensity > target.GetComponent<Light>().intensity) target = obj;
    }
    //onLights.ForEach(Debug.Log);
    Debug.Log(target);


    onLights.Add(light);
    if(onLights.Count > 1)
    { 
        onLights.Sort()
        onLights.ForEach(Debug.Log);
    }


}*/



/*public class ILightChecker : IComparable
{
    public DecideLight listChecker;
    public float Priority { get; set; }

    public ILightChecker()
    {
        foreach (GameObject item in listChecker.onLights)
        {
            Priority = item.GetComponent<Light>().intensity;
        }
    }

    public int CompareTo(object obj)
    {
        return Priority.CompareTo(Priority);
    }
}*/


/*public GameObject CompareLights()
{
    GameObject ret = new GameObject();
    //return 0;
    foreach (GameObject light in lights)
    {
        if (light.GetComponent<Light>().isActiveAndEnabled == true)
        {
            if (target == null) target = light;
            if (light.GetComponent<Light>().intensity > target.GetComponent<Light>().intensity) target = light;
        }
    }
    return target;
}*/