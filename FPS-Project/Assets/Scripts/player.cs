using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 0.1f;
    public  CameraControl rt;

    void Update()
    {

        //Aqui se asignan las letras WASD al movimiento del personaje
        Input Myinput = new Input();
        bool wKey = Input.GetKey(KeyCode.W);
        bool sKey = Input.GetKey(KeyCode.S);
        bool aKey = Input.GetKey(KeyCode.A);
        bool dKey = Input.GetKey(KeyCode.D);

        //Aqui condicionamos la velocidad de movimiento del personaje para cada eje
        if (wKey)
        {
            transform.position += transform.forward * speed;
        }
        if (sKey)
        {
            transform.position -= transform.forward * speed;

        }
        if (dKey)
        {
            transform.position += transform.right * speed;

        }
        if (aKey)
        {
            transform.position -= transform.right * speed;

        }

        //Aqui vinculamos el eje Y del personaje con el eje X de la camara para que el personaje rote segun la posicion en X de la camara
        transform.eulerAngles = new Vector3(0, rt.mouseX * rt.speed, 0);
    }

    
}
