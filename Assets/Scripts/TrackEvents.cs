using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using TMPro;


public class TrackEvents : MonoBehaviour
{
    public GameObject[] spawnPrefabs;
    public string[] imageNames;
    void Start()
    {
        ARTrackedImage arTracked = GetComponent<ARTrackedImage>();
        int i = Array.IndexOf(imageNames, arTracked.referenceImage.name);
        Instantiate(spawnPrefabs[i], arTracked.transform.position, arTracked.transform.rotation, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
