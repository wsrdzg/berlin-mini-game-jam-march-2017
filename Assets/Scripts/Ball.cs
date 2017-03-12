using UnityEngine;

public class Ball : MonoBehaviour {

	private Rigidbody _rigidbody;
	private Vector3 _startPosition;
	private Quaternion _startRotation;


	private void Awake() {
		_rigidbody = GetComponent<Rigidbody>();
		_startPosition = transform.position;
		_startRotation = transform.rotation;
	}

	public void Respawn() {
		_rigidbody.velocity = Vector3.zero;
		_rigidbody.angularVelocity = Vector3.zero;
		transform.position = _startPosition;
		transform.rotation = _startRotation;
	}
}