using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateScript : MonoBehaviour {

    public Rigidbody prefab;
    public Transform target;
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(prefab,target.position,target.rotation);
        }
	}
}
