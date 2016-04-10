using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour 
{
	public float speed; 
	void FixedUpdate  () {
				//rigidbody.velocity = transform.forward * speed;
		rigidbody.position = new Vector3 
			(
				rigidbody.position.x, 
				0.0f, 
				rigidbody.position.z - (speed / 100.0f)
			);

	}
}
