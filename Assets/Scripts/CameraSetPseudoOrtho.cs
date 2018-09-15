using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetPseudoOrtho : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Camera.main.transparencySortMode = TransparencySortMode.Orthographic;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
