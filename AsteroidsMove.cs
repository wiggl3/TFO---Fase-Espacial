using UnityEngine;
using System.Collections;

public class AsteroidsMove : MonoBehaviour {

	 float vel;
	 //int rot;
	[SerializeField]
	Transform trans;
	//public new Vector3 eixo;


	// Use this for initialization
	void Start () {
		vel = Random.Range(1, 5);
		//rot = Random.Range(7, 17);
	}
	
	// Update is called once per frame
	void Update () {
		//transform.eulerAngles -= new Vector3 (rot * Time.deltaTime, 0, rot * Time.deltaTime);
		transform.RotateAround(trans.position, new Vector3 (0,Random.Range(1,10),0), vel * Time.deltaTime);
	}

}
