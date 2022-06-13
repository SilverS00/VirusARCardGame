using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public int Score;
    public Text ScoreText;
    [SerializeField] GameObject youWin;

    private void Start()
    {
        youWin.SetActive(false);
    }
    private void Update()
    {
        if (Score >= 5)
        {
            YouWin();
        }
    }

    void YouWin()
    {
        youWin.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Volver()
    {
        youWin.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void AddScore()
    {
        Score++;
        ScoreText.text = Score + "/5";

    }
}
