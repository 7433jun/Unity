using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Units
{
    void Start()
    {
        hp = 50;
        attack = 10;
        speed = 1.0f;
        maxhp = hp;
        hpBar = GetComponent<HPBar>();

        isWalk = true;
    }

    public override void Walk()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
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
}
