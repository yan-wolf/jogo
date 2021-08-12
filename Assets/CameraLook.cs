using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
	public float minX = -90f;
	public float maxX = 90f;

	public float sensitivity;
    public Transform p1;
	float Xrot = 0f;

	void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void Update()
	{
		float rotX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
		float rotY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

		Xrot -= rotY;
		Xrot = Mathf.Clamp(Xrot, -90f, 90f);

		transform.localRotation = Quaternion.Euler(Xrot, 0f, 0f);
		p1.Rotate(Vector3.up * rotX);

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
        }

        if (Cursor.visible && Input.GetMouseButtonDown(1))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

       
	}
}
