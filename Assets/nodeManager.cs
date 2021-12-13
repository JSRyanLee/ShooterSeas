using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodeManager : MonoBehaviour
{
    public List<GameObject> nodes;
    Vector3 direction = new Vector3(0, 0, 0);
    public float speed = 5.0f;
    public int id = 0;
    public Quaternion rotation; 
    public Transform transformer;
    public void Start() {
        transformer = nodes[id].transform;
    }
    public GameObject Player;


    public void FixedUpdate()
    {
        Player.transform.rotation = Quaternion.Slerp(rotation, Quaternion.LookRotation(-direction), 0.1f); //camera movement test ting 
    }

    public void Update()
    {
        direction = Player.transform.position - transformer.position; // camera stuff 
        Player.transform.position += Vector3.Normalize(-direction) * Time.deltaTime * speed; // move stuff




 //stupid lol
        
        //Interpolate Rotation
        Player.transform.rotation = Quaternion.Slerp(Player.transform.rotation, transformer.rotation, Time.deltaTime * 0.1f);




        //Player.transform.rotation = Quaternion.Slerp(rotation, Quaternion.LookRotation(-direction), 0.1f);


    }


    
}
