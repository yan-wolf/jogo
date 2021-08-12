using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{

   
    public float vel = 10;
    public Transform explosionPrefab;
    public CharacterController p1;

    void Start()
    {



    }


    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        p1.Move(move * vel * Time.deltaTime);

    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("redd"))
        {
            explosionPrefab.position = new Vector3(Random.Range(-40.0f, 40.0f), 0, Random.Range(-40.0f, 40.0f));
        }
    }
}