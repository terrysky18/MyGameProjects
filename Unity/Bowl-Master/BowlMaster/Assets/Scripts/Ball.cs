using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public float launchSpeed;

    private Rigidbody rigidBody;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

        LaunchBall();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Launch the bowling ball
    public void LaunchBall()
    {
        rigidBody.velocity = new Vector3(0, 0, launchSpeed);
        audioSource.Play();
    }
}
