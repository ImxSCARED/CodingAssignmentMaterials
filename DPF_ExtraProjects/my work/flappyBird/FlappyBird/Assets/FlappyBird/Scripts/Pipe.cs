using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Pipe : MonoBehaviour
{
    public float speed = 1.5f;
    private int score = 0;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        // Every frame we look at the position of the ground and move it left ever so 
        transform.position = transform.position - (Vector3.right * speed * Time.deltaTime);
        // If the position of the ground is off the left of the screen....
        if (transform.position.x <= -2.3f)
        {
            // Move it to the far right of the screen
            transform.position = transform.position + (new Vector3(2.3f * 2, 0, 0));
            transform.position = new Vector3(transform.position.x, Random.Range(-2.5f, -1), 0);
            if (GameObject.Find("Text"))
            {
                GameObject.Find("Text").GetComponent<Text>().text = (++score).ToString();
            }
        }
    }
}