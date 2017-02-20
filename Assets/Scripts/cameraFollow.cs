using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {


    public Transform target;
    public float m_speed = 0.1f;
    Camera mycam;

	// Use this for initialization
	void Start () {
        mycam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        mycam.orthographicSize = (Screen.height / 50f / 1f);

        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, m_speed);
        }
	}
}
