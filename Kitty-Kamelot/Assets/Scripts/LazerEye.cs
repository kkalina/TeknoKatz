using UnityEngine;
using System.Collections;

public class LazerEye : MonoBehaviour {

    public GameObject lazer;
    public Transform eyeOrigin;
    public enum eyes { one, two, three };

	// Use this for initialization
	void Start () {
        eyeOrigin = this.gameObject.transform;
        StartCoroutine(Gattle());

    }

    // Update is called once per frame
    void Update () {
	}

    IEnumerator Gattle() {
        Instantiate(lazer, eyeOrigin.position + Vector3.right/2 - Vector3.up/2, transform.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(lazer, eyeOrigin.position, transform.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(lazer, eyeOrigin.position - Vector3.right/ 2 - Vector3.up / 2, transform.rotation);
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(Gattle());
    }
}
