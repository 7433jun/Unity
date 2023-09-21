using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Units
{
    
    void Start()
    {
        hp = 100;
        attack = 10;
        speed = 1.0f;
    }

    void Update()
    {
        
    }

    void Walk()
    {
        rigidbody.AddForce(Vector3.right * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ãæµ¹");
    }
}
