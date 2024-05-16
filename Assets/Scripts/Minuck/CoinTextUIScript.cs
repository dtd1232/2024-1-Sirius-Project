using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinTextUIScript : MonoBehaviour
{
    [SerializeField] LongerCoin longerCoin;
    private TextMeshProUGUI coinText;
    // Start is called before the first frame update
    void Start()
    {
        coinText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = longerCoin.coin.ToString();
    }
}
