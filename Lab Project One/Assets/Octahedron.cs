using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octahedron : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[20];

        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0, 1, 1);
        vertices[2] = new Vector3(1, 0,  0);
        vertices[3] = new Vector3(-1, 0, 0);
        vertices[4] = new Vector3(0, -1, 1);
        vertices[5] = new Vector3(1, 0, 1);
        vertices[6] = new Vector3(1, 0, 2);
        vertices[7] = new Vector3(0, 0, 2);
        vertices[8] = new Vector3(1, 0 ,2);
        vertices[9] = new Vector3(-1, 0, 2);
        vertices[10] = new Vector3(-1, 0, 1);
        vertices[11] = new Vector3(-1, 0, 2);

        mesh.vertices = vertices;

        mesh.triangles = new int[]{
            0, 1, 2,
            0, 3 ,1,
            2, 4, 0,
            0, 4, 3,
            2, 1, 5,
            5, 1, 6,
            5, 4, 2,
            6, 4, 5,
            8, 1, 7,
            1, 9, 7,
            7, 4, 8,
            9, 4, 7,
            10, 1, 3,
            11, 1, 10,
            3, 4, 10,
            10, 4, 11
        };
        GetComponent<MeshFilter>().mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
