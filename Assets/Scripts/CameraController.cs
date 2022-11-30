using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]private float mouseSensitivity;
    [SerializeField]private Transform arms;
    [SerializeField]private Transform body;

    private float xRot;
    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }
   
    private void Update() {
        HandleMouseLook();
        
    }
    private void HandleMouseLook(){
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot,-90,90);

        arms.localRotation =Quaternion.Euler(new Vector3 (xRot,0,0));
        body.Rotate(new Vector3(0,mouseX,0));
    }

}
