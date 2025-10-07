using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction.Locomotion;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody World;
    public HandClimb leftHand;
    public HandClimb rightHand;
    public FirstPersonLocomotor playerController;
    float gravityBefore;
    // Start is called before the first frame update
    void Start()
    {
        gravityBefore = playerController.GravityFactor;
    }

    // Update is called once per frame
    void Update()
    {
        if (leftHand.isAttached)
        {
            playerController.GravityFactor = 0f;
            World.velocity = OVRInput.GetLocalControllerVelocity
            (OVRInput.Controller.LTouch);
        }
        else if (rightHand.isAttached)
        {
            playerController.GravityFactor = 0f;
            World.velocity = OVRInput.GetLocalControllerVelocity
            (OVRInput.Controller.RTouch); ;
        }
        else
        {
            playerController.GravityFactor = gravityBefore;
        }
    }
}
