using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakME : MonoBehaviour
{
    public GameObject Cube;

    void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(Cube, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }
}
