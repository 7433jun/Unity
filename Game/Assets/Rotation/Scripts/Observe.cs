using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observe : MonoBehaviour
{
    public GameObject target;

    public void EarthObservation()
    {
        StartCoroutine(LookCorutine());
    }

    public IEnumerator LookCorutine()
    {
        transform.LookAt(target.transform);

        yield return new WaitForSeconds(1f);

        transform.rotation = Quaternion.Euler(15f, 90f, 0);
    }
}
