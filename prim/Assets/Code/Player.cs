using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float walkSpeed = 5f;

	float maxSpeed = 10f;
	float curSpeed;

	Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		curSpeed = walkSpeed;
		maxSpeed = curSpeed;

		rb.velocity = new Vector3(
			Mathf.Lerp(0, Input.GetAxisRaw("Horizontal") * curSpeed, 0.8f),
			rb.velocity.y,
			Mathf.Lerp(0, Input.GetAxisRaw("Vertical") * curSpeed, 0.8f)
		);
	}
}