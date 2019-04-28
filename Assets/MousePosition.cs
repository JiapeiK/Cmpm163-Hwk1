using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    Renderer render;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();

        render.material.shader = Shader.Find("Custom/Imageproc");
    }

    // Update is called once per frame
    void Update()
    {
        float total = (Input.mousePosition.x - Input.mousePosition.y)/100;

        render.material.SetFloat("_Mix", total);
 
        //Debug.Log(Input.mousePosition);
    }
}
