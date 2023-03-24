using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaThrow : MonoBehaviour
{
    public Animator boomerrangAnimatie;


    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            boomerrangAnimatie.SetTrigger("Throw");
        }


    }
}
