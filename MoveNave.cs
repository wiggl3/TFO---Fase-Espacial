using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveNave : MonoBehaviour {

    [SerializeField]
	GameObject jato;

	[SerializeField]
	GameObject tam;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
			if (Input.GetKey (KeyCode.Space)) 
		{
			transform.position += transform.forward * Time.deltaTime * 5;
			jato.SetActive(true);
		}

		if (Input.GetKeyUp (KeyCode.Space)) 
		{
			jato.SetActive(false);
		}


		transform.Rotate (70 * Time.deltaTime * -Input.GetAxis("Vertical"), 0, 70 * Time.deltaTime * -Input.GetAxis("Horizontal"));
	}

	void OnTriggerStay (Collider sol)
	{
		if (sol.gameObject.tag == "Sun") 
		{
			Life ();
		}
	}


	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Asteroide") 
		{
			tam.transform.localScale -= new Vector3 (10f * Time.deltaTime, 0, 0);

			if (tam.transform.localScale.x < 0) 
			{
				SceneManager.LoadScene("GameOver");
			}
		}

		if (other.gameObject.tag == "Planet") 
		{
			
			tam.transform.localScale -= new Vector3 (25f * Time.deltaTime, 0, 0);
			
			if (tam.transform.localScale.x < 0) 
			{
				SceneManager.LoadScene("GameOver");
			}
		}
	}
	void Life()
	{
		if (tam.transform.localScale.x < 0) 
		{
			SceneManager.LoadScene("GameOver");
		}
		else 
		{
			tam.transform.localScale -= new Vector3 (0.05f * Time.deltaTime, 0, 0); 
		}
	}
}
