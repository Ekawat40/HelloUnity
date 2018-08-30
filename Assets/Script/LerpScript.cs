using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpScript : MonoBehaviour {

    private Vector3 newPosition;
	// Use this for initialization
	void Start () {
        newPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        positionChange();
	}

    void positionChange()
    {
        //สร้างตำแหน่งข้นมาสองค่า
        Vector3 a = new Vector3(-5, 3, 0);
        Vector3 b = new Vector3(5, 3, 0);

        if (Input.GetKeyDown(KeyCode.A))
        {
            newPosition = a;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            newPosition = b;
        }

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime); //เปลี่ยนตำแหน่งObject
    }

}
