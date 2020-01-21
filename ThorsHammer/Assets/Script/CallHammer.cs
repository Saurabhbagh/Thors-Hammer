using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.XR;
public class CallHammer : MonoBehaviour
{
    public GameObject hammer;
    // Adjust the speed for the application.
    public float speed = 10.0f;

    public GameObject cube;
    public GameObject LeftHand;
    public GameObject RightHand;
    //public SteamVR_Action_Vibration HapticAction;
    public float duration= 0.01f;

    public float frequency = 200;
    public float amplitude = 1;

    // for audio 
    public AudioClip thunder;
    private AudioSource audio;
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();

    }
    void Update()
    {
        if (SteamVR_Actions._default.GrabPinch.GetState(SteamVR_Input_Sources.Any))
        {
            audio.enabled = true;
            if (!audio.isPlaying)
            {
                audio.clip = thunder;
                audio.Play();
                GameObject.Find("Lightingeffect").transform.GetChild(0).gameObject.SetActive(true);

            }
        }
        else
        {
            if (audio.isPlaying)
            {
                 audio.Stop();
                GameObject.Find("Lightingeffect").transform.GetChild(0).gameObject.SetActive(false);

            }
        }

        
        if (SteamVR_Actions._default.GrabGrip.GetState(SteamVR_Input_Sources.LeftHand))  // for any state it works !!
        {
            ComeToMe("left", LeftHand);
            hammer.GetComponent<Rigidbody>().useGravity = false;
           
            //HapticAction.Execute(0, duration, frequency, amplitude, SteamVR_Input_Sources.LeftHand);


        }
        else
        {
            //hammer.GetComponent<Rigidbody>().isKinematic = false;
            hammer.GetComponent<Rigidbody>().useGravity = true;
        }


        if (SteamVR_Actions._default.GrabGrip.GetState(SteamVR_Input_Sources.RightHand))  // for any state it works !!
        {
            //HapticAction.Execute(0, duration, frequency, amplitude, SteamVR_Input_Sources.RightHand);
            ComeToMe("Right", RightHand);
            hammer.GetComponent<Rigidbody>().useGravity = false;
            //Debug.Log("Controller Position: " + RightHand.transform.position);

        }
        else
        {
            //hammer.GetComponent<Rigidbody>().isKinematic = false;
            hammer.GetComponent<Rigidbody>().useGravity = true;
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
