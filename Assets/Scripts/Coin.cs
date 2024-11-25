using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private AudioSource _audioSource;

    private bool interactable;
    
    private BoxCollider2D boxCollider;

    void OnTriggerEnter2D(Collider2D collider)
    {
       
        if(collider.gameObject.tag == "Player")
        {  
          Destroy(gameObject);
          GameManager.instance.AddCoins();
        }
    }
}
