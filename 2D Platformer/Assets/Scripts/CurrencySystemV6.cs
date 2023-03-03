using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencySystemV6 : MonoBehaviour
{
    public Text currencyText;
    private int currencyScore;
    private int scrapCount;

    void Start()
    {
        currencyScore = 0;
        scrapCount = 0;
        UpdateCurrencyText();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("MyScrap"))
        {
            Destroy(other.gameObject);
            scrapCount++;
            currencyScore += 5;
            UpdateCurrencyText();
        }
    }

    private void UpdateCurrencyText()
    {
        currencyText.text = "Scrap: " + scrapCount + " - Currency: " + currencyScore;
    }
}