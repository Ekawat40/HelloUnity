using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvent : MonoBehaviour {

    public float forceSpeed = 300;
    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(-transform.forward * forceSpeed);
        GetComponent<Rigidbody>().useGravity = true;
    }
}
