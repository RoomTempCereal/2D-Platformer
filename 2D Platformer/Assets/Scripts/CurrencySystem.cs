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
        Score += 50;
        currencyText.text = "Currency: " + Score;
    }
}

