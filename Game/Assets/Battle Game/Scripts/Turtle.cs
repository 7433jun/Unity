using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : Units
{
    bool isWalk = true;

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
    }

    void Walk()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    public void GetDamaged(int damage)
    {
        hp -= damage;
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
            Debug.Log("Player√Êµπ");
            isWalk = false;
        }
    }


}
