using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameControl : MonoBehaviour
{
    public static GameControl instance; 

    public float RoundTime = 100;
    public float RoundScore = 0;

    bool IsInGameplay = true; 

    public CowSpawner spawner;
    public TapToTip tapCcontrol;
    public float CurrentTime = 100;
    public TextMeshProUGUI RoundScoreField;
    public TextMeshProUGUI RoundTimeField;
    public AudioSource audioPlayer;

    public List<AudioClip> MooList;
   

    void Awake()
    {
        if (instance)
        {
            Destroy(instance); 
        }
        instance = this;

        StartRound(); 
    }



    void StartRound()
    {
        IsInGameplay = true;
        CurrentTime = RoundTime;
        RoundScore = 0;
        ShowGameUI(); 

        //spawner.sta

    }

    // Update is called once per frame
    void Update()
    {
        if (!IsInGameplay)
        {
            return; 
        }
        
        CurrentTime -= Time.deltaTime; 
        
        if (CurrentTime <= 0 )
        {
            IsInGameplay = false;
            ShowEndRound();
            return; 
        }

        UpdateGameStats(); 
    }

    void UpdateGameStats()
    {
        RoundTimeField.text =  ((int)CurrentTime + 1).ToString();
        RoundScoreField.text = RoundScore.ToString(); 
    }

    void ShowEndRound()
    {
        HideGameUI(); 
    }

    void ShowGameUI()
    {

    }

    void HideGameUI()
    {

    }

    public void AddScore(int value)
    {
        RoundScore += value;
        int index = Random.Range(0, (MooList.Count));
        float pitch = .9f + Random.Range(0, .2f);
        AudioClip clip = MooList[index];
        audioPlayer.pitch = pitch; 
        audioPlayer.PlayOneShot(clip); 
    }
}
