using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
