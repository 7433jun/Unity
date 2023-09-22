using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : Units
{
    bool isWalk = true;
    Collider otherCollider;

    void Start()
    {
        hp = 30;
        attack = 5;
        speed = 0.5f;
    }

    void Update()
    {
        if (isWalk)
        {
            Walk();
        }

        if (hp <= 0)
        {
            DieAnimation();
        }
    }

    void Walk()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    void Attack()
    {
        if (otherCollider == null)
        {
            animator.SetTrigger("Walk");
            isWalk = true;
            return;
        }

        otherCollider.gameObject.GetComponent<Dog>().GetDamaged(attack);
    }

    public void GetDamaged(int damage)
    {
        hp -= damage;
    }

    public void DieAnimation()
    {
        animator.SetTrigger("Die");
        Invoke("Die", 3f);
    }

    public void Die()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            otherCollider = other;
            Debug.Log("Player√Êµπ");
            isWalk = false;
            animator.SetTrigger("Attack");
        }
    }


}
