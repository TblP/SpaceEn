using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
public class ShadersOnOff : MonoBehaviour
{
    public Shader shaderOn;

    public Shader shaderOff;

    private Renderer _rend;

    public GameObject crosshair;
    
    public Ray ray;
    
    public RaycastHit hit;
    
    // Start is called before the first frame update
    void Start()
    {
        _rend = GetComponent<Renderer>();
        shaderOff = Shader.Find("Custom/ShaderOff");
        shaderOn = Shader.Find("Outline/Green");
        

    }

    // Update is called once per frame
    void Update()
    {
        crosshair = GameObject.FindGameObjectWithTag("Crosshair");
        ray = Camera.main.ScreenPointToRay(crosshair.transform.position);
        if (Physics.Raycast(ray, out hit))
        {
            if ((hit.transform.CompareTag("Shesterenka") || hit.transform.CompareTag("Wire") ) 
                && gameObject.transform.position == hit.transform.position)
            {
                _rend.material.shader = shaderOn;
            }
            else
            {
                _rend.material.shader = shaderOff;
            }
        }
    }
}
