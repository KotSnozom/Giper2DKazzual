using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text ScoreText;

    public void UpdateScore(int CoinCount)
    {
        ScoreText.text = CoinCount.ToString();
    }
}
