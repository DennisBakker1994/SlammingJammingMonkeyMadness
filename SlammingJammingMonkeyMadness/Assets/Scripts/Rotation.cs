using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float mouseX;
    public float mouseY;
    public Vector3 camrot;
    public Vector3 playerrot;
    public Transform playerBody;
    public float hi;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        //mouseY = Input.GetAxis("Mouse Y");

        //camrot.x = -mouseY;
        playerrot.y = mouseX;

        //transform.Rotate(camrot);
        playerBody.transform.Rotate(playerrot);
    }
}
