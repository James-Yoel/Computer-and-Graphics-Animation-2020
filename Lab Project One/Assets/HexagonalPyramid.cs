using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonalPyramid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[20];

        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0.5f, 5, 1);
        vertices[2] = new Vector3(1, 0, 0);
        vertices[3] = new Vector3(1.5f, 0, 1);
        vertices[4] = new Vector3(1, 0, 2);
        vertices[5] = new Vector3(0, 0, 2);
        vertices[6] = new Vector3(-0.5f, 0, 1);

        mesh.vertices = vertices;

        mesh.triangles = new int[]{
            0, 1, 2,
            2, 1, 3,
            3, 1, 4,
            4, 1, 5,
            5, 1, 6,
            6, 1, 0,
            2, 4, 0,
            4, 5, 0,
            2, 3, 4,
            5, 6, 0
        };
        GetComponent<MeshFilter>().mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
