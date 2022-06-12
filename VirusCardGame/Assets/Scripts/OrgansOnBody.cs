using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrgansOnBody : MonoBehaviour
{
    [SerializeField] GameObject organ;


    // Start is called before the first frame update
    void Start()
    {
        organ.SetActive(false);
    }

    public void OrganInBody()
    {
        organ.SetActive(true);
    }


    public void Dead()
    {
        organ.SetActive(false);
    }
}
