using UnityEngine;
using System.Collections;

public class Asteroids : MonoBehaviour {

	[SerializeField]
	GameObject [] pedras;

	float timer;

	int stopSpawn;

	int newAster;

	new Vector3 rotationAster;

	// Use this for initialization
	void Start () {
		Instantiate (pedras[Random.Range(0, 4)], transform.position,Quaternion.Euler(rotationAster));	

	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		next ();

		if (stopSpawn >= 15) 
		{
			Destroy(this);
		}
	}

	void next()/*Para chamar a proxima peça*/
	{
		if (timer >= 6) {
			//Instantiate(Create[Random.Range(0, 7)], transform.position, Quaternion.identity);
			Instantiate (pedras [newAster], transform.position, Quaternion.identity);//muda o create para puxar a proxima peça ja calculada e nao pra calcular dentro dele.
			//instancia a peça antes de zerar decimal novo
		
			newAster = Random.Range (0, 4);//da um novo valor a variavel para ja saber qual e a proxima
			timer = 0;

			stopSpawn += 1;
		}
	}
}
