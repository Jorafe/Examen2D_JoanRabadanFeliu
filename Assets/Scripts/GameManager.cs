using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int stars = 0;

    private int coins = 0;

    [SerializeField] Text _starsText;

    [SerializeField] Text _coinsText;

    private bool isVictory;

    [SerializeField] private GameObject _victoryMenu;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void Victory()
    {
        
        if (!isVictory)
        {   
            isVictory = true;
            Time.timeScale = 0;
            _victoryMenu.SetActive(true);
            

        }
        
    }    


    public void AddStars()
    {
       
        stars += 1;
        if(stars >= 3)
            {
                GameManager.instance.Victory();  
            }
    }

     public void AddCoins()
    {
        coins++;
        _coinsText.text = coins.ToString();
    }

    public void SceneLoad(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }

    

   
}
