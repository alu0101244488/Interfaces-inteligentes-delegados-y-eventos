using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePropeties : MonoBehaviour
{
    public distanceTriggerEvent propertyChange;
    // Start is called before the first frame update
    void Start()
    {
        propertyChange.EventoTrigger += colorChange;
    }

    void colorChange() {
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
