using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour{
    private bool moved = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("x")&&!moved)
        {
            moved = true;
            Vector3 newpos = new Vector3(2.32f, 1.0f, -2.16f);
            gameObject.transform.position = newpos;
            gameObject.transform.Rotate(Vector3.up * 90);
        }
	}
}
