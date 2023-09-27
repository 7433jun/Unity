using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorControl : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        animator.SetFloat("Horizontal", x);
        animator.SetFloat("Vertical", z);

        gameObject.transform.position += new Vector3(x, 0, z) * Time.deltaTime;
    }
}
