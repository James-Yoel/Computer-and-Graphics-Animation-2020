using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kacaTaman : MonoBehaviour
{
    public Material kacaTamanmaterial;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[16];

        vertices[0] = new Vector3(-0.3f, 4, -0.3f);
        vertices[1] = new Vector3(-0.3f, 5, -0.3f);
        vertices[2] = new Vector3(0.6f, 4, -0.3f);
        vertices[3] = new Vector3(0.6f, 5, -0.3f);

        vertices[4] = new Vector3(-0.3f, 4, 0.6f);
        vertices[5] = new Vector3(-0.3f, 5, 0.6f);
        vertices[6] = new Vector3(0.6f, 4, 0.6f);
        vertices[7] = new Vector3(0.6f, 5, 0.6f);

        vertices[8] = new Vector3(-0.275f, 4.25f, -0.275f);
        vertices[9] = new Vector3(-0.275f, 4.75f, -0.275f);
        vertices[10] = new Vector3(0.575f, 4.25f, -0.275f);
        vertices[11] = new Vector3(0.575f, 4.75f, -0.275f);

        vertices[12] = new Vector3(-0.275f, 4.25f, 0.575f);
        vertices[13] = new Vector3(-0.275f, 4.75f, 0.575f);
        vertices[14] = new Vector3(0.575f, 4.25f, 0.575f);
        vertices[15] = new Vector3(0.575f, 4.75f, 0.575f);

        mesh.vertices = vertices;

        mesh.triangles = new int[]{
            0, 1, 2,
            2, 1, 3,
            2, 3, 6,
            6, 3, 7,
            6, 7, 4,
            4, 7, 5,
            4, 5, 0,
            0, 5, 1,
            1, 5, 3,
            3, 5, 7,

            10, 9, 8,
            11, 9, 10,
            14, 11, 10,
            15, 11, 14,
            12, 15, 14,
            13, 15, 12,
            8, 13, 12,
            9, 13, 8,
            11, 13, 9,
            15, 13, 11,
        };
        
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = kacaTamanmaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
