using UnityEngine;

public class Bumper : MonoBehaviour {

	[SerializeField]
	private float _force;


	private void OnCollisionEnter(Collision collision) {
		Rigidbody rigidbody = collision.rigidbody;
		rigidbody.velocity = Vector3.zero;
		rigidbody.AddForce(transform.forward * _force * rigidbody.mass, ForceMode.Impulse);
	}
}