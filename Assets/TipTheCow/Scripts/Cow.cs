using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : MonoBehaviour
{
    public float moveSpeed = 5.0f; 
    public int moveDirection = 1;

    public float cowScore = 1; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TipOver()
    {
        Debug.Log("TIP COW"); 
    }
}
