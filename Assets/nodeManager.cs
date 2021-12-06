using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodeManager : MonoBehaviour
{
    public List<GameObject> nodes;

    public float speed = 5.0f;
    public int id = 0;

    public Transform transformer;
    public void Start() {
        transformer = nodes[id].transform;
    }
    public GameObject Player;


    public void Update()
    {
        Vector3 direction = Player.transform.position - transformer.position;
        Player.transform.position += Vector3.Normalize(-direction) * Time.deltaTime * speed;

        
    }


    
}
