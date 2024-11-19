using Oculus.Haptics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using System;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEngine.XR.OpenXR.Input;
using Oculus.Interaction;

public class HandCollisions : MonoBehaviour
{
    [SerializeField] private GameObject _thisHandModel;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer != 0)
        {
            return;
        }

        //if (collision.collider.transform.GetComponent<GrabInteractable>)
           // return;
       // _thisHandModel.transform.parent = null;
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.layer != 0)
        {
            return;
        }


        _thisHandModel.transform.position = transform.parent.position;
        _thisHandModel.transform.rotation = transform.parent.rotation;
        _thisHandModel.transform.parent = transform.parent;
    }
}