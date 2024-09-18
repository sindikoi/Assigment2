using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private int score = 0;
    
    void Start()
    {
        Enemy.UpdateScore += UpdateScore;
    }

   public  void UpdateScore(int update)
    {
        score += update;
        scoreText.text = $" score:{score}";
    //    Debug.LogError("in updatescore");
       
    }


    private void OnDestroy()
    {
        Enemy.UpdateScore -= UpdateScore;
    }

}
