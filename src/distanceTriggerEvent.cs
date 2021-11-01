using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void distanceTrigger();

public class distanceTriggerEvent : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sceneObject;
    public float threshold = 2f;
    public event distanceTrigger EventoTrigger;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(sceneObject.transform.position, transform.position);
        if(distance < threshold) {
            EventoTrigger();
        }
    }
}
