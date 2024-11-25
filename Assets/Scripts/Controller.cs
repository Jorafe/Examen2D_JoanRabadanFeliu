using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
   private Rigidbody2D characterRigidbody;
    
    private float horizontalInput;

    public static Animator characterAnimator;
    
    [SerializeField]private float characterSpeed = 4.5f;

    [SerializeField]private float jumpForce = 100f;

    void Awake()
    {
        characterRigidbody = GetComponent<Rigidbody2D>();
        characterAnimator = GetComponent<Animator>();
    }


    // Start is called before the first frame update

    void Update()
    {
      Movimiento();

      if(Input.GetButtonDown("Jump") && GroundSensor.isGrounded)
      {
         Jump();
        
      }
        
      horizontalInput = Input.GetAxis("Horizontal"); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        characterRigidbody.velocity = new Vector2(horizontalInput * characterSpeed, characterRigidbody.velocity.y);

    }

    void Movimiento()
    {
        if(horizontalInput == 0)
         {
            horizontalInput = 0;
          
         }
         else
         {
            horizontalInput = Input.GetAxis("Horizontal");
         }
         

         if(horizontalInput == 0)
         {
            characterAnimator.SetBool("IsWalking", false);
         }

         
         else if(horizontalInput < 0)
         {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            characterAnimator.SetBool("IsWalking", true); 
         }
          else if(horizontalInput > 0)
         {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            characterAnimator.SetBool("IsWalking", true); 
         }
    }

    void Jump()
    {
        characterRigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        characterAnimator.SetBool("IsJumping", true);
    }
}
