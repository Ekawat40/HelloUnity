using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour {
    bool status = false;
	// Use this for initialization
	void Start () {
        int i;
        for( i = 0; i < 10; i++)
        {
            print("i= " + i);
        }
	}

}
