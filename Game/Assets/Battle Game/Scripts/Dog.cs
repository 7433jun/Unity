using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Units
{
    bool isWalk = true;
    Collider otherCollider;
    
    void Start()
    {
        hp = 50;
        attack = 10;
        speed = 1.0f;
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
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    void Attack()
    {
        if(otherCollider == null)
        {
            animator.SetTrigger("Walk");
            isWalk = true;
            return;
        }

        otherCollider.gameObject.GetComponent<Turtle>().GetDamaged(attack);
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
        otherCollider = null;
        animator.SetTrigger("Walk");
        isWalk = true;
    }
}
