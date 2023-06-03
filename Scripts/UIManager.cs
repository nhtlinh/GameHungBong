using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOverPanel;


    //Display score on screen
    public void setScoreText(string txt)
    {
        if (scoreText)
        {
            scoreText.text = txt;
        }
    }

    //Display GameOver panel on screen
    public void setGameOverPanel(bool isShow)
    {
        if (gameOverPanel)
        {
            gameOverPanel.SetActive(isShow);
        }
    }
}
