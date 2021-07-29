using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atap : MonoBehaviour
{
    public Material atapmaterial;
    public Texture atapTexture;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[14];
        var uvs = new Vector2[vertices.Length];
        atapTexture = Resources.Load<Texture>("Textures/ceiling_texture");
        atapmaterial.mainTexture = atapTexture;

        vertices[0] = new Vector3(-0.75f, 7.5f, -0.75f);
        vertices[1] = new Vector3(10.75f, 7.5f, -0.75f);
        vertices[2] = new Vector3(-0.75f, 10.75f, 3.5f);
        vertices[3] = new Vector3(10.75f, 10.75f, 3.5f);
        vertices[4] = new Vector3(-0.75f, 7.5f, 7.75f);
        vertices[5] = new Vector3(10.75f, 7.5f, 7.75f);

        vertices[6] = new Vector3(-0.75f, 7f, 0f);
        vertices[7] = new Vector3(10.75f, 7f, 0f);
        vertices[8] = new Vector3(-0.75f, 10f, 3.5f);
        vertices[9] = new Vector3(10.75f, 10f, 3.5f);
        vertices[10] = new Vector3(-0.75f, 7f, 7f);
        vertices[11] = new Vector3(10.75f, 7f, 7f);

        vertices[12] = new Vector3(10.75f, 10f, 3.5f);
        vertices[13] = new Vector3(-0.75f, 10f, 3.5f);

        uvs[0] = new Vector2(0, 0.1f);
        uvs[1] = new Vector2(1, 0.1f);
        uvs[2] = new Vector2(1, 0.1f);
        uvs[3] = new Vector2(0, 0.1f);
        uvs[4] = new Vector2(0, 0.1f);
        uvs[5] = new Vector2(1, 0.1f);

        uvs[6] = new Vector2(0, 0);
        uvs[7] = new Vector2(1, 0);
        uvs[8] = new Vector2(0, 1);
        uvs[9] = new Vector2(1, 1);
        uvs[10] = new Vector2(0, 0);
        uvs[11] = new Vector2(1, 0);

        uvs[12] = new Vector2(0, 0);
        uvs[13] = new Vector2(1, 0);

        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[]{
            //luar
            // 0, 2, 1,
            // 1, 2, 3,
            // 5, 3, 4,
            // 4, 3, 2,
            //dalam
            7, 8, 6,
            9, 8, 7,
            10, 9, 11,
            8, 9, 10,
            //penghubung
            6, 0, 7,
            7, 0, 1,
            7, 1, 12,
            12, 1, 3,
            12, 3, 11,
            11, 3, 5,
            11, 5, 10,
            10, 5, 4,
            10, 4, 13,
            13, 4, 2,
            13, 2, 6,
            6, 2, 0,
        };

        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = atapmaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
