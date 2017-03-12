using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private int _playerId;
	[SerializeField]
	private float _maxSpeed;
	[SerializeField]
	private float _moveForce;

	private Rewired.Player _input;
	private Rigidbody _rigidbody;
	private bool _inputMove;


	private void Awake() {
		_rigidbody = GetComponent<Rigidbody>();
	}

	private void Start() {
		_input = Rewired.ReInput.players.GetPlayer(_playerId);
	}

	private void Update() {
		Vector3 inputDirection = new Vector3(_input.GetAxis(RewiredConsts.Action.Horizontal), 0, _input.GetAxis(RewiredConsts.Action.Vertical));
		if (inputDirection.sqrMagnitude > float.Epsilon)
			_rigidbody.MoveRotation(Quaternion.LookRotation(inputDirection, Vector3.up));

		_inputMove = _input.GetButton(RewiredConsts.Action.Move);
	}

	private void FixedUpdate() {
		if (_inputMove)
			_rigidbody.AddRelativeForce(Vector3.forward * _rigidbody.mass * _moveForce, ForceMode.Force);

		_rigidbody.velocity = Vector3.ClampMagnitude(_rigidbody.velocity, _maxSpeed);
	}
}