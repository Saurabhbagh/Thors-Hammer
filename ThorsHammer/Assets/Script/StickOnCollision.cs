using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickOnCollision : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Collion Object:" + collision.gameObject.name);
    }
}
