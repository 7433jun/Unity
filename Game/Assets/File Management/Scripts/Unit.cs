using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    [SerializeField] protected new string name;
    [SerializeField] protected int health;
    [SerializeField] protected int attack;

    protected List<Dictionary<string, object>> data;

    protected abstract void Movement();

    public abstract void Initialize(string fileName, int count);

    void Update()
    {
        Movement();

    }
}
