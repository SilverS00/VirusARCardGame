using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Inicial : MonoBehaviour
{
    // Start is called before the first frame update
   

    public void Jugar()
    {

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
        public void salir()
    {
        print("salir del juego");

        Application.Quit();
    }


}
