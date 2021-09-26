using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
public class ShadersOnOff : MonoBehaviour
{
    public Shader shaderOn;

    public Shader shaderOff;

    private Renderer rend;

    private GameObject player;

    public Image crosshair;
    
    public Ray ray;
    
    public RaycastHit hit;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        shaderOff = Shader.Find("Custom/ShaderOff");
        shaderOn = Shader.Find("Outline/Green");
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(crosshair.transform.position);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.CompareTag("PickUp") && gameObject.transform.position == hit.transform.position)
            {
                rend.material.shader = shaderOn;
            }
            else
            {
                rend.material.shader = shaderOff;
            }
        }

    }
}
