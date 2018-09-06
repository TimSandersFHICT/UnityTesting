using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool Tap()
    {
        if (Input.touchCount == 0) return false;
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Ended)
        {
            //startedDoubleTap = true;
            return true;
        }
        return false;
    }
}
