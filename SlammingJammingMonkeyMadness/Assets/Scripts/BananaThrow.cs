using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaThrow : MonoBehaviour
{
    public Animator boomerrangAnimatie;

    public GameObject boomerangSound;
    public GameObject boomerangMonkeySound;
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            boomerrangAnimatie.SetTrigger("Throw");
            boomerangSound.SetActive(false);
            boomerangSound.SetActive(true);
            boomerangMonkeySound.SetActive(false);
            boomerangMonkeySound.SetActive(true);
        }


    }
}
