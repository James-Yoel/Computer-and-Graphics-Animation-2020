using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float cameraSensitivity = 90;
	public float normalMoveSpeed = 10;
	private float rotationX = 0.0f;
	private float rotationY = 0.0f;
 
	void Start ()
	{
		Cursor.visible = false;
	}
 
	void Update ()
	{
		rotationX += Input.GetAxis("Mouse X") * cameraSensitivity * Time.deltaTime;
		rotationY += Input.GetAxis("Mouse Y") * cameraSensitivity * Time.deltaTime;
		rotationY = Mathf.Clamp (rotationY, -90, 90);
 
		transform.localRotation = Quaternion.AngleAxis(rotationX, Vector3.up);
		transform.localRotation *= Quaternion.AngleAxis(rotationY, Vector3.left);
 
	    // transform.position += transform.forward * normalMoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
		// transform.position += transform.right * normalMoveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;

		if(Input.GetKey(KeyCode.D))
		{
			transform.Translate(new Vector3(normalMoveSpeed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(new Vector3(-normalMoveSpeed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.S))
		{
			transform.Translate(new Vector3(0, 0 , -normalMoveSpeed * Time.deltaTime));
		}
		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate(new Vector3(0, 0 , normalMoveSpeed * Time.deltaTime));
		}
 
	}
}
