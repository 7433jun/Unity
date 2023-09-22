using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Units
{
    bool isWalk = true;
    Collider otherCollider;
    
    void Start()
    {
        hp = 100;
        attack = 10;
        speed = 1.0f;
    }

    void Update()
    {
        if (isWalk)
        {
            Walk();
        }
    }

    void Walk()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    void Attack()
    {
        otherCollider.gameObject.GetComponent<Turtle>().GetDamaged(attack);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            otherCollider = other;
            Debug.Log("Enemy√Êµπ");
            isWalk = false;
            animator.SetTrigger("Attack");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetTrigger("Walk");
        isWalk = true;
    }
}
