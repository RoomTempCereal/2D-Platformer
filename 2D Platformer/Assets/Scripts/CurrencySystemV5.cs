using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencySystemV5 : MonoBehaviour
{
    public CurrencyAddition currencyText;
    private int currencyScore;

    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D called");
        if (other.CompareTag("Player"))
        {
            Debug.Log("Collectible collided with something");
            Destroy(gameObject);
            currencyText.AddCurrency(5);
        } 
    }
}
