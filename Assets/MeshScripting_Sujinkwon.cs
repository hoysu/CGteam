using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshScripting_Sujinkwon : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4, V5, V6, V7; 
    Vector3[] newVertices; 
    int[] newTriangles; 
    Vector3[] newNormals;

    void Start() 

    { 
        V0 = new Vector3(-0.5f, -0.5f, -0.5f); 
        V1 = new Vector3(-0.5f, -0.5f, 0.5f); 
        V2 = new Vector3(0.5f, -0.5f, 0.5f); 
        V3 = new Vector3(0.5f, -0.5f, -0.5f); 
        V4 = new Vector3(-0.5f, 0.5f, -0.5f); 
        V5 = new Vector3(-0.5f, 0.5f, 0.5f); 
        V6 = new Vector3(0.5f, 0.5f, 0.5f); 
        V7 = new Vector3(0.5f, 0.5f, -0.5f); 

        newVertices = new Vector3[] 
        { 
            V0, V1, V2, V3, V4, V5, V6, V7 
        }; 

        newTriangles = new int[] 
        { 
            // Back 
            0, 4, 7, 
            0, 7, 3, 
            
            // Left 
            3, 7, 2, 
            2, 7, 6, 

            // Front 
            1, 6, 5, 
            1, 2, 6, 

            // Right 
            1, 4, 0, 
            1, 5, 4, 

            // Top 
            4, 5, 6, 
            4, 6, 7, 

            // Bottom 
            1, 0, 3, 
            1, 3, 2 
        }; 
        Vector3 Up = Vector3.up; 

        Vector3 Down = Vector3.down; 

        Vector3 Front = Vector3.forward; 

        Vector3 Left = Vector3.left; 

        Vector3 Right = Vector3.right; 

        Vector3 Back = Vector3.back; 

        newNormals = new Vector3[] 

        { 
            // Back 
            Back, Back, Back, Back, 
            // Right             
            Right, Right, Right, Right, 
            // Front 
            Front, Front, Front, Front, 
            // Left 
            Left, Left, Left, Left, 
            // Top 
            Up, Up, Up, Up, 
            // Bottom 
            Down, Down, Down, Down 
        }; 

 

        gameObject.AddComponent<MeshFilter>(); 
        gameObject.AddComponent<MeshRenderer>(); 

        Mesh mesh = new Mesh(); 
        GetComponent<MeshFilter>().mesh = mesh; 
        mesh.vertices = newVertices; 
        mesh.triangles = newTriangles; 

        Shader DefaultShader = Shader.Find("Standard"); 
        Material DefaultMaterial = new Material(DefaultShader); 
        gameObject.GetComponent<Renderer>().material = DefaultMaterial; 
    } 
}
