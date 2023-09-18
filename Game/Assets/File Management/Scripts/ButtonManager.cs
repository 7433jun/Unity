using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] public List<GameObject> monster;

    void Awake()
    {
        ActiveMonster();
        DontDestroyOnLoad(gameObject);
    }

    public void ActiveMonster(int number = 0)
    {
        foreach (var e in monster)
        {
            e.SetActive(false);
        }

        monster[number].SetActive(true);
    }
}
