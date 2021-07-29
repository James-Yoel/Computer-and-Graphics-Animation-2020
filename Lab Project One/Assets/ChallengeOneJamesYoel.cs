using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeOneJamesYoel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[20];

        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(1, 0, 0);
        vertices[2] = new Vector3(1, 0, 2);
        vertices[3] = new Vector3(0, 0, 2);
        vertices[4] = new Vector3(0.5f, 1, 0.5f);
        vertices[5] = new Vector3(0.5f, 1, 1.5f);
        vertices[6] = new Vector3(0.5f, -1, 0.5f);
        vertices[7] = new Vector3(0.5f, -1, 1.5f);
        vertices[8] = new Vector3(-0.5f, -0.5f, 1);
        vertices[9] = new Vector3(-0.5f, 0.5f, 1);
        vertices[10] = new Vector3(1.5f, -0.5f, 1);
        vertices[11] = new Vector3(1.5f, 0.5f, 1);

        mesh.vertices = vertices;

        mesh.triangles = new int[]{
            0, 4, 1,
            1, 4, 11,
            1, 11, 10,
            11, 2, 10,
            10, 2, 7,
            2, 3, 7,
            8, 7, 3,
            9, 8, 3,
            8, 9, 0,
            0, 9, 4,
            4, 5, 11,
            11, 5, 2,
            5, 3, 2,
            5, 9, 3,
            9, 5, 4,
            0, 1, 6,
            6, 1, 10,
            10, 7, 6,
            6, 7, 8,
            6, 8, 0

        };
        GetComponent<MeshFilter>().mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
