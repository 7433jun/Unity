using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsManager : MonoBehaviour
{
    private Ray ray;
    private RaycastHit raycastHit;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetButtonDown("Fire1"))
        {
            if(Physics.Raycast(ray, out raycastHit, Mathf.Infinity))
            {
                if(raycastHit.collider.CompareTag("Billiard Ball"))
                {
                    raycastHit.collider.GetComponent<Rigidbody>().Sleep();
                }
            }
        }
    }
}
