using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour
{
	public int playerCamNumber;
	public int numPlayers;

	public Transform poi;
	public Transform camTarget;
	public float distance = 5, height = 1;
	public float u = 0.1f;
	//public float v = .1f;

	public bool shake = false;
	public float shakeIntensity = 0.1f;

	void FixedUpdate()
	{
		Vector3 pos = poi.position;
		pos -= poi.forward * distance;
		pos += poi.up * height;
		//Vector3 rot = poi.localEulerAngles;

		Vector3 pos2 = (1 - u) * transform.position + u * pos;
		//Vector3 rot2 = (1 - v) * transform.localEulerAngles + v * rot;

		if (shake) {
			pos2.x += Random.value * shakeIntensity * Random .Range(-1, 1);
			pos2.y += Random.value * shakeIntensity * Random .Range(-1, 1);
			pos2.z += Random.value * shakeIntensity * Random .Range(-1, 1);
		}

		transform.position = pos2;

		transform.LookAt(camTarget);
		//transform.localEulerAngles = rot2;

	}
}
