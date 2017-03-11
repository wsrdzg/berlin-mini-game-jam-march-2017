using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	public int _points;

	[SerializeField]
	Score score;

	[SerializeField]
	bool left;

	void OnTriggerEnter(Collider collider) {
		Ball ball = collider.gameObject.GetComponent<Ball>();
		if (ball != null) {
			_points++;
			ball.Respawn();
			score.SetLeftScore(_points, !left);
		}
	}
}