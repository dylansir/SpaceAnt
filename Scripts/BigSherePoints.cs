using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSherePoints : MonoBehaviour
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
            KeepScore.Score += 4;
            Destroy(gameObject);
        }
    }
}

