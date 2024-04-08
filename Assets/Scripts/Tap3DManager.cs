using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap3DManager : MonoBehaviour
{

    public Material tapMat;
    private int raycastDistance = 100;
    private Camera mainCam;
    public LayerMask layer;
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = mainCam.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, raycastDistance, layer))
                {
                    GameObject tappedObject = hit.collider.gameObject;
                    print(tappedObject.name + " was tapped");
                    StartCoroutine(Blink(tappedObject));

                }
            }
        }
    }
    IEnumerator Blink(GameObject obj)
    {
       Renderer rend = tappedObject.GetComponent<Renderer>();
         Material originalMat = rend.material;
            rend.material = tapMat;
            yield return new WaitForSeconds(0.5f);
            rend.material = defaultMat;
    }
}
