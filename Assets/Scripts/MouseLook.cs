using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform head;
    private float rotationY;
    public float sensitivity = 5f; // чувствительность мыши
    public float headMinY = -40f; // ограничение угла для головы
    public float headMaxY = 40f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotationX = head.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
        rotationY += Input.GetAxis("Mouse Y") * sensitivity;
        rotationY = Mathf.Clamp(rotationY, headMinY, headMaxY);
        head.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}
