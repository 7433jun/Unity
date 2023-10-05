using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;

    void Update()
    {
        float distance = Input.GetAxisRaw("Mouse ScrollWheel") * -1 * 10;

        mainCamera.fieldOfView += distance;

        mainCamera.fieldOfView = Mathf.Clamp(mainCamera.fieldOfView, 20f, 60f);
    }
}
