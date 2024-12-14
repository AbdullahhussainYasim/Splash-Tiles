using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class lastscore : MonoBehaviour
{
    public TMP_Text mytext; 
    public static int scorepoint = 0;

    // Start is called before the first frame update
    void Start()
    {

        scorepoint = ScoreScript.scorepoints;


        mytext.text = "Your Score: " + scorepoint.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
