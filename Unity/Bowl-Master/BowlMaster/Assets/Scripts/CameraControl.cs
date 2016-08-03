using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public Ball bowling_ball;

    private Vector3 posOffset;
    private Vector3 angOffset;

	// Use this for initialization
	void Start () {
        posOffset = transform.position - bowling_ball.transform.position;
        angOffset = new Vector3(1.6f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.z < 1829)
        {
            // ball has reached head pin
            transform.position = new Vector3(transform.position.x,
                                            transform.position.y,
                                            bowling_ball.transform.position.z + posOffset.z);
            transform.rotation = Quaternion.LookRotation(angOffset);
        }
	    
	}
}
