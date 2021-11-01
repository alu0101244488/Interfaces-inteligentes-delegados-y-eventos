using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereOrientation : MonoBehaviour
{
    public distanceTriggerEvent propertyChange;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        propertyChange.EventoTrigger += followPlayer;
    }

    void followPlayer() {
        transform.LookAt(target.transform);
        Vector3 direction = (target.transform.position - transform.position).normalized;
        float distance = Vector3.Distance(transform.position, target.transform.position);
        Debug.DrawRay(transform.position, direction * distance, Color.red, Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
