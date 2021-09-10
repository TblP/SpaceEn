using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Takes : MonoBehaviour
{
    public Image shop;
    public bool pickcheck = false;
    public GameObject crosshair;
    public GameObject distant;
    public Ray ray;
    public Vector3 heading;
    public RaycastHit hit;
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        crosshair = GameObject.FindGameObjectWithTag("Crosshair");
        distant = GameObject.FindGameObjectWithTag("pick");
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(crosshair.transform.position);
        if (pickcheck == true)
        {
            pickup();
        }
        upanddown();
        openpc();
    }
    void pickup()
    {
        hit.transform.position = new Vector3(distant.transform.position.x, distant.transform.position.y, distant.transform.position.z);
    }
    void upanddown()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (pickcheck == true)
            {
                i = 2;
            }
            if (i == 1)
            {
                
                if (Physics.Raycast(ray, out hit))
                {
                    heading = hit.transform.position - gameObject.transform.position;
                    if (hit.transform.CompareTag("PickUp") && (heading.x < 3 && heading.z < 3 && heading.x > -3 && heading.z > -3))
                    {
                        pickcheck = true;
                    }
                }
            }
            if (i == 2)
            {
                pickcheck = false;
                hit.transform.position = new Vector3(distant.transform.position.x, distant.transform.position.y, distant.transform.position.z);
                i = 1;
            }

        }
    }
    void openpc()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(ray, out hit))
            {
                heading = hit.transform.position - gameObject.transform.position;
                if (hit.transform.CompareTag("Computer") && (heading.x < 3 && heading.z < 3 && heading.x > -3 && heading.z > -3))
                {
                    shop.gameObject.SetActive(true);
                }
            }
        }
    }
}
