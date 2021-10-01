using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Takes : MonoBehaviour
{
    public Image shop;
    public Image shop2;
    public bool pickcheck = false;
    public GameObject crosshair;
    public GameObject distant;
    public GameObject distant2;
    public Ray ray;
    public float heading;
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
        openpc2();
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
                    heading = Vector3.Distance(hit.transform.position ,gameObject.transform.position);
                    if ((hit.transform.CompareTag("PickUp")||hit.transform.CompareTag("Shesterenka") || hit.transform.CompareTag("Wire") ) 
                        && heading < 3 )
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
                heading = Vector3.Distance(hit.transform.position ,gameObject.transform.position);
                Debug.Log(heading);
                if (hit.transform.CompareTag("Computer") && heading < 3)
                {
                    shop.gameObject.SetActive(true);
                }
            }
        }
    }
    void openpc2()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(ray, out hit))
            {
                heading = Vector3.Distance(hit.transform.position ,gameObject.transform.position);
                if (hit.transform.CompareTag("Computer2") && heading < 3)
                {
                    shop2.gameObject.SetActive(true);
                }
            }
        }
    }

}
