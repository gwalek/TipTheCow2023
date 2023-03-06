using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : MonoBehaviour
{
    /* MUsic 
    https://filmmusic.io/index.php/song/4687-barnyard
    
    https://filmmusic.io/song/4676-ditty-pong

    https://filmmusic.io/song/4037-merry-go-distressed

    https://filmmusic.io/song/4660-flying-kerfuffle
    
     */



    public GameObject cowImage;
    public float cowScore = 1;
    public float moveSpeed = 5.0f;
    public float dropSpeed = 35.0f;
    
    public int moveDirection = 1;
    public float RemoveAtYof = -75;
    bool IsNotTipped = false;


    // Start is called before the first frame update
    void Start()
    {
        // needs to be placed in range of 0 to 35 on the Y Axis. 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 location = gameObject.transform.position;
        if (IsNotTipped)
        {
            location.y -= dropSpeed * Time.deltaTime;
        }
        else
        {
            location.x +=  moveSpeed * moveDirection * Time.deltaTime;
        }
        gameObject.transform.position = location;

        if (location.y < RemoveAtYof)
        {
            Destroy(gameObject);
        }
    }

    public void TipOver()
    {
        //Debug.Log("TIP COW"); 
        if (!IsNotTipped)
        {
            IsNotTipped = true;

            cowImage.transform.eulerAngles = new Vector3(-90, 90, -90);
        }
    }

}
