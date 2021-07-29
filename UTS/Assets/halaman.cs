using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halaman : MonoBehaviour
{
    public Material halamanmaterial;
    public Texture halamanTexture;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[16];
        var uvs = new Vector2[vertices.Length];
        halamanTexture = Resources.Load<Texture>("Textures/grass_texture");
        halamanmaterial.mainTexture = halamanTexture;

        vertices[0] = new Vector3(-6, 0, -6);
        vertices[1] = new Vector3(16, 0, -6);
        vertices[2] = new Vector3(-6, 0, 13);
        vertices[3] = new Vector3(16, 0, 13);
        vertices[4] = new Vector3(-6, 0, 0);
        vertices[5] = new Vector3(16, 0, 0);
        vertices[6] = new Vector3(-6, 0, 7);
        vertices[7] = new Vector3(16, 0, 7);
        vertices[8] = new Vector3(10, 0, 0);
        vertices[9] = new Vector3(10, 0, 7);
        vertices[10] = new Vector3(0, 0, 0);
        vertices[11] = new Vector3(0, 0, 7);
        vertices[12] = new Vector3(3.5f, 0, -6);
        vertices[13] = new Vector3(3.5f, 0, 0);
        vertices[14] = new Vector3(6.5f, 0, -6);
        vertices[15] = new Vector3(6.5f, 0, 0);

        uvs[0] = new Vector2(0, 0);
        uvs[1] = new Vector2(1, 0);
        uvs[2] = new Vector2(0, 1);
        uvs[3] = new Vector2(1, 1);
        uvs[4] = new Vector2(0, 0.334f);
        uvs[5] = new Vector2(1, 0.334f);
        uvs[6] = new Vector2(0, 0.677f);
        uvs[7] = new Vector2(1, 0.677f);
        uvs[8] = new Vector2(0.667f, 0.334f);
        uvs[9] = new Vector2(0.667f, 0.667f);
        uvs[10] = new Vector2(0.334f, 0.334f);
        uvs[11] = new Vector2(0.334f, 0.667f);
        uvs[12] = new Vector2(0.433f, 0);
        uvs[13] = new Vector2(0.433f, 0.334f);
        uvs[14] = new Vector2(0.556f, 0);
        uvs[15] = new Vector2(0.556f, 0.334f);

        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[]{
            //Dari atas
            // 0, 4, 1,
            // 1, 4, 5,
            0, 4, 13,
            0, 13, 12,
            14, 15, 5,
            14, 5, 1,
            5, 8, 7,
            7, 8, 9,
            6, 2, 7,
            7, 2, 3,
            10, 4, 11,
            11, 4, 6,
            //Dari bawah
            1, 2, 0,
            3, 2, 1
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = halamanmaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
