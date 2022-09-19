using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; // keep track of score
    public TextMeshProUGUI scoreText; // text object modified
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }
    public void IncreaseScoreText(int amount)
    {
        score += amount;//increses by amount
        UpdateScoreText();
    }
    public void DecreaseScoreText9(int amount)
    {
        score -= amount;//decreases by amount
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score:"+ score;
    }

}
