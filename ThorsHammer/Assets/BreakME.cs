using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakME : MonoBehaviour
{
    public GameObject Cube;

    void OnCollisionEnter(Collision collision)
    {
        
     
            Instantiate(Cube, new Vector3(Cube.transform.position.x * 2.0F, 0, 0), Quaternion.identity);
        
    }
}
