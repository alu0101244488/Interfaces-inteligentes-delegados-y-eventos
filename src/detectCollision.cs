using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void executeEvent();

public class detectCollision : MonoBehaviour
{

    public event executeEvent Evento;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision) {
        Evento();
    }
}
