using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] List<GameObject> gameObjects;

    public void CreateDog()
    {
        Instantiate(gameObjects[0], new Vector3(-10, 0, 0), gameObjects[0].transform.rotation);
    }

    public void CreateTurtle()
    {
        Instantiate(gameObjects[1], new Vector3(10, 0, 0), gameObjects[1].transform.rotation);
    }
}
