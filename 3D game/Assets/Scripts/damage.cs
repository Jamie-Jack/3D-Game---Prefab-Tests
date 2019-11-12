using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class damage : MonoBehaviour {

	public Slider HealthBar;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player")){
			HealthBar.value -= 0.3f;
			if (HealthBar.value <= 0) {
				other.GetComponent<Animator>().SetBool("Death",true);
				SceneManager.LoadScene (1);

			}
				

			Destroy (this.gameObject);
		}

	}


	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
