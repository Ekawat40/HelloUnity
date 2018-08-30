using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour {

    int count = 10;

	// Use this for initialization
	void Start () {
        while (count > 0)
        {
            Debug.Log("Ekawat");
            count--;
        }
	}
	

}
