using UnityEngine;
using System.Collections;

public class Done_Explosion : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}
		Instantiate(explosion, other.transform.position, other.transform.rotation);
		/*if (other.tag == "Player")
		{
			Instantiate(playerExplosion, transform.position, transform.rotation);
	//		gameController.gameOver ();
		}*/
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}