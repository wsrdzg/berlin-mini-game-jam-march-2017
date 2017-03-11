using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour {

	public float _force;

	void OnCollisionEnter(Collision collision) {//void OnTriggerEnter(Collider collider) {
		collision.collider.GetComponent<Rigidbody> ().velocity = new Vector3 ();
		collision.collider.GetComponent<Rigidbody>().AddForce(transform.forward * _force * collider.GetComponent<Rigidbody>().mass, ForceMode.Impulse);
	}
}
