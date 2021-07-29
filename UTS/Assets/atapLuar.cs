using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atapLuar : MonoBehaviour
{
    public Material atapLuarmaterial;
    public Texture atapLuarTexture;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[6];
        var uvs = new Vector2[vertices.Length];
        atapLuarTexture = Resources.Load<Texture>("Textures/roof_texture");
        atapLuarmaterial.mainTexture = atapLuarTexture;

        vertices[0] = new Vector3(-0.75f, 7.5f, -0.75f);
        vertices[1] = new Vector3(10.75f, 7.5f, -0.75f);
        vertices[2] = new Vector3(-0.75f, 10.75f, 3.5f);
        vertices[3] = new Vector3(10.75f, 10.75f, 3.5f);
        vertices[4] = new Vector3(-0.75f, 7.5f, 7.75f);
        vertices[5] = new Vector3(10.75f, 7.5f, 7.75f);

        uvs[0] = new Vector2(0, 0);
        uvs[1] = new Vector2(1, 0);
        uvs[2] = new Vector2(0, 1);
        uvs[3] = new Vector2(1, 1);
        uvs[4] = new Vector2(0, 0);
        uvs[5] = new Vector2(1, 0);

        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[]{
            //luar
            0, 2, 1,
            1, 2, 3,
            5, 3, 4,
            4, 3, 2
        };

        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = atapLuarmaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
