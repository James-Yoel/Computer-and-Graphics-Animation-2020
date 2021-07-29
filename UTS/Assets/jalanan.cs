using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jalanan : MonoBehaviour
{
    public Material jalananmaterial;
    public Texture jalananTexture;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[4];
        var uvs = new Vector2[vertices.Length];
        jalananTexture = Resources.Load<Texture>("Textures/road_texture");
        jalananmaterial.mainTexture = jalananTexture;

        vertices[0] = new Vector3(3.5f, 0, -6);
        vertices[1] = new Vector3(3.5f, 0, 0);
        vertices[2] = new Vector3(6.5f, 0, -6);
        vertices[3] = new Vector3(6.5f, 0, 0);

        uvs[0] = new Vector2(0, 0);
        uvs[1] = new Vector2(0, 1);
        uvs[2] = new Vector2(1, 0);
        uvs[3] = new Vector2(1, 1);

        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[]{
            0, 1, 2,
            2, 1, 3
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = jalananmaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
