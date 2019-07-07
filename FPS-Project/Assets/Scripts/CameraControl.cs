using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //Se crean variables para obtener la posicion del mouse y vincularlas a las variables
    public float mouseX;
    public float mouseY;
    public bool Mouse;
    public float speed = 5;
     
 
    void Update()
    {
        //Aqui se consigue la posicion del mouse y se asocia con la camara principal
        mouseX += Input.GetAxis("Mouse X");
        if (Mouse)
        {
            mouseY += Input.GetAxis("Mouse Y");

        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y");

        }
        //Se le asigana velocidad a los 2 ejes de la camara
        Debug.Log(mouseX);
        transform.eulerAngles = new Vector3(mouseY*speed, mouseX*speed, 0);
    }
        
      
}
