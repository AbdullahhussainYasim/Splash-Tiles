using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 
    public static int scorepoints = 0;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {

        scorepoints = 0;
        score = 0;
    }


    void Update()
    {

    }

    public void updateScore(int score_)
    {
        score += score_;
        scorepoints = score;
        scoreText.text = "Your Score: " + score.ToString("0"); 
    }
}
