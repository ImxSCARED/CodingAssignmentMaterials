using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TankController : MonoBehaviour
{
    [Header("Movement")]
    public float forwardSpeed = 0.1f;
    public float backwardSpeed = 0.08f;
    public float rotationalSpeed = 2f;

    [Header("TurretRotation")]
    public float turretRotationalSpeed = 3f;

    //reference to the object
    public GameObject turret;
    [Header("Shell")]
    public float shellSpeed = 20;
    public GameObject ShellPrefab;
    public Transform shellSpawnPoint;


    [Header("Player one Controls")]
    public KeyCode forwardsKey = KeyCode.W;
    public KeyCode backwardsKey = KeyCode.S;
    public KeyCode rotateLeftKey = KeyCode.A;
    public KeyCode RotateRightkey = KeyCode.D;
    public KeyCode rotateTurretLeftKey = KeyCode.Q;
    public KeyCode rotateturretRightKey = KeyCode.E;
    public KeyCode fireKey = KeyCode.Space;

    [Header("Health")]
    public int health = 100;

    public TMP_Text Health;



    
    //custom function
    public void TakeDamage(int damageTotake)
    {
        health = health - damageTotake;
    }
    // Update is called once per frame
    void Update()
    {
        {
        
        Health.text = "Health:" +health;
        }
        if (health <= 0)
        {
            
            //leave function when health is equal to zero
            return;

        }
        if (Input.GetKeyDown(fireKey))
        {
            GameObject GO = Instantiate(ShellPrefab, shellSpawnPoint.position, Quaternion.identity) as GameObject;
            GO.GetComponent<Rigidbody>().AddForce(turret.transform.forward * shellSpeed, ForceMode.Impulse);
        }
        
    }
     void FixedUpdate()
    {
        if (Input.GetKey(rotateTurretLeftKey))
        {
            turret.transform.Rotate(0, -turretRotationalSpeed, 0, Space.Self);
        }
        if (Input.GetKey(rotateturretRightKey))
        {
            turret.transform.Rotate(0, turretRotationalSpeed, 0, Space.Self);
        }
        if (Input.GetKey(forwardsKey))
        {
            transform.position = transform.position + transform.forward * forwardSpeed;
        }
        if (Input.GetKey(backwardsKey))
        {
            transform.position = transform.position + transform.forward * -backwardSpeed;
        }
        if (Input.GetKey(rotateLeftKey))
        {
            transform.Rotate(transform.up * -rotationalSpeed);
        }
        if (Input.GetKey(RotateRightkey))
        {
            transform.Rotate(transform.up * rotationalSpeed);
        }
    }
}
