using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction.Locomotion;
using System;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody World;
    public HandClimb leftHand;
    public HandClimb rightHand;
    public Vector3 lastPositionL;
    public Vector3 lastPositionR;
    public GameObject handTrackingSpace;
    public FirstPersonLocomotor playerController;
    float gravityBefore;
    // Start is called before the first frame update
    void Start()
    {
        gravityBefore = playerController.GravityFactor;
        lastPositionL = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        lastPositionR = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
    }

    // Update is called once per frame
    void Update()
    {
        if (leftHand.isAttached)
        {
            playerController.GravityFactor = 0f;
            if (CheckForMeaningfulMovement(true))
            {
                World.velocity = handTrackingSpace.transform.TransformVector(OVRInput.GetLocalControllerVelocity(OVRInput.Controller.LTouch));
                lastPositionL = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
            }
            else
            {
                World.velocity = new Vector3(0,0,0);
                lastPositionL = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
            }
        }
        else if (rightHand.isAttached)
        {
            playerController.GravityFactor = 0f;
            if (CheckForMeaningfulMovement(false))
            {
                World.velocity = handTrackingSpace.transform.TransformVector(OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch));
                lastPositionR = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
            }
            else
            {
                World.velocity = new Vector3(0,0,0);
                lastPositionR = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
            }
        }
        else
        {
            playerController.GravityFactor = gravityBefore;
        }
    }
    
    private bool CheckForMeaningfulMovement(bool LController)
    {
        if (LController)
        {
            if (Math.Abs(Vector3.Distance(lastPositionL, OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch))) >= 0.0015)
            {
                return true;
            }
        }
        else
        {
            if (Math.Abs(Vector3.Distance(lastPositionR, OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch))) >= 0.0015)
                return true;
        }
        return false;
        
    }

}
