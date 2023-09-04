using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    public int[] ints;

    void Start()
    {
        for(int i  = 0; i < ints.Length; i++)
        {
            Debug.Log(ints[i]);
        }
    }
}
