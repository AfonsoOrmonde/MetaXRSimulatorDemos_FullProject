using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public bool active;
    public GameObject rig;
    public float distanceFromRig = 2f;

    void Start()
    {
        //this.GetComponent<Renderer>().enabled = active;
    }
    public void MakeUIApperDisappear()
    {
       /* if (active)
        {
            this.GetComponent<Renderer>().enabled = false;
        }
        else
        {
            Vector3 newPos = rig.transform.position + rig.transform.forward * distanceFromRig;
            transform.position = newPos;

            // Face toward the same direction as the rig
            transform.rotation = Quaternion.LookRotation(rig.transform.forward, Vector3.up);

        }
        active = !active;*/
    }
}
