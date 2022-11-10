using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour

   
{
    public float speed = 20f;
     public Animator animator;
    void Update()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0.0f);
    
        
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);
        
        transform.position = transform.position + movement * Time.deltaTime;
    }

    private void OntriggerEnter2D(Collider2D collision)
    {
        print("Colliding!");
      
    }
}
