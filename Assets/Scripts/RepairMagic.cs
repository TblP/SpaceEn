using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RepairMagic : MonoBehaviour
{
    public bool bigd = false;

    public bool littled = false;

    public Takes tk;
    // Start is called before the first frame update
    void Start()
    {
        tk = GameObject.FindGameObjectWithTag("Player").GetComponent<Takes>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Wire1");
        if (other.gameObject.CompareTag("Wire"))
        {
            Destroy(other.gameObject);
            littled = true;
            tk.pickcheck = false;

        }

        if (other.gameObject.CompareTag("Shesterenka"))
        {
            Destroy(other.gameObject);
            bigd = true;
            tk.pickcheck = false;
            
        }
    }
}
