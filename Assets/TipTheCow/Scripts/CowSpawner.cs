using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowSpawner : MonoBehaviour
{
    public List<GameObject> CowList;

    public float MinCowSpawn = .5f;
    public float MAxCowSpawn = 1.5f;

    float NextCowSpawn = .2f;
    float counter = 0f;

    bool IsInGameplay = true; 

    void Start()
    {

        StartRound();

    }



    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime; 
        if (counter >= NextCowSpawn)
        {
            counter = 0;
            SpawnCow(); 

        }
    }

    public void StartRound()
    {
        SpawnCow();
        SpawnCow();
        SpawnCow();
        SpawnCow();
        SpawnCow();
        SpawnCow();
        IsInGameplay = true;
    }

    public void EndRound()
    {
        IsInGameplay = false; 
    }

    void SpawnCow()
    {
        int index = Random.Range(0, (CowList.Count));
        GameObject calf = CowList[index]; 
        Instantiate(calf);
    }
}
