using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public float timeStart = 60f;
    public Text textBox;
   
    void Start()
    {
        textBox.text = timeStart.ToString();
        
    }


    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();

         if (timeStart <= 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
  
    }
    

    
}
