using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour {
	public AudioSource Open;

	private bool opened;

    private void Start()
    {
		opened = false;
    }

    void OnTriggerEnter(Collider coll){
		if(coll.tag=="Player"){
			GetComponentInParent<Animator>().Play("Door_open");
			this.enabled=false;
			if (!opened) Open.Play();
			opened = true;
		}
	}
}
