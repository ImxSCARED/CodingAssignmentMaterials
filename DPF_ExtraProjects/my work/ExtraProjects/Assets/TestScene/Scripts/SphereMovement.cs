using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 3);
        }
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 3);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * -3);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * -3);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 3);
        }
    }
}
