using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript : MonoBehaviour
{
    public GameObject botonGO;
    public CoheteScript coheteScript;
<<<<<<< HEAD
=======

>>>>>>> 6983be84fb66176146cce47ad8300bd8d5203d68
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        botonGO.SetActive(false);
        coheteScript.Despegue();
    }

    void OnMouseUp()
    {
        botonGO.SetActive(true);
    }
}
