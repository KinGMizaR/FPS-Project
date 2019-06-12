using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public static int numZombies;
    public bool die;
    public GameObject player;
    public float speed = 0.01f;
    void Start()
    {

        player = GameObject.Find("Main Camera");
        numZombies++;
        Debug.Log(numZombies);
 
                 void CountZombies()
                 {
            Debug.Log(numZombies);
                 }
        void Update()
        {


            Vector3 direction = (player.transform.position -
            transform.position).normalized;
            float distance = (player.transform.position -
            transform.position).magnitude;
            Vector3 move = transform.position + (direction * speed);
            transform.position = move;

            if (Zombie.numZombies < 4)
            {
                GameObject go = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                go.AddComponent(typeof(Zombie));
                go.transform.position = transform.position;
            }

            if (distance < 1f)
            {
                die = true;
            }
            if (die)
            {
                numZombies--;
                Destroy(gameObject);
            }
        }
    }
}

  

