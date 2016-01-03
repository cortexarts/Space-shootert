using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour 
{
	public float speed; 
	void start ()
	{
				rigidbody.velocity = transform.forward * speed;

		}
}
