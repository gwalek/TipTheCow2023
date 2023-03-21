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
    public int cowScore = 1;
    public float moveSpeed = 5.0f;
    public float dropSpeed = 35.0f;

    public int moveDirection = 1;
    public float RemoveAtYof = -75;
    public float RemoveAtAbsX = 65;
    public float SpawnAtX = 64;
    public float SpawnAtMaxY = 35;
    bool IsTippedOver = false;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 location = Vector3.zero;
        location.x = -64f;
        location.y = Random.Range(0, SpawnAtMaxY);
        moveDirection = 1; 

        if (Random.Range(0, 64) > 40)
        {
            // Flip Direction of the cow. 
            location.x = 64f;
            moveDirection = -1;
            cowImage.transform.localScale = new Vector3(1.5f, 1.0f, 1.5f);
        }
        Debug.Log(gameObject.name + " :"+ moveDirection + ": " + location); 

        gameObject.transform.position = location; 

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 location = gameObject.transform.position;
        if (IsTippedOver)
        {
            location.y -= dropSpeed * Time.deltaTime;
        }
        else
        {
            location.x += moveSpeed * moveDirection * Time.deltaTime;
        }
        gameObject.transform.position = location;

        if (Mathf.Abs(location.x) >= RemoveAtAbsX)
        {
            Destroy(gameObject);
        }

        if (Mathf.Abs(location.y) <= RemoveAtYof)
        {
            Destroy(gameObject);
        }
    }

    public void TipOver()
    {
        //Debug.Log("TIP COW"); 
        if (!IsTippedOver)
        {
            IsTippedOver = true;
            GameControl.instance.AddScore(cowScore); 
            cowImage.transform.eulerAngles = new Vector3(-90, 90, -90);
        }
    }
}