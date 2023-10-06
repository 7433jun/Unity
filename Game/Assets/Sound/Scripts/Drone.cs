using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public float speed = 55;
    public Vector3 direction;

    void Start()
    {
        direction = transform.position;

        // 실행시킬 함수, 몇초후 실행, 몇초후 반복
        InvokeRepeating("NewPosition", 5, 5);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void NewPosition()
    {
        transform.position = direction;
        transform.Find("Canvas").gameObject.SetActive(false);
    }
}
