using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class node : MonoBehaviour
{


    public bool stop = false;

    public nodeManager nm;

    public float speed = 1.0f;

    

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            nm.id++;
            nm.transformer = nm.nodes[nm.id].transform;
            nm.speed = speed;

            nm.Player.transform.LookAt(nm.transformer);
            if (stop)
            {
                
            }
            else { }
        }
    }


}
