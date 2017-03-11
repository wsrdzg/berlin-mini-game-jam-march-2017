using UnityEngine;

public class Ball : MonoBehaviour {

	public void Respawn() {
		Rigidbody rigdbody = GetComponent<Rigidbody>();
		rigdbody.velocity = Vector3.zero;
		rigdbody.angularVelocity = Vector3.zero;
		transform.position = Vector3.up * 5;
	}
}