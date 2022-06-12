using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeState : MonoBehaviour
{
    [SerializeField]
    private GameObject organo;

    [SerializeField]
    private Texture[] textures;
    private Renderer organRenderer;

    private void Start()
    {
        organRenderer = organo.GetComponent<Renderer>();
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            organRenderer.material.mainTexture = textures[0];
        }

        if (Input.GetKey(KeyCode.W))
        {
            organRenderer.material.mainTexture = textures[1];
        }

        if (Input.GetKey(KeyCode.E))
        {
            organRenderer.material.mainTexture = textures[2];
        }
    }

}
