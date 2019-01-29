using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSnapping : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SnapObject();
	}

    void SnapObject()
    {
        var currentPos = transform.position;
        transform.position = new Vector3(Mathf.Round(currentPos.x),
                                     Mathf.Round(currentPos.y),
                                     Mathf.Round(currentPos.z));
    } 
}
