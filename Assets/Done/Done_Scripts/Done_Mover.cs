using UnityEngine;
using System.Collections;

public class Done_Mover : MonoBehaviour
{
	public float speed;
	private float startY;

	void Start ()
	{
		startY = rigidbody.position.y;
		rigidbody.velocity = transform.forward * speed;
	}
	void Update() {
		rigidbody.position = new Vector3 (rigidbody.position.x,startY, rigidbody.position.z);
	}
}
