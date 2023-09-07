using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoateX : MonoBehaviour
{
    [Range(-50, 50)]
    [SerializeField] protected float speed = 1.0f;
    BoxCollider boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        boxCollider.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }
}
