using Oculus.Haptics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using System;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEngine.XR.OpenXR.Input;


public class OnPet : MonoBehaviour
{
    public GameObject Hand;

    public HapticClip Pet1;
    public HapticClip Pet2;
    HapticClipPlayer HapticPlayer1;
    HapticClipPlayer HapticPlayer2;


    // Start is called before the first frame update
    protected virtual void Start()
    {
        HapticPlayer1 = new HapticClipPlayer(Pet1);
        HapticPlayer2 = new HapticClipPlayer(Pet2);

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))

        {
            Debug.Log("trigger press");
            HapticPlayer1.Play(Controller.Right);
        }

        }
    protected virtual void OnCollisionEnter(Collision collision)
    {
        Debug.Log("pet");
        HapticPlayer1.Play(Controller.Right);

        
        }


}
