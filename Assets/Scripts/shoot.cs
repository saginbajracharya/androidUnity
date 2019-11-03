using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
	public GameObject spawnPoint;
	public GameObject ExplosionPrefab;
	public Rigidbody projectilePrefab;
	public float speed;
	Rigidbody clone;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		for(var i =0; i < Input.touchCount; ++i)
		{
			if(Input.GetTouch(i).phase == TouchPhase.Began )
			{
				clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;
				clone.velocity = transform.TransformDirection(Vector3.forward * speed);
				//            Physics.IgnoreCollision ( projectilePrefab.collider, transform.root.collider );

			}
		}

	}
}