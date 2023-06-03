using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public float spawnTime;

    float m_spawnTime;
    int m_score;
    bool m_gameIsOver;

    UIManager m_ui;
    Line m_line;

    // Start is called before the first frame update
    void Start()
    {
        m_ui = FindObjectOfType<UIManager>();
        m_line = FindObjectOfType<Line>();

        m_spawnTime = 0;
        spawnTime = 2;
        //Set score = 0 or scrore when start game
        m_ui.setScoreText("Score: " + m_score);

    }

    // Update is called once per frame
    void Update()
    {
        //Create many ball in times
        m_spawnTime -= Time.deltaTime;

        if (m_gameIsOver) // Check Game is over
        {
            m_spawnTime = 0;
            m_ui.setGameOverPanel(true);
            return;
        }

        if(m_spawnTime <= 0) // Display per on second
        {
            spawnBall();
            m_spawnTime = spawnTime; // in 2 second display one ball
        }
    }

    //Button Play Again
    public void playAgain()
    {
        m_score = 0;
        m_gameIsOver = false;
        m_ui.setScoreText("Score " + m_score);
        m_ui.setGameOverPanel(false);
        //Reload Scene Game Play
        SceneManager.LoadScene("GamePlay");
    }

    //Create Ball
    public void spawnBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-12,12), 6);

        if (ball)
        {
            Instantiate(ball, spawnPos, Quaternion.identity);
        }
    }

    // Plus Score
    public void incrementScore()
    {
        m_score++;
        m_ui.setScoreText("Score: " + m_score);
    }

    //Set & Get Score
    public void setScore(int value)
    {
        m_score = value;
    }

    public int getScore()
    {
        return m_score;
    }

    //Set & Get bool gameIsOver
    public void setGameIsOver(bool state)
    {
        m_gameIsOver = state;
    }

    public bool getGameIsOver()
    {
        return m_gameIsOver;
    }

}
