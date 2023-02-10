



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
    
    private void OnTriggerEnter2D(Collider2D MyScrap)
    {
        if(MyScrap.tag == "MyScrap")
        {
            Score += 1;
            Destroy(MyScrap.gameObject);
            currencyText.text = "Currency" + Score;
        }
    }
}

