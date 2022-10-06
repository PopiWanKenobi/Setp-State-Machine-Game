using UnityEngine;
using System.Collections;

public class Footsteps : MonoBehaviour {

	Camera mc;
	
	void Start ()	
 	{
		mc = GetComponent<Camera>();
	}
	
	void Update ()	
 	{
		if(mc.velocity.magnitude > 2f && GetComponent<AudioSource>().isPlaying == false)
		{
			GetComponent<AudioSource>().volume = Random.Range(0.05f, 0.2f);
			GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.1f);
			GetComponent<AudioSource>().Play();
		}
	}
}
