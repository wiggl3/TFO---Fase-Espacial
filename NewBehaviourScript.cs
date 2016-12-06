using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public Transform sol;
	public float vel;
	public new Vector3 eixo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(sol.position,eixo,vel*Time.deltaTime);
	}
}
