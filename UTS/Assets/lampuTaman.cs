using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampuTaman : MonoBehaviour
{
    public Material lampuTamanmaterial;
    public Texture lampuTamanTexture;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[8];
        var uvs = new Vector2[vertices.Length];
        lampuTamanTexture = Resources.Load<Texture>("Textures/gardenLight_texture");
        lampuTamanmaterial.mainTexture = lampuTamanTexture;

        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0, 4, 0);
        vertices[2] = new Vector3(0.3f, 0, 0);
        vertices[3] = new Vector3(0.3f, 4, 0);

        vertices[4] = new Vector3(0, 0, 0.3f);
        vertices[5] = new Vector3(0, 4, 0.3f);
        vertices[6] = new Vector3(0.3f, 0, 0.3f);
        vertices[7] = new Vector3(0.3f, 4, 0.3f);

        uvs[0] = new Vector2(0, 0);
        uvs[1] = new Vector2(0, 0.334f);
        uvs[2] = new Vector2(0.334f, 0);
        uvs[3] = new Vector2(0.334f, 0.334f);
        uvs[4] = new Vector2(0.667f, 0.667f);
        uvs[5] = new Vector2(0.667f, 1f);
        uvs[6] = new Vector2(1, 0.667f);
        uvs[7] = new Vector2(1, 1);

        mesh.vertices = vertices;
        mesh.uv = uvs;

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
            3, 5, 7
        };
        
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = lampuTamanmaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
