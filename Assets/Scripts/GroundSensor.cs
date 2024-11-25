using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{

    public static bool isGrounded;

    public static Animator characterAnimator;


    void Awake()
    {
        characterAnimator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 7)
        {
            isGrounded = true;
            characterAnimator.SetBool("IsJumping", false);
        }
    }
    
    void OnTriggerStay2D(Collider2D collider)
    {
         if(collider.gameObject.layer == 7)
         {
            isGrounded = true;  
         }
      
    }

    void OnTriggerExit2D(Collider2D collider)
    {
         if(collider.gameObject.layer == 7)
         {
           isGrounded = false; 
           characterAnimator.SetBool("IsJumping", true);
         }
        
    }

}
