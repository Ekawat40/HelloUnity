using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatement : MonoBehaviour {

    public int number = 10;

	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            addFunction();
        }
	}

    void addFunction()
    {
        /* if (number == 10)
         {
             print("Number = " + 10);
         } else if (number>=10)
         {
             print("OK");
         }
         else
         {
             print("Not Found");
         }*/

        if (number == 10)
        {
            print("Number = " + 10);
        }
        if (number >= 10)
        {
            print("OK");
        }
    }
}
