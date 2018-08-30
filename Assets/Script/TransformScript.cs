using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScript : MonoBehaviour {


    public int speed=2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // transform.Translate(new Vector3(0, 0, 1)*Time.deltaTime);
        transform.Translate(Vector3.forward*speed* Time.deltaTime);


    }
}
