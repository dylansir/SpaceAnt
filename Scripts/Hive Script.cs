using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
