using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencySystem : MonoBehaviour
{
    public Text currencyText;
    private int Score;

    void Start()
    {
        Score += 50;
        currencyText.text = "Currency: " + Score;
    }

    void On
}