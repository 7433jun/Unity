using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] float speed = 1f;
    [SerializeField] new Rigidbody rigidbody;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(direction * speed, ForceMode.Acceleration);
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");
    }
}
