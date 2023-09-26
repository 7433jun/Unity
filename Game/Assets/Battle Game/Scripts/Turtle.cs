using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : Units
{
    void Start()
    {
        hp = 30;
        attack = 5;
        speed = 0.5f;
        maxhp = hp;
        hpBar = GetComponent<HPBar>();

        isWalk = true;
    }

    public override void Walk()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (otherCollider != null)
            {
                return;
            }

            otherCollider = other;
            Debug.Log("Player√Êµπ");
            isWalk = false;
            animator.SetTrigger("Attack");
        }
    }


}
