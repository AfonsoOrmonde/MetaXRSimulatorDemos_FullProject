using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class HandClimb : MonoBehaviour
{
    public bool InContact;
    public bool isAttached;
    public Vector3 lastposition;
    public bool isMoving = false;
    public ClimbPiece pieceGrabbed;
    void Start()
    {
        InContact = false;
        isAttached = false;
    }
    void Update()
    {

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
            pieceGrabbed.setAttached(isAttached);
        }
    }
    public void Attach()
    {
        Debug.Log("Getting Attached");
        if (InContact && !isAttached)
        {
            isAttached = true;
            pieceGrabbed.setAttached(isAttached);

        }
    }
    public void Dettach()
    {
        Debug.Log("Dettaching");
        if (isAttached)
        {
            isAttached = false;
            pieceGrabbed.setAttached(isAttached);
        }
    }
}
