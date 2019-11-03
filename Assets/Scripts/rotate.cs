using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
	public Transform cube;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.touchCount == 1)
		{
			// GET TOUCH 0
			Touch touch0 = Input.GetTouch(0);

			// APPLY ROTATION
			if (touch0.phase == TouchPhase.Moved)
			{
				cube.transform.Rotate(0f, touch0.deltaPosition.x, 0f);
			}

		}
	}
}
