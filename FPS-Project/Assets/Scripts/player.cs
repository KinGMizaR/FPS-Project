using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 0.1f;
    public  CameraControl rt;

    void Update()
    {
        Input Myinput = new Input();

        bool wKey = Input.GetKey(KeyCode.W);
        bool sKey = Input.GetKey(KeyCode.S);
        bool aKey = Input.GetKey(KeyCode.A);
        bool dKey = Input.GetKey(KeyCode.D);

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


        transform.eulerAngles = new Vector3(0, rt.mouseX * rt.speed, 0);
    }

    
}
