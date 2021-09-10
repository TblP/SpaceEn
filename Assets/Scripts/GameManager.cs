using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public MovePlayer mp;
    public MouseLook ml;
    public Image shop;
    public Vector2 mouse;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (shop.gameObject.activeSelf == true)
        {
            
            mp.speed = 0f;
            ml.sensitivity = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
           
            mp.speed = 10f;
            ml.sensitivity = 5f;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
    public void exit()
    {
        shop.gameObject.SetActive(false);
    }
}
