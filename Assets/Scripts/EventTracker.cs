using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using System;
using UnityEngine;

public class EventTracker : MonoBehaviour
{
    public GameObject[] spawnPrefabs;
    public string[] imageNames;


    void Start()
    {
        ARTrackedImage aRTracked = GetComponent<ARTrackedImage>();
        int i = Array.IndexOf(imageNames, aRTracked.referenceImage.name);
        Instantiate(spawnPrefabs[i], transform.position, transform.rotation, transform);
    }
}
