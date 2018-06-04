using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MaxScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = PlayerPrefs.GetInt("Score").ToString();
	}
}
