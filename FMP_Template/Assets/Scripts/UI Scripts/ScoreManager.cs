using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SearchService;

public class ScoreManager : MonoBehaviour
{

    public TMP_Text ScoreContainer;
    private int baseScore;


    public void AddScore(int score)
    {
        baseScore += score;
        ScoreContainer.text = "SCORE: " + baseScore;
    }


}
