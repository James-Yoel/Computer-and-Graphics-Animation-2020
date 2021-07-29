using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubix : MonoBehaviour
{
    [SerializeField]
    public Material rubixmaterial;
    public Texture myTexture;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[24];
        var uvs = new Vector2[vertices.Length];

        myTexture = Resources.Load<Texture>("Textures/rubix_texture");
        rubixmaterial.mainTexture = myTexture;
        vertices[0] = new Vector3(1, 1, 1);
        vertices[1] = new Vector3(1, -1, 1);
        vertices[2] = new Vector3(1, 1, -1);
        vertices[3] = new Vector3(1, -1, -1);

        vertices[4] = new Vector3(1, 1, 1);
        vertices[5] = new Vector3(-1, 1, 1);
        vertices[6] = new Vector3(1, 1, -1);
        vertices[7] = new Vector3(-1, 1, -1);

        vertices[8] = new Vector3(1, 1, 1);
        vertices[9] = new Vector3(-1, 1, 1);
        vertices[10] = new Vector3(1, -1, 1);
        vertices[11] = new Vector3(-1, -1, 1);

        vertices[12] = new Vector3(-1, 1, 1);
        vertices[13] = new Vector3(-1, -1, 1);
        vertices[14] = new Vector3(-1, 1, -1);
        vertices[15] = new Vector3(-1, -1, -1);

        vertices[16] = new Vector3(1, -1, 1);
        vertices[17] = new Vector3(-1, -1, 1);
        vertices[18] = new Vector3(1, -1, -1);
        vertices[19] = new Vector3(-1, -1, -1);

        vertices[20] = new Vector3(1, 1, -1);
        vertices[21] = new Vector3(-1, 1, -1);
        vertices[22] = new Vector3(1, -1, -1);
        vertices[23] = new Vector3(-1, -1, -1);
        //Kanan
        uvs[0] = new Vector2(0.334f, 0.5f);
        uvs[1] = new Vector2(0.667f, 0.5f);
        uvs[2] = new Vector2(0.334f, 0.25f);
        uvs[3] = new Vector2(0.667f, 0.25f);
        //Atas
        uvs[4] = new Vector2(0.334f, 0.25f);
        uvs[5] = new Vector2(0.667f, 0.25f);
        uvs[6] = new Vector2(0.334f, 0f);
        uvs[7] = new Vector2(0.667f, 0f);
        //Belakang
        uvs[8] = new Vector2(0.667f, 0.75f);
        uvs[9] = new Vector2(1f, 0.75f);
        uvs[10] = new Vector2(0.667f, 0.5f);
        uvs[11] = new Vector2(1f, 0.5f);
        //Kiri
        uvs[12] = new Vector2(0.334f, 1f);
        uvs[13] = new Vector2(0.334f, 0.75f);
        uvs[14] = new Vector2(0.667f, 1f);
        uvs[15] = new Vector2(0.667f, 0.75f);
        //Bawah
        uvs[16] = new Vector2(0.334f, 0.75f);
        uvs[17] = new Vector2(0.667f, 0.75f);
        uvs[18] = new Vector2(0.334f, 0.5f);
        uvs[19] = new Vector2(0.667f, 0.5f);
        //Depan
        uvs[20] = new Vector2(0f, 0.75f);
        uvs[21] = new Vector2(0.334f, 0.75f);
        uvs[22] = new Vector2(0f, 0.5f);
        uvs[23] = new Vector2(0.334f, 0.5f);

        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[]{
            2, 0, 1,
            2, 1, 3,
            6, 7, 5,
            4, 6, 5, 
            8, 9, 11,
            8, 11, 10,
            12, 14, 13,
            14, 15, 13,
            19, 18, 17,
            18, 16, 17,
            21, 20, 23,
            20, 22, 23
        };

        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = rubixmaterial;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
