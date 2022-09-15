using System;
using System.Collections.Generic;
using UnityEngine;

public class ILightChecker : MonoBehaviour
{
    public float Intensity { get; set; }
    public List<GameObject> lightList;

    public int CompareLights()
    {
        return 0;
        //return Intensity.CompareTo(Intensity);
    }
}
