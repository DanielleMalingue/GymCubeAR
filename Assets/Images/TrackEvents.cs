using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class TrackEvents : MonoBehaviour
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
