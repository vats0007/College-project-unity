using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public int coins = 0;
    public TextMeshProUGUI coinText;
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Collectables")
        {
            coins++;
            coinText.text = "Coins : " + coins.ToString();
            Debug.Log(coins);
            Destroy(other.gameObject);
        }
        if (coins == 7)
        {
            coinText.text = "7 Coins are Collected\nMISSION COMPLETED";
        }

    }
}
