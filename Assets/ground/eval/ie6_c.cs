using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ie6_c : MonoBehaviour
{
    Shader myShader;       
    Material myMaterial;

    public float brightness = 1.0f;
    public float saturation = 1.0f;
    public float contrast = 1.0f;

    void Start()
    {
        myShader = Shader.Find("shader/eval/ie6");   
        myMaterial = new Material(myShader);
    }

    private void Update()
    {
        brightness = Mathf.Clamp(brightness, 0.0f, 3.0f);
        saturation = Mathf.Clamp(saturation, 0.0f, 3.0f);
        contrast = Mathf.Clamp(contrast, 0.0f, 3.0f);
    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        myMaterial.SetFloat("_Brightness", brightness);
        myMaterial.SetFloat("_Saturation", saturation);
        myMaterial.SetFloat("_Contrast", contrast);
        Graphics.Blit(source, destination, myMaterial);
    }
}