using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu_Juego : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject UI;

    private void Start()
    {
        pauseMenu.SetActive(false);
        UI.SetActive(true);
    }



    public void Volver()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }


    public void Pause()
    {
        UI.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Continue()
    {
        pauseMenu.SetActive(false);
        UI.SetActive(true);
        Time.timeScale = 1f;
    }

}
