using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseForce : MonoBehaviour
{
    GameObject collisionObject;
    public detectCollision collision;


    // Start is called before the first frame update
    void Start()
    {
        collision.Evento += increaseMass;
    }

    // Update is called once per frame

    void increaseMass() {
        GetComponent<Rigidbody>().mass += 100;
    }
    void Update()
    {
        
    }
}
