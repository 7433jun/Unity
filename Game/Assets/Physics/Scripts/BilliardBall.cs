using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardBall : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] float speed = 1.0f;
    [SerializeField] new Rigidbody rigidbody;

    void FixedUpdate()
    {
        rigidbody.AddForce(direction * speed, ForceMode.Acceleration);
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pillar"))
        {
            var result = Vector3.Reflect(transform.position.normalized, collision.contacts[0].normal);

            rigidbody.velocity = result * Mathf.Max(speed, 0f);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Billiard Ball"))
        {
            rigidbody.AddTorque(Vector3.up * speed, ForceMode.Impulse);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pillar"))
        {
            int randomMode = Random.Range(0, 3);
            rigidbody.interpolation = (RigidbodyInterpolation)randomMode;
        }
    }
}
