using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakME : MonoBehaviour
{
    public GameObject Cube;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
     
          GameObject cone= Instantiate(Cube, new Vector3(Cube.transform.position.x * 2.0F, 0, 0), Quaternion.identity);
        Destroy(cone, 0.2f);
    }
}
