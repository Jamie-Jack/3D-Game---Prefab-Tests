using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class health : MonoBehaviour {
	public Slider HealthBar;


	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player")){
			HealthBar.value += 0.1f;
			Destroy (this.gameObject);
		}
	}


	void Start () {


	}

	// Update is called once per frame
	void Update () {



	}
}
