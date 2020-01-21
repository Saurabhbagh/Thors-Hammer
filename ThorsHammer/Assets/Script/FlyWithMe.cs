using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.XR;

public class FlyWithMe : MonoBehaviour
{

    public GameObject ObjectToFly;
    public GameObject LeftHand;
    public GameObject RightHand;
    public GameObject Player;
    public GameObject Head;
    public float acceleration;
    
    // Update is called once per frame
    void Update()
    {

        float distance1 = Vector3.Distance(ObjectToFly.transform.position, LeftHand.transform.position);
        float distance2 = Vector3.Distance(ObjectToFly.transform.position, RightHand.transform.position);
        //Debug.Log("distance 1: "+ distance1);
        //Debug.Log("distance 2: " + distance2);
        if (SteamVR_Actions._default.GrabPinch.GetState(SteamVR_Input_Sources.LeftHand) && SteamVR_Actions._default.GrabPinch.GetState(SteamVR_Input_Sources.RightHand))
        {
            Debug.Log("Now i will fly");
            Vector3 flydistance1 = LeftHand.transform.position - Head.transform.position;
            Vector3 flydistance2 = RightHand.transform.position - Head.transform.position;
            Vector3 newDistance = flydistance1 + flydistance2;
            //Debug.Log(newDistance);
            //Debug.Log("Head Position:: "+Head.transform.position);
            Player.transform.position += newDistance;
           

        // Collison with plain 

        if(Player.transform.position.y< -0.59f)
            {

                Player.transform.position = new Vector3(Player.transform.position.x, -0.59f, Player.transform.position.z);
            }

        }
    }



}
