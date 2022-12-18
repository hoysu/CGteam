using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minseo_mesh : MonoBehaviour

{

    Vector3 V0, V1, V2, V3, V4, V5;

    Vector3[] newVertices;

    int[] newTriangles;
    Vector3[] newNormals;



    void Start()

    {

        V0 = new Vector3(-0.5f, 0, -0.5f);

        V1 = new Vector3(-0.5f, 0, 0.5f);

        V2 = new Vector3(0.5f, 0, 0.5f);

        V3 = new Vector3(0.5f, 0, -0.5f);

        V4 = new Vector3(0, 1, 0);

        V5 = new Vector3(0, -1, 0);



        newVertices = new Vector3[]

        {

            V0, V1, V2, V3, V4, V5

        };



        newTriangles = new int[]

        {

            0, 2, 1,

            0, 3, 2,

            0, 4, 3,

            3, 4, 2,

            2, 4, 1,

            1, 4, 0,

            0, 5, 3,

            3, 5, 2,

            2, 5, 1,

            1, 5, 0

        };

        newNormals = new Vector3[]
            {

            V0, V1, V2, V3, V4, V5

        };

        gameObject.AddComponent<MeshFilter>();

        gameObject.AddComponent<MeshRenderer>();



        Mesh mesh = new Mesh();

        GetComponent<MeshFilter>().mesh = mesh;

        mesh.vertices = newVertices;

        mesh.triangles = newTriangles;
        mesh.normals = newNormals;



        Shader DefaultShader = Shader.Find("Standard");

        Material DefaultMaterial = new Material(DefaultShader);

        gameObject.GetComponent<Renderer>().material = DefaultMaterial;

    }

}