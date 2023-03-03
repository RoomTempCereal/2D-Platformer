using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencySystemV5 : MonoBehaviour
{
    public Text currencyText;
    private int currencyScore;

    void Start()
    {
        currencyScore = 0;
        currencyText.text = "Currency: " + currencyScore;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("MyScrap"))
        {
            Destroy(other.gameObject);
            currencyScore += 5;
            currencyText.text = "Currency: " + currencyScore;
        }
    }
}
