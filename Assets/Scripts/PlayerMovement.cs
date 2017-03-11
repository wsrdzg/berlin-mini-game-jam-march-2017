using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private float _moveSpeed;

	[SerializeField]
	private float _dogeSpeed;

	private Rigidbody _rigidbody;
	private Vector2 _inputMovement;
	private bool _inputDoge;
	private Vector2 _inputLook;


	void Awake() {
		_rigidbody = GetComponent<Rigidbody>();
	}

	void Update() {
		_inputMovement = new Vector2(Input.GetAxis("Move Horizontal"), Input.GetAxis("Move Vertical"));
		_inputDoge = Input.GetButton("Jump");
		_inputLook = new Vector2(Input.GetAxis("Look Horizontal"), Input.GetAxis("Look Vertical"));

	}

	void FixedUpdate() {
		_rigidbody.AddForce(new Vector3(_inputMovement.x * _moveSpeed, 0, _inputMovement.y * _moveSpeed));
	}
}