using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugLog : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Hello World");
        Debug.Log("Hello World 2"); 

        Debug.LogWarning("Warning Message");
        Debug.LogError("Error Message");
	}
}
