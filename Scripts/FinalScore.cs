
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text finalScore;
    void Start()
    {
        finalScore.text = PlayerPrefs.GetInt("FinalScore").ToString();
    }

}
