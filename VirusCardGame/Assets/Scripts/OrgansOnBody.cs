using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrgansOnBody : MonoBehaviour
{
    [SerializeField] GameObject organ;
    public bool organOnBody = false;

    // Start is called before the first frame update
    void Start()
    {
        organ.SetActive(false);
        organOnBody = false;
    }

    public void OrganInBody()
    {
        organ.SetActive(true);
        organOnBody = true;
    }


    public void Dead()
    {
        organ.SetActive(false);
        organOnBody = false;
    }
}
