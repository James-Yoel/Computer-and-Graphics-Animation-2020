using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pintu : MonoBehaviour
{
    public Material pintumaterial;
    public Texture pintuTexture;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[8];
        var uvs = new Vector2[vertices.Length];
        pintuTexture = Resources.Load<Texture>("Textures/door_texture");
        pintumaterial.mainTexture = pintuTexture;

        vertices[0] = new Vector3(3.5f, 0, 0.125f);
        vertices[1] = new Vector3(3.5f, 5, 0.125f);
        vertices[2] = new Vector3(3.5f, 0, 3.125f);
        vertices[3] = new Vector3(3.5f, 5, 3.125f);
        vertices[4] = new Vector3(3.85f, 0, 0.125f);
        vertices[5] = new Vector3(3.85f, 5, 0.125f);
        vertices[6] = new Vector3(3.85f, 0, 3.125f);
        vertices[7] = new Vector3(3.85f, 5, 3.125f);

        uvs[0] = new Vector2(0f, 0f);
        uvs[1] = new Vector2(0f, 1f);
        uvs[2] = new Vector2(1f, 0f);
        uvs[3] = new Vector2(1f, 1f);
        uvs[4] = new Vector2(0f, 0f);
        uvs[5] = new Vector2(0f, 1f);
        uvs[6] = new Vector2(1f, 0f);
        uvs[7] = new Vector2(1f, 1f);

        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[]{
            //Luar
            4, 5, 6,
            6, 5, 7,
            //Dalam
            2, 3, 0,
            0, 3, 1,
            //Penyambung
            0, 1, 4,
            4, 1, 5,
            5, 1, 7,
            7, 1, 3,
            6, 7, 2,
            2, 7, 3,
        };

        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = pintumaterial;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.V)){
            transform.position = new Vector3(3.375f, 0, 4);
            transform.eulerAngles = new Vector3(0, 90, 0);
        }
        if(Input.GetKey(KeyCode.F)){
            transform.position = new Vector3(0, 0, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
