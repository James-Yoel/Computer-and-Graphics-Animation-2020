using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jendela : MonoBehaviour
{
    public Material jendelamaterial;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[8];

        vertices[0] = new Vector3(7.5f, 2, 7);
        vertices[1] = new Vector3(7.5f, 5, 7);
        vertices[2] = new Vector3(2.5f, 2, 7);
        vertices[3] = new Vector3(2.5f, 5, 7);
        vertices[4] = new Vector3(7.5f, 2, 6.5f);
        vertices[5] = new Vector3(7.5f, 5, 6.5f);
        vertices[6] = new Vector3(2.5f, 2, 6.5f);
        vertices[7] = new Vector3(2.5f, 5, 6.5f);

        mesh.vertices = vertices;

        mesh.triangles = new int[]{
            //Luar
            0, 1, 2,
            2, 1, 3,
            //Dalam
            6, 7, 4,
            4, 7, 5,
            //Penghubung
            5, 1, 7,
            7, 1, 3,
            0, 1, 4,
            4, 1, 5,
            0, 4, 2,
            2, 4, 6,
            6, 7, 2,
            2, 7, 3
        };

        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = jendelamaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
