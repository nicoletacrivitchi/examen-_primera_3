using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelotaMover : MonoBehaviour {
    float velocidad = 0.1f;
    public KeyCode teclaAsignada;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(teclaAsignada))
            this.transform.Translate(new Vector3(0, velocidad, 0));

        //Debug.Log("he pulsado");
    }
}
