using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsManager : MonoBehaviour
{

    [Header("Reference value coins")]
    [SerializeField] public int coins;
    [Header("Refenrence Text coins")]
    public TMP_Text textCoins;

    private void Awake()
    {
        GetCoins();
    }
    
    //call the method for buy items in shop 
    public void Buy(int price)
    {
        coins = coins - price; //calculate value coins - price of item  
        textCoins.text = coins.ToString(); //convert coins value to string 
        SetCoins(); //call method set coins 
    }
    public void GetCoins()
    {
        coins = PlayerPrefs.GetInt("Coins", coins); //get value coins key and put in variable
        textCoins.text = coins.ToString(); //convert coins value to string 
    }
    public void SetCoins()
    {
        PlayerPrefs.SetInt("Coins", coins); //set value coins in key and save
    }

    

}
