using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    static public ObjectPoolManager instance;

    [SerializeField] GameObject bulletPrefab;

    Queue<GameObject> bulletQueue = new Queue<GameObject>();

    [SerializeField] int bulletCount = 20;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }

    void Start()
    {
        for(int i = 0; i < bulletCount; i++)
        {
            bulletQueue.Enqueue(Instantiate(bulletPrefab));
        }

        foreach(var e in bulletQueue)
        {
            e.SetActive(false);
        }
    }

    public void InsertQueue(GameObject bullet)
    {
        bulletQueue.Enqueue(bullet);
        bullet.SetActive(false);
    }

    public GameObject GetQueue(Vector3 createPosition)
    {
        GameObject bullet = bulletQueue.Dequeue();
        bullet.SetActive(true);
        bullet.transform.position = createPosition;

        return bullet;
    }
}
