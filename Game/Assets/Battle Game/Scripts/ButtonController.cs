using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] List<GameObject> gameObjects;
    [SerializeField] List<Transform> transforms;

    public void CreateDog()
    {
        Instantiate(gameObjects[0], transforms[0].position, gameObjects[0].transform.rotation);
    }

    public void CreateTurtle()
    {
        Instantiate(gameObjects[1], transforms[1].position, gameObjects[1].transform.rotation);
    }
}
