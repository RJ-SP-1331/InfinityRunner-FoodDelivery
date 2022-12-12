using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text txt;
    [SerializeField] private TMP_Text txtCoins;

    private int score;
    private float timer;
    ScrollCoin scrollCoin;
    public int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
        

    }
    void UpdateScore()
    {
        int scorePerseconds = 10;
        timer += Time.deltaTime;
        score = (int)(timer * scorePerseconds);
        txt.text = string.Format("{0:0000}", score);

    }
    void UpdateCoins(int monedascount)
    {
        
        txtCoins.text = monedascount.ToString();

    }
    public static void Actmonedas()
    {
        GameManager gameManager = new GameManager();
        if (gameManager.coins == 99)
        {
            gameManager.coins = 0;
        }
        else
        {
            gameManager.coins += 1;
        }
        gameManager.UpdateCoins(gameManager.coins);
    }
    
    

}
