using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3D : MonoBehaviour {

    Vector3 velocity;
    Vector3 direction = Vector3.zero;
    Vector3 currentVelocity;

    public float acceleration = 50;
    public float maxSpeed     = 10;
    public Transform explosionPrefab;
    
    void Start()
    {



    }


    void Update()
    {

        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        direction = new Vector3(horizontalInput, 0, verticalInput).normalized;


        velocity = Vector3.SmoothDamp(velocity, direction * maxSpeed, ref currentVelocity, maxSpeed / acceleration);


        transform.position += velocity * Time.deltaTime;

    }

    void OnCollisionEnter(Collision other)
    {
       

        if (other.gameObject.CompareTag("redd"))
        {
            explosionPrefab.position = new Vector3(Random.Range(-40.0f, 40.0f), 0, Random.Range(-40.0f, 40.0f));
        }
    }
 }