using UnityEngine;
using System.Collections;

public class Lazer : MonoBehaviour {

    private float laserSpeed = 100f;
	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * laserSpeed, ForceMode.Impulse);
        Destroy(this.gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
