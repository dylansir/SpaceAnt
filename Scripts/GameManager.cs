
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay= 1f;
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("game over");
            Invoke("GameOver", restartDelay);
        }
    }


    void GameOver ()
    {
        SceneManager.LoadScene("TryAgain");
    }

}