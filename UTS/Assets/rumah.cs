using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rumah : MonoBehaviour
{
    public Material rumahmaterial;
    public Texture rumahTexture;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[56];
        var uvs = new Vector2[vertices.Length];
        rumahTexture = Resources.Load<Texture>("Textures/house_building");
        rumahmaterial.mainTexture = rumahTexture;

        //Rumah ketebalan luar
        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(10, 0, 0);
        vertices[2] = new Vector3(0, 7, 0);
        vertices[3] = new Vector3(10, 7, 0);

        uvs[0] = new Vector2(0.334f, 0f);
        uvs[1] = new Vector2(0.667f, 0f);
        uvs[2] = new Vector2(0.334f, 0.5f);
        uvs[3] = new Vector2(0.667f, 0.5f);

        vertices[20] = new Vector3(3.5f, 0, 0);
        vertices[21] = new Vector3(3.5f, 5, 0);
        vertices[22] = new Vector3(6.5f, 0, 0);
        vertices[23] = new Vector3(6.5f, 5, 0);
        vertices[24] = new Vector3(0, 5, 0);
        vertices[25] = new Vector3(10, 5, 0);

        uvs[20] = new Vector2(0.434f, 0f);
        uvs[21] = new Vector2(0.434f, 0.377f);
        uvs[22] = new Vector2(0.557f, 0f);
        uvs[23] = new Vector2(0.557f, 0.377f);
        uvs[24] = new Vector2(0.334f, 0.377f);
        uvs[25] = new Vector2(0.667f, 0.377f);

        vertices[4] = new Vector3(0, 0, 7);
        vertices[5] = new Vector3(10, 0, 7);
        vertices[6] = new Vector3(0, 7, 7);
        vertices[7] = new Vector3(10, 7, 7);

        uvs[4] = new Vector2(0f, 0f);
        uvs[5] = new Vector2(1f, 0f);
        uvs[6] = new Vector2(0f, 0.5f);
        uvs[7] = new Vector2(1f, 0.5f);

        vertices[32] = new Vector3(7.5f, 2, 7);
        vertices[33] = new Vector3(7.5f, 5, 7);
        vertices[34] = new Vector3(2.5f, 2, 7);
        vertices[35] = new Vector3(2.5f, 5, 7);
        vertices[36] = new Vector3(10, 2, 7);
        vertices[37] = new Vector3(10, 5, 7);
        vertices[38] = new Vector3(0, 2, 7);
        vertices[39] = new Vector3(0, 5, 7);

        uvs[32] = new Vector2(0.417f, 0.65f);
        uvs[33] = new Vector2(0.417f, 0.85f);
        uvs[34] = new Vector2(0.583f, 0.65f);
        uvs[35] = new Vector2(0.583f, 0.85f);
        uvs[36] = new Vector2(0.334f, 0.65f);
        uvs[37] = new Vector2(0.334f, 0.85f);
        uvs[38] = new Vector2(0.667f, 0.65f);
        uvs[39] = new Vector2(0.667f, 0.85f);

        vertices[8] = new Vector3(0, 10, 3.5f);
        vertices[9] = new Vector3(10, 10, 3.5f);

        uvs[8] = new Vector2(0.167f, 0.75f);
        uvs[9] = new Vector2(0.834f, 0.75f);

        vertices[48] = new Vector3(0, 0, 7);
        vertices[49] = new Vector3(10, 0, 7);
        vertices[50] = new Vector3(0, 7, 7);
        vertices[51] = new Vector3(10, 7, 7);

        uvs[48] = new Vector2(0.667f, 0.5f);
        uvs[49] = new Vector2(0.334f, 0.5f);
        uvs[50] = new Vector2(0.667f, 1);
        uvs[51] = new Vector2(0.334f, 1);

        //Rumah ketebalan dalam
        vertices[10] = new Vector3(0.5f, 0, 0.5f);
        vertices[11] = new Vector3(9.5f, 0, 0.5f);
        vertices[12] = new Vector3(0.5f, 7, 0.5f);
        vertices[13] = new Vector3(9.5f, 7, 0.5f);

        uvs[10] = new Vector2(0.334f, 0f);
        uvs[11] = new Vector2(0.667f, 0f);
        uvs[12] = new Vector2(0.334f, 0.5f);
        uvs[13] = new Vector2(0.667f, 0.5f);

        vertices[26] = new Vector3(3.5f, 0, 0.5f);
        vertices[27] = new Vector3(3.5f, 5, 0.5f);
        vertices[28] = new Vector3(6.5f, 0, 0.5f);
        vertices[29] = new Vector3(6.5f, 5, 0.5f);
        vertices[30] = new Vector3(0.5f, 5, 0.5f);
        vertices[31] = new Vector3(9.5f, 5, 0.5f);

        uvs[26] = new Vector2(0.434f, 0f);
        uvs[27] = new Vector2(0.434f, 0.377f);
        uvs[28] = new Vector2(0.557f, 0f);
        uvs[29] = new Vector2(0.557f, 0.377f);
        uvs[30] = new Vector2(0.334f, 0.377f);
        uvs[31] = new Vector2(0.667f, 0.377f);

        vertices[14] = new Vector3(0.5f, 0, 6.5f);
        vertices[15] = new Vector3(9.5f, 0, 6.5f);
        vertices[16] = new Vector3(0.5f, 7, 6.5f);
        vertices[17] = new Vector3(9.5f, 7, 6.5f);

        uvs[14] = new Vector2(0f, 0f);
        uvs[15] = new Vector2(1f, 0f);
        uvs[16] = new Vector2(0f, 0.5f);
        uvs[17] = new Vector2(1f, 0.5f);

        vertices[40] = new Vector3(7.5f, 2, 6.5f);
        vertices[41] = new Vector3(7.5f, 5, 6.5f);
        vertices[42] = new Vector3(2.5f, 2, 6.5f);
        vertices[43] = new Vector3(2.5f, 5, 6.5f);
        vertices[44] = new Vector3(9.5f, 2, 6.5f);
        vertices[45] = new Vector3(9.5f, 5, 6.5f);
        vertices[46] = new Vector3(0.5f, 2, 6.5f);
        vertices[47] = new Vector3(0.5f, 5, 6.5f);

        uvs[40] = new Vector2(0.417f, 0.65f);
        uvs[41] = new Vector2(0.417f, 0.85f);
        uvs[42] = new Vector2(0.583f, 0.65f);
        uvs[43] = new Vector2(0.583f, 0.85f);
        uvs[44] = new Vector2(0.334f, 0.65f);
        uvs[45] = new Vector2(0.334f, 0.85f);
        uvs[46] = new Vector2(0.667f, 0.65f);
        uvs[47] = new Vector2(0.667f, 0.85f);

        vertices[18] = new Vector3(0.5f, 10, 3.5f);
        vertices[19] = new Vector3(9.5f, 10, 3.5f);

        uvs[18] = new Vector2(0.167f, 0.75f);
        uvs[19] = new Vector2(0.834f, 0.75f);

        vertices[52] = new Vector3(0.5f, 0, 6.5f);
        vertices[53] = new Vector3(9.5f, 0, 6.5f);
        vertices[54] = new Vector3(0.5f, 7, 6.5f);
        vertices[55] = new Vector3(9.5f, 7, 6.5f);

        uvs[52] = new Vector2(0.667f, 0.5f);
        uvs[53] = new Vector2(0.334f, 0.5f);
        uvs[54] = new Vector2(0.667f, 1);
        uvs[55] = new Vector2(0.334f, 1);

        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[]{
            //Ketebalan luar
            0, 24, 20,
            20, 24, 21,
            22, 23, 1,
            1, 23, 25,
            24, 2, 25,
            25, 2, 3,
            1, 3, 5,
            5, 3, 7,
            // 5, 6, 4,
            // 7, 6, 5,
            49, 36, 48,
            48, 36, 38,
            36, 37, 32,
            32, 37, 33,
            37, 51, 39,
            39, 51, 50,
            34, 35, 38,
            38, 35, 39,
            4, 6, 0,
            0, 6, 2,
            3, 9, 7,
            6, 8, 2,
            //ketebalan dalam
            26, 30, 10,
            27, 30, 26,
            11, 29, 28,
            31, 29, 11,
            31, 12, 30,
            13, 12, 31,
            15, 13, 11,
            17, 13, 15,
            // 14, 16, 15,
            // 15, 16, 17,
            52, 44, 53,
            46, 44, 52,
            40, 45, 44,
            41, 45, 40,
            47, 55, 45,
            54, 55, 47,
            46, 43, 42,
            47, 43, 46,
            10, 16, 14,
            12, 16, 10,
            17, 19, 13,
            12, 18, 16,
            // 10, 14, 11,
            // 11, 14, 15,
            //Penyambung luar dan dalam
            2, 12, 3,
            3, 12, 13,
            3, 13, 9,
            9, 13, 19,
            17, 7, 19,
            19, 7, 9,
            7, 17, 6,
            6, 17, 16,
            6, 16, 8,
            8, 16, 18,
            12, 2, 18,
            18, 2, 8,
            20, 21, 26,
            26, 21, 27,
            28, 29, 22,
            22, 29, 23,
            27, 21, 29,
            29, 21, 23,
            41, 33, 43,
            43, 33, 35,
            32, 33, 40,
            40, 33, 41,
            32, 40, 34,
            34, 40, 42,
            42, 43, 34,
            34, 43, 35
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = rumahmaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
