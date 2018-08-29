using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour {

    int number = 10; //เก็บจำนวนเต็ม
    bool status = true;
    string str = "Ekawat";
    double db = 2540.25;
    float f = 15.5f;

	// Use this for initialization
	void Start () {
        Debug.Log("Result: " + number);
        print("Status: " + status);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
