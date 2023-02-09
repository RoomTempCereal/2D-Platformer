



//My Code




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//add to coin/currency

//drag and drop text into the box on this one


public class CurrencySystem : MonoBehaviour
{
    public Text currencyText;
    private int Score;

    void Start()
    {
        Score = 0;
        currencyText.text = "Currency: " + Score;
    }
    /*
    private void OnTriggerEnter2D(collider2D scrap) //collider2d is wrong
    {
        if (scrap.tag == "MyScrap")
        {
            Score++;
            Destroy(scrap.gameobject);
            currencyText.text = "Currency" + Score;
        }
    } */
}

