using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private int random;

    void Start()
    {
        random = Random.Range(0, 5);
        Debug.Log(random);
        Destroy(gameObject, random);
    }
}
