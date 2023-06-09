using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public int health = 3;

    public void SavePlayer(int i)
    {
        PlayerPrefs.SetInt(i.ToString() + "Health", health);

        PlayerPrefs.SetFloat(i.ToString() + "PlayerX", transform.position.x);
        PlayerPrefs.SetFloat(i.ToString() + "PlayerY", transform.position.y);
        PlayerPrefs.SetFloat(i.ToString() + "PlayerZ", transform.position.z);

        Debug.Log("Saved");
    }

    public void LoadPlayer(int i)
    {
        health = PlayerPrefs.GetInt(i.ToString() + "Health");
        
        Vector3 position = new Vector3
         (
            PlayerPrefs.GetFloat(i.ToString() + "PlayerX"),
            PlayerPrefs.GetFloat(i.ToString() + "PlayerY"),
            PlayerPrefs.GetFloat(i.ToString() + "PlayerZ")
         );
        transform.position = position;
        Debug.Log("loaded");
    }
}
