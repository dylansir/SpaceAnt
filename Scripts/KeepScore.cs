using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepScore : MonoBehaviour
{
    public Text scoreText;
   public static int Score = 0;

   public Text finalScore;

    void Start()
    {
       
    }

    
    // Update is called once per frame
    void Update()
    {
        scoreText.text = Score.ToString();
        PlayerPrefs.SetInt("FinalScore", Score);
    }


}
