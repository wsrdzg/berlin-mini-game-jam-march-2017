using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	private Text _text;
	private int _left;
	private int _right;


	private void Awake() {
		_text = GetComponent<Text>();
	}

	public int Left {
		get { return _left; }
		set {
			_left = value;
			_text.text = _left + ":" + _right;
		}
	}

	public int Right {
		get { return _right; }
		set {
			_right = value;
			_text.text = _left + ":" + _right;
		}
	}
}