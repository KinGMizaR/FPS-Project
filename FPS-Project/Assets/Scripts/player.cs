using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Vector3 pos;

    void Start()
    {
       
        
            pos = transform.position;
    }

    
    void Update()
    {
        Input Myinput = new Input();

        bool wKey = Input.GetKey(KeyCode.W);

        bool sKey = Input.GetKey(KeyCode.S);
        bool aKey = Input.GetKey(KeyCode.A);
        bool dKey = Input.GetKey(KeyCode.D);



        if (wKey)
        {
            pos.z += 0.1f;
        }
        if (sKey)
        {
            pos.z -= 0.1f;
        }
        if (aKey)
        {
            pos.x -= 0.1f;
        }
        if (dKey)
        {
            pos.x += 0.1f;
        }
        gameObject.transform.position = pos;
    }
}
