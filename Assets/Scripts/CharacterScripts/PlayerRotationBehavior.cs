using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotationBehavior : MonoBehaviour
{
    public float mouseSensitivity = 280f;
    public Transform camera;

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        camera.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

       // character.transform.Rotate(new Vector3(0, 1, 0), 5);
        transform.Rotate(new Vector3(0, 1, 0), mouseX);
   
    }
}
