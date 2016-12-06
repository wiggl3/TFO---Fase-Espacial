using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {

	public float vel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles += new Vector3 (0,vel * Time.deltaTime, 0);
	}
}
