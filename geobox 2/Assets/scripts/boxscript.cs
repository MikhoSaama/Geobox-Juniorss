using UnityEngine;
using System.Collections;

public class boxscript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

		if(Input.GetKey (KeyCode.LeftArrow) && gameObject.transform.position.x >=-1.8f)
		{
			gameObject.transform.Translate (-0.1f, 0, 0);
		}
	

		if(Input.GetKey (KeyCode.RightArrow) && gameObject.transform.position.x <=1.8f) 
		{
			gameObject.transform.Translate (0.1f, 0, 0);
		}



	    }

     void OnTriggerEnter2D (Collider2D other)
	{
		Destroy(other.gameObject);
	}

}
