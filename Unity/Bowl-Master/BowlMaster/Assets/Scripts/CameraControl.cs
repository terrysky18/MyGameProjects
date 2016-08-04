using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public Ball bowling_ball;

    private Vector3 posOffset;      // camera position offset

	// Use this for initialization
	void Start () {
        posOffset = transform.position - bowling_ball.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.z < 1720f)
        {
            // ball has not yet reached head pin
            // camera follows the ball
            transform.position = bowling_ball.transform.position + posOffset;

            // camera set to a fixed view angle
            //transform.position = new Vector3(transform.position.x,
                                            //transform.position.y,
                                            //bowling_ball.transform.position.z + posOffset.z);

            // set main camera to look down 1 deg about X-axis
            transform.rotation = Quaternion.Euler(1.8f, 0f, 0f);
        }
	}
}
