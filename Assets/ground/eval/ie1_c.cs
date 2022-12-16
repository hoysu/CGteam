using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class ie1_c : MonoBehaviour
{
    Shader myShader;      
    Material myMaterial;

    void Start()
    {
        myShader = Shader.Find("shader/eval/ie1");
        myMaterial = new Material(myShader);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, myMaterial, 0);
    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }

}
