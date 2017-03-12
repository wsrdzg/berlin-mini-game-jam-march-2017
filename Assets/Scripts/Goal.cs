using UnityEngine;

public class Goal : MonoBehaviour {

	[SerializeField]
	private Score _score;
	[SerializeField]
	private bool _left;
	[SerializeField]
	private ParticleSystem _particleSystem;


	private void OnTriggerEnter(Collider other) {
		Ball ball = other.GetComponent<Ball>();
		if (ball != null) {
			_particleSystem.transform.position = other.transform.position;
			_particleSystem.Play();

			if (_left) {
				_score.Right++;
			} else {
				_score.Left++;
			}

			ball.Respawn();
		}
	}
}