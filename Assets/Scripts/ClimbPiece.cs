using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbPiece : MonoBehaviour
{
    public Color original;
    public Color attachedColor;
    public MeshRenderer rendererMesh;

    void Start()
    {
        rendererMesh.material.color = original;
    }
    public void ChangeToOriginalColor()
    {
         rendererMesh.material.color = original;
    }
    public void ChangeToAttachedColor()
    {
         rendererMesh.material.color = attachedColor;
    }
}
