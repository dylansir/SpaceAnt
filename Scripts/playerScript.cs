using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void  OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "FrogGFX") {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

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

public class SpherePoints : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void  OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name == "HIVE") {
            KeepScore.Score += 1;
            Destroy(gameObject);
        }
    }
}

public class HiveScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collider2D collision)
    {
       void OnCollisionEnter2D(Collision2D coll) {
         if (coll.gameObject.tag == "Collectable") //Change tag
             Destroy(coll.gameObject);
       }
    }
}

public class GrabController : MonoBehaviour
{
    public Transform grabDetect;
    public Transform boxHolder;
    public float rayDist;


    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);

        if(grabCheck.collider != null && grabCheck.collider.tag == "box")
        {
            if (Input.GetKey(KeyCode.G))
            {
                grabCheck.collider.gameObject.transform.parent = boxHolder;
                grabCheck.collider.gameObject.transform.position = boxHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;

            }
            else{
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;

            }
        }
    }
}
