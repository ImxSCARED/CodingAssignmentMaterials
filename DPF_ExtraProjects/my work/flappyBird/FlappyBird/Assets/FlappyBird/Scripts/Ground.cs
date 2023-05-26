using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //update ground posistion
        transform.position = transform.position - (Vector3.right * speed * Time.deltaTime);

        //if far left
        if (transform.position.x <= -3.84f)
        {
            //move far right
            transform.position = transform.position + (Vector3.right * 3.84f * 2);
        }
        
    }
}
