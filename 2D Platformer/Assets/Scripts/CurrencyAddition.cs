using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CurrencyAddition : MonoBehaviour
{
    private int Currency;
    public string texttext;

    // Start is called before the first frame update
    void Start()
    {
        Currency = 0;
    }

    // Update is called once per frame
    public void AddCurrency(int extraCurrency)
    {
        Currency += extraCurrency;
        texttext = "Currency: " + Currency;
        GetComponent<Text>().text = texttext.ToString();
    }
}
