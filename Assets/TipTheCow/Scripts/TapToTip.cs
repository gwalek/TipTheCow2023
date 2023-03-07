using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToTip : MonoBehaviour
{
    
    public Camera gameCamera;
    public bool IsInGameplay = true; 
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!IsInGameplay)
        {
            return; 
        }


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
        RaycastHit hit;
        Ray ray = gameCamera.ScreenPointToRay(location);

        if (Physics.Raycast(ray, out hit))
        {
            Cow cow = hit.collider.GetComponentInParent<Cow>(); 

            if (cow)
            {
                cow.TipOver(); 
            }
        }
    }
}
