using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class HandClimb : MonoBehaviour
{
    public bool InContact;
    public bool isAttached;
    public Vector3 lastposition;

    public ClimbPiece pieceGrabbed;
    void Start()
    {
        InContact = false;
        isAttached = false;
    }
    void Update()
    {
        if (isAttached)
        {
            lastposition = this.transform.position;
            this.transform.position = pieceGrabbed.transform.position;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Climber")
        {
            InContact = true;
            pieceGrabbed = other.GetComponent<ClimbPiece>();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Climber")
        {
            InContact = false;
            isAttached = false;
        }
    }
    public void Attach()
    {
        Debug.Log("Getting Attached");
        if (InContact)
            isAttached = true;
    }
}
