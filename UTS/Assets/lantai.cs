using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lantai : MonoBehaviour
{
    public Material lantaimaterial;
    public Texture lantaiTexture;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[8];
        var uvs = new Vector2[vertices.Length];
        lantaiTexture = Resources.Load<Texture>("Textures/floor_texture");
        lantaimaterial.mainTexture = lantaiTexture;

        vertices[0] = new Vector3(0.5f, 0, 0.5f);
        vertices[1] = new Vector3(9.5f, 0, 0.5f);
        vertices[2] = new Vector3(0.5f, 0, 6.5f);
        vertices[3] = new Vector3(9.5f, 0, 6.5f);

        vertices[4] = new Vector3(3.5f, 0, 0);
        vertices[5] = new Vector3(6.5f, 0, 0);
        vertices[6] = new Vector3(3.5f, 0, 0.5f);
        vertices[7] = new Vector3(6.5f, 0, 0.5f);

        uvs[0] = new Vector3(0, 0);
        uvs[1] = new Vector3(1, 0);
        uvs[2] = new Vector3(0, 1);
        uvs[3] = new Vector3(1, 1);

        uvs[4] = new Vector2(0.35f, 0.144f);
        uvs[5] = new Vector2(0.65f, 0.144f);
        uvs[6] = new Vector2(0.35f, 0);
        uvs[7] = new Vector2(0.65f, 0);

        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[]{
            0, 2, 1,
            1, 2, 3,
            4, 6, 5,
            5, 6, 7
        };

        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = lantaimaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
