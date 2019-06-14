using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float mouseX;
    public float mouseY;
    public bool Mouse;
    public float speed = 5;
     
 
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X");
        if (Mouse)
        {
            mouseY += Input.GetAxis("Mouse Y");

        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y");

        }
        Debug.Log(mouseX);
        transform.eulerAngles = new Vector3(mouseY*speed, mouseX*speed, 0);
    }
        
      
}
