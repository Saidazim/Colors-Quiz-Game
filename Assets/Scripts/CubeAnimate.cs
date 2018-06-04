using UnityEngine;
using System.Collections;

public class CubeAnimate : MonoBehaviour {

	public float speed, rotation;
	private Vector3 target = new Vector3 (0, 1.4f, 0);

	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, target, Time.deltaTime * speed);
		if (transform.position == target && target.y != 0f)
			target.y = 0f;
		else if (transform.position == target && target.y == 0f)
			target.y = 1.4f;

		transform.Rotate (Vector3.up * rotation);
	}
}
