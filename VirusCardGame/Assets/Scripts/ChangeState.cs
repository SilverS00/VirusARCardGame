using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeState : MonoBehaviour
{
    [SerializeField] private GameObject organo;
    [SerializeField] private GameObject organoHolder;
    [SerializeField] private GameObject win;

    [SerializeField] private Texture[] textures;
    private Renderer organRenderer;

    [SerializeField] private GameObject inmunizarLoop;
    [SerializeField] private GameObject infectarLoop;
    [SerializeField] private GameObject curarLoop;

    bool medicina = false;
    bool virus = false;

    bool protegido = false;
    bool morido = false;

    private void Start()
    {
        organRenderer = organo.GetComponent<Renderer>();
        inmunizarLoop.SetActive(false);
        infectarLoop.SetActive(false);
        curarLoop.SetActive(false);
        BaseForm();
    }

    public void BaseForm()
    {
        medicina = false;
        virus = false;
        protegido = false;
        morido = false;
        organRenderer.material.mainTexture = textures[0];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            MedicinaVista();
        }

        if(Input.GetKey(KeyCode.W))
        {
           VirusVisto();
        }
    }

    public void MedicinaVista()
    {
        if(medicina == false)
        {
            Curar();
        }
        else if (morido == false)
        {
            if(medicina == true && protegido == false)
            {
                Inmune();
            }
        }
    }

    private void Curar()
    {
        if (organoHolder.GetComponent<OrgansOnBody>().organOnBody == true)
        {
            StartCoroutine(CurarActivate());
        }
    }

    IEnumerator CurarActivate()
    {
        curarLoop.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        medicina = true;
        curarLoop.SetActive(false);

    }

    private void Inmune()
    {
        if (organoHolder.GetComponent<OrgansOnBody>().organOnBody == true)
        {
            StartCoroutine(InmunizarActivate());
            win.GetComponent<WinCondition>().AddScore();
        }
          
    }

   IEnumerator InmunizarActivate()
    {
        inmunizarLoop.SetActive(true);

        yield return new WaitForSeconds(1);

        organRenderer.material.mainTexture = textures[1];

        yield return new WaitForSeconds(.5f);
        inmunizarLoop.SetActive(false);
        protegido = true;

    }


    public void VirusVisto()
    {
        if (virus == false && protegido == false)
        {
            Infectar();
        }
        else if (protegido == false)
        {
            if(virus == true)
            {
                Infectado();
            }
        }
    }

    private void Infectar()
    {
        if (organoHolder.GetComponent<OrgansOnBody>().organOnBody == true)
        {
            StartCoroutine(InfectarActivate());
        }
    }

    IEnumerator InfectarActivate()
    {
        infectarLoop.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        virus = true;
        infectarLoop.SetActive(false);

    }

    private void Infectado()
    {
        if (organoHolder.GetComponent<OrgansOnBody>().organOnBody == true)
        {
            StartCoroutine(InfectadoActivate());
        }

    }

    IEnumerator InfectadoActivate()
    {
        infectarLoop.SetActive(true);

        yield return new WaitForSeconds(1);

        organRenderer.material.mainTexture = textures[2];

        yield return new WaitForSeconds(.5f);
        infectarLoop.SetActive(false);
        morido = true;

        yield return new WaitForSeconds(5f);
        BaseForm();
    }



}
