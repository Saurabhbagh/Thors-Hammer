using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.XR;
public class CallHammer : MonoBehaviour
{
    public GameObject hammer;
    // Adjust the speed for the application.
    public float speed = 1.0f;

    public GameObject cube;
    public GameObject LeftHand;
    public GameObject RightHand;

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        


    }


     void Update()
    {
        //Debug.Log("Left Controller Position: " + LeftHand.transform.position);
        //Debug.Log("Right Controller Position: " + RightHand.transform.position);
        //Debug.Log("Hammer Position: " + hammer.transform.position);
        if (SteamVR_Actions._default.GrabGrip.GetState(SteamVR_Input_Sources.LeftHand))  // for any state it works !!
        {
            ComeToMe("left", LeftHand);
            //Debug.Log("Hammer Position: "+hammer.transform.position);
            //Debug.Log("Controller Position: " + LeftHand.transform.position);

        }

        if (SteamVR_Actions._default.GrabGrip.GetState(SteamVR_Input_Sources.RightHand))  // for any state it works !!
        {

            ComeToMe("Right", RightHand);
            //Debug.Log("Hammer Position: " + hammer.transform.position);
            //Debug.Log("Controller Position: " + RightHand.transform.position);

        }
    }

    // Update is called once per frame
    void ComeToMe(string HandType , GameObject Hand)
    {

       // Debug.Log(" Going to : " + HandType + "");


        float step = speed * Time.deltaTime; // calculate distance to move
        hammer.transform.position = Vector3.MoveTowards(hammer.transform.position, Hand.transform.position, step);
                
    }

   
}
