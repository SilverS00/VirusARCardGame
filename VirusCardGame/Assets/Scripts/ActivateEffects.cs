using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEffects : MonoBehaviour
{
    [SerializeField] GameObject infected;


    // Start is called before the first frame update
    void Start()
    {
        infected.SetActive(false);
    }

    public void IsInfected()
    {
        infected.SetActive(true);
    }


    public void IsNotInfected()
    {
        infected.SetActive(false);
    }
}
