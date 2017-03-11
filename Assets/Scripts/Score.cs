using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	Text _Text;
	int left, right;


	void Awake() {
		_Text = GetComponent<Text>();
	}

	public void SetLeftScore(int score, bool direction) {
		if (direction) {
			left = score;
		} else {
			right = score;
		}
		_Text.text = left + ":" + right;
	}
}