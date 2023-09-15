using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    [SerializeField] List<BronzeUnit> bronzeUnit;


    void Awake()
    {

    }

    void Start()
    {
        for(int i = 0;i < bronzeUnit.Count; i++)
        {
            bronzeUnit[i].Initialize("Bronze Unit", i);
        }
    }
}
