using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class node : MonoBehaviour
{


    public bool stop = false;

    public nodeManager nm;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            nm.id++;
            nm.transformer = nm.nodes[nm.id].transform;
            if (stop)
            {
                
            }
            else { }
        }
    }


}
