using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundReturnButton : MonoBehaviour {

    GameObject Parent;

	// Use this for initialization
	void Start () {
        Parent = transform.root.gameObject;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ExitSoundMenu()
    {
        Destroy(Parent);
    }
}
