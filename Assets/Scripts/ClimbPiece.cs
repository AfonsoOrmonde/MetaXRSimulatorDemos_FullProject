using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.Locomotion;
using UnityEngine;

public class ClimbPiece : MonoBehaviour
{
    public Color original;
    public Color attachedColor;
    public MeshRenderer rendererMesh;
    public bool handAttachedHere;
    public bool oldColor;

    void Start()
    {
        rendererMesh.material.color = original;
        handAttachedHere = false;
    }
    void Update()
    {
        if (handAttachedHere && oldColor)
        {
            ChangeToAttachedColor();
        }
        else if(!handAttachedHere && !oldColor)
        {
            ChangeToOriginalColor();
        }
    }
    public void ChangeToOriginalColor()
    {
        rendererMesh.material.color = original;
        oldColor = true;
    }
    public void ChangeToAttachedColor()
    {
        rendererMesh.material.color = attachedColor;
        oldColor = false;
    }
    public void setAttached(bool status)
    {
        handAttachedHere = status;
    }
}
