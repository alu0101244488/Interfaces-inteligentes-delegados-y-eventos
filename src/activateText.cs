using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activateText : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject collisionObject;
    public detectCollision collision;

    void Start()
    {
        collision.Evento += WriteText;
    }

    void WriteText() {
        GetComponent<Text>().text = "Colision detectada";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
