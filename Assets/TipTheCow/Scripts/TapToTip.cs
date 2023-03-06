using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToTip : MonoBehaviour
{
    // Camera 

    /*
     * 
     *  RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit)) {
            Transform objectHit = hit.transform;
            
            // Do something with the object that was hit by the raycast.
        }
     */


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchSupported)
        {
            TouchScreenInput(); 
        }
        else
        {
            MouseInput(); 
        }
        
    }

    void TouchScreenInput()
    {

    }

    void MouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckTapAt(Input.mousePosition); 
        }
    }

    void CheckTapAt(Vector2 location)
    {
        Debug.Log("location: " + location); 
    }
}
