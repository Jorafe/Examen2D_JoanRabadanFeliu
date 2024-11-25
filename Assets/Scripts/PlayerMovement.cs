using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
   /* public Rigidbody2D rBody;

    public GroundSensor sensor; 

    public Animator anim;

    public float movementSpeed = 10;
    public float jumpForce = 10;

    private float inputHorizontal;

    public bool jump = false;

    public float xRotacion;

    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>(); 
    }
    
    // Update is called once per frame
    void Update()
    {

        inputHorizontal = Input.GetAxis("Horizontal"); 


        if(Input.GetButtonDown("Jump") & sensor.isGrounded == true) 
        {
            if (gravityChange.isGravityInverted)
            {
                rBody.AddForce(Vector2.down * jumpForce, ForceMode2D.Impulse);
            }
            else
            {
                rBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }

            foreach(Animator animator in anim)
            {
                animator.SetBool("IsJumping", true);
            }
            

        }

        if (inputHorizontal < 0 )
        {
            transform.rotation = Quaternion.Euler(xRotacion, 180, 0);
            foreach(Animator animator in anim)
            {
                animator.SetBool("IsWalking", true);
            }
            
        }
        else if(inputHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(xRotacion, 0, 0);
            foreach(Animator animator in anim)
            {
                animator.SetBool("IsWalking", true);
            }
        }
        else
        {
            foreach(Animator animator in anim)
            {
                animator.SetBool("IsWalking", false);
            }
          
            
        }
       
    }

    void FixedUpdate()
    {
        rBody.velocity = new Vector2(inputHorizontal * movementSpeed, rBody.velocity.y);
    }*/
}

    
    

