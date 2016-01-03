using UnityEngine;
using System.Collections;

public class DestroybyContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;


	void OnTriggerEnter(Collider other) 
	{
		Debug.Log ("OnTriggerEnterDestroybyContact");
		if (other.tag == "Boundary")
		{
			Debug.Log ("OnTriggerEnterBoundary");
		}

		Debug.Log (other.tag);
		if (other.tag == "Player")
		{
			Debug.Log ("OnTriggerEnterplayer");
			Instantiate(explosion, transform.position, transform.rotation);
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
		if (other.tag == "Bold")
		{
			Debug.Log ("OnTriggerEnterplayer");
			Instantiate(explosion, transform.position, transform.rotation);
			Instantiate (explosion, other.transform.position, other.transform.rotation);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
}