using UnityEngine;
using System.Collections;

public class SoundRetainer : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
