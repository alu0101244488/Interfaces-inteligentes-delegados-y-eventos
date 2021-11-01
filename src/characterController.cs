using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float movementSpeed = 10;
    public float rotationSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float translationVerticalAxis = Input.GetAxis("Vertical");
        float translationHorizontalAxis = Input.GetAxis("Horizontal");
        float rotation = Input.GetAxis("Mouse X");

        transform.position += transform.forward * translationVerticalAxis * movementSpeed * Time.deltaTime;
        transform.position += transform.right * translationHorizontalAxis * movementSpeed * Time.deltaTime;
        transform.Rotate(0, rotation * Time.deltaTime * rotationSpeed, 0);
    }
}
