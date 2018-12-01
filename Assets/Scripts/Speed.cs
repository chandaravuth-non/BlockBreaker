using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour {

  [SerializeField] float gameSpeedlevel=1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Time.timeScale = gameSpeedlevel;
	}
}
