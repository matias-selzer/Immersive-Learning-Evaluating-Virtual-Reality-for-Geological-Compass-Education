using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public Transform cameraTarget;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(2*transform.position-cameraTarget.position);
        Vector3 euler = transform.rotation.eulerAngles;
        //euler.x = 0;
        //euler.z = 0;
        transform.rotation = Quaternion.Euler(euler);
	}
}
