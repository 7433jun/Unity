using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(HPBar))]

public abstract class Units : MonoBehaviour
{
    protected HPBar hpBar;

    [SerializeField] protected int hp;
    [SerializeField] protected int attack;
    [SerializeField] protected float speed;
    [SerializeField] protected Animator animator;

    protected float maxhp;
    protected bool isWalk;
    protected Collider otherCollider;

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

        if (gameObject.transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    public abstract void Walk();

    public void Attack()
    {
        if (otherCollider == null && hp > 0)
        {
            animator.SetTrigger("Walk");
            isWalk = true;
            return;
        }

        otherCollider.gameObject.GetComponent<Units>().GetDamaged(attack);

        if (otherCollider.gameObject.GetComponent<Units>().Hp <= 0)
        {
            otherCollider = null;

            animator.SetTrigger("Walk");
            isWalk = true;
        }


    }

    public void DieAnimation()
    {
        animator.SetTrigger("Die");
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        foreach(var e in gameObject.GetComponents<BoxCollider>())
        {
            e.enabled = false;
        }


        Invoke("Die", 3f);
    }

    public void GetDamaged(int damage)
    {
        hp -= damage;
        hpBar.CurrentHP(hp, maxhp);
    }

    public void Die()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }

    public int Hp
    {
        get { return hp; }
    }
}
