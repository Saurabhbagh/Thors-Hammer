using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.XR;

public class WooshSound : MonoBehaviour
{

    // for audio 
    public AudioClip woosh;
    private AudioSource wooshaudio;
    // Start is called before the first frame update
    void Start()
    {
        wooshaudio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("space"))
        {
            wooshaudio.enabled = true;
            if (!wooshaudio.isPlaying)
            {
                wooshaudio.clip = woosh;
                //wooshaudio.time = 1.0f;
                wooshaudio.Play();

               
            }
        }
        else
        {
            if (wooshaudio.isPlaying)
            {
                wooshaudio.Stop();


            }
        }


        if(SteamVR_Actions._default.GrabGrip.GetState(SteamVR_Input_Sources.Any))
        {
            wooshaudio.enabled = true;
            if (!wooshaudio.isPlaying)
            {
                wooshaudio.clip = woosh;
                wooshaudio.time = 1.0f;
                wooshaudio.Play();


            }
        }
        else
        {
            if (wooshaudio.isPlaying)
            {
                wooshaudio.Stop();


            }
        }

    }
}
