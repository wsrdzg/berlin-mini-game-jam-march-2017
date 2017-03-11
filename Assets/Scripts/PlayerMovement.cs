using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private int _playerId;

	[SerializeField]
	private float _dogeForce;
	[SerializeField]
	private float _maxSpeed;

	[SerializeField]
	private float _moveForce;

	private Rigidbody _rigidbody;
	private bool _inputDoge, _inputMove;
	private Vector2 _inputLook;

	private Rewired.Player _rewiredPlayer;

	public float _timeBetweenDoges;
	float lastDogeTime = -99999999;
	float dogeT;

	void Awake() {
		_rigidbody = GetComponent<Rigidbody>();
	}

	void Start() {
		_rewiredPlayer = Rewired.ReInput.players.GetPlayer(_playerId);
	}

	void Update() {
		_inputMove = _rewiredPlayer.GetButton("Move");
		if (_rewiredPlayer.GetButtonDown("Doge"))
			_inputDoge = true;

		_inputLook = new Vector2(_rewiredPlayer.GetAxis("Look Horizontal"), _rewiredPlayer.GetAxis("Look Vertical"));


	}

	void FixedUpdate() {
		/*if (_inputDoge) {
			_inputDoge = false;
			_rigidbody.AddRelativeForce(Vector3.forward * _dogeForce * _rigidbody.mass, ForceMode.Impulse);
		}
		if (_inputLook.x != 0 || _inputLook.y != 0)
			_rigidbody.MoveRotation(Quaternion.LookRotation(new Vector3(_inputLook.x, 0, _inputLook.y), Vector3.up));

		_rigidbody.velocity = Vector3.ClampMagnitude(_rigidbody.velocity, _maxDogeSpeed);*/

		if (_inputDoge && Time.time - lastDogeTime > _timeBetweenDoges) {
			lastDogeTime = Time.time;
			dogeT = 0.7f;
			_rigidbody.AddRelativeForce(Vector3.forward * _dogeForce * _rigidbody.mass, ForceMode.Impulse);
		}
		_inputDoge = false;

		if (_inputMove) {
			//_inputDoge = false;
			_rigidbody.AddRelativeForce(Vector3.forward * _moveForce * _rigidbody.mass, ForceMode.Force);
		}
		if (_inputLook.x != 0 || _inputLook.y != 0)
			_rigidbody.MoveRotation(Quaternion.LookRotation(new Vector3(_inputLook.x, 0, _inputLook.y), Vector3.up));

		dogeT = Mathf.Max(0, dogeT - Time.fixedTime);
		_rigidbody.velocity = Vector3.ClampMagnitude(_rigidbody.velocity, _maxSpeed + (dogeT * _dogeForce));
	}
}