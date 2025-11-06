using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkyboxChange : MonoBehaviour
{
    public Material skybox;
    private Mountain moutain;
    private void Start()
    {
        moutain = FindAnyObjectByType<Mountain>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(LayerMask.LayerToName(other.gameObject.layer) == "HandCollider")
        {
            moutain.ChangeSkyBox(skybox);
        }
    }
}
