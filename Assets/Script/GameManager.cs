using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI TimeText;

    private int score = 0;
    private float timeElapsed = 0f;

    void Start()
    {
        UpdateScoreText();
        UpdateTimeText();
    }

    void Update()
    {
        //test
        score++;
        UpdateScoreText();
    }
    void UpdateScoreText()
    {
        ScoreText.text = "Score: " + score.ToString();
    }
    void UpdateTimeText()
    {
        //test
    }
}
