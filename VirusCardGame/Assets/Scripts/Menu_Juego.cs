using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu_Juego : MonoBehaviour
{
    // Start is called before the first frame update
    public void Volver()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    bool isPaused = false;


    public void Pausa()
    {

        if(isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }

        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }

        print("Juego en pausa");
    }


}
