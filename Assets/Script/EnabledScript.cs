using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledScript : MonoBehaviour {

    private Light myLight;
	// Use this for initialization
	void Start () {

        myLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
	}
}
