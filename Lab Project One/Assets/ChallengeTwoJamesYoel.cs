using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeTwoJamesYoel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public Material materialChallengeTwoJamesYoel;
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[60];

        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(1.5f, 0, 0);
        vertices[2] = new Vector3(0, 0, 1.5f);
        vertices[3] = new Vector3(1.5f, 0, 1.5f);
        vertices[4] = new Vector3(0, 0.25f, 0);
        vertices[5] = new Vector3(1.5f, 0.25f, 0);
        vertices[6] = new Vector3(1.5f, 0.25f, 1.5f);
        vertices[7] = new Vector3(0, 0.25f, 1.5f);

        vertices[8] = new Vector3(0, 2.5f, 1.5f);
        vertices[9] = new Vector3(0.25f, 2.5f, 1.5f);
        vertices[10] = new Vector3(0.25f, 0.25f, 1.5f);
        vertices[11] = new Vector3(0, 0.25f, 1.25f);
        vertices[12] = new Vector3(0, 2.5f, 1.25f);
        vertices[13] = new Vector3(0.25f, 0.25f, 1.25f);
        vertices[14] = new Vector3(0.25f, 2.5f, 1.25f); //
        vertices[15] = new Vector3(1.25f, 2.5f, 1.5f);
        vertices[16] = new Vector3(1.5f, 2.5f, 1.5f);
        vertices[17] = new Vector3(1.25f, 0.25f, 1.5f);
        vertices[18] = new Vector3(1.25f, 2.5f, 1.25f);
        vertices[19] = new Vector3(1.5f, 2.5f, 1.25f);
        vertices[20] = new Vector3(1.25f, 0.25f, 1.25f);
        vertices[21] = new Vector3(1.5f, 0.25f, 1.25f); //
        vertices[22] = new Vector3(0.25f, 1.5f, 1.5f);
        vertices[23] = new Vector3(1.25f, 1.5f, 1.5f);
        vertices[24] = new Vector3(0.25f, 1.5f, 1.25f);
        vertices[25] = new Vector3(1.25f, 1.5f, 1.25f);
        vertices[26] = new Vector3(1.5f, 0.25f, 1.5f);
        vertices[27] = new Vector3(0, 0.25f, 1.5f);

        vertices[28] = new Vector3(0, 0, 0);
        vertices[29] = new Vector3(0, -1.25f, 0);
        vertices[30] = new Vector3(0.25f, -1.25f, 0);
        vertices[31] = new Vector3(0.25f, 0, 0);
        vertices[32] = new Vector3(0, 0, 0.25f);
        vertices[33] = new Vector3(0.25f, 0, 0.25f);
        vertices[34] = new Vector3(0, -1.25f, 0.25f);
        vertices[35] = new Vector3(0.25f, -1.25f, 0.25f);

        vertices[36] = new Vector3(1.25f, 0, 0);
        vertices[37] = new Vector3(1.25f, -1.25f, 0);
        vertices[38] = new Vector3(1.5f, -1.25f, 0);
        vertices[39] = new Vector3(1.5f, 0, 0);
        vertices[40] = new Vector3(1.25f, 0, 0.25f);
        vertices[41] = new Vector3(1.5f, 0, 0.25f);
        vertices[42] = new Vector3(1.25f, -1.25f, 0.25f);
        vertices[43] = new Vector3(1.5f, -1.25f, 0.25f);

        vertices[44] = new Vector3(0, 0, 1.25f);
        vertices[45] = new Vector3(0, -1.25f, 1.25f);
        vertices[46] = new Vector3(0.25f, -1.25f, 1.25f);
        vertices[47] = new Vector3(0.25f, 0, 1.25f);
        vertices[48] = new Vector3(0, 0, 1.5f);
        vertices[49] = new Vector3(0.25f, 0, 1.5f);
        vertices[50] = new Vector3(0, -1.25f, 1.5f);
        vertices[51] = new Vector3(0.25f, -1.25f, 1.5f);

        vertices[52] = new Vector3(1.25f, 0, 1.25f);
        vertices[53] = new Vector3(1.25f, -1.25f, 1.25f);
        vertices[54] = new Vector3(1.5f, -1.25f, 1.25f);
        vertices[55] = new Vector3(1.5f, 0, 1.25f);
        vertices[56] = new Vector3(1.25f, 0, 1.5f);
        vertices[57] = new Vector3(1.5f, 0, 1.5f);
        vertices[58] = new Vector3(1.25f, -1.25f, 1.5f);
        vertices[59] = new Vector3(1.5f, -1.25f, 1.5f);

        mesh.vertices = vertices;

        var colors = new Color32[vertices.Length];
        for(int i = 0; i < vertices.Length; i++){
            if(i > 51){
                colors[i] = new Color32(255, 234, 4, 255);
            }
            else if(i > 43){
                colors[i] = new Color32(255, 0, 255, 255);
            }
            else if(i > 35){
                colors[i] = new Color32(0, 255, 255, 255);
            }
            else if(i > 27){
                colors[i] = new Color32(255, 0, 0, 255);
            }
            else if(i > 7){
                colors[i] = new Color32(0, 255, 0, 255);
            }
            else{
                colors[i] = new Color32(0, 0, 255, 255);
            }
        }

        mesh.colors32 = colors;

        mesh.triangles = new int[]{
            //Seat
            0, 1, 2,
            3, 2, 1,
            0, 4, 1,
            1, 4, 5,
            1, 5, 3,
            3, 5, 6,
            3, 6, 2,
            2, 6, 7,
            2, 4, 0,
            7, 4, 2,
            4, 7, 5,
            5, 7, 6,
            //Backrest
            10, 8, 27,
            9, 8, 10,
            12, 8, 14,
            14, 8, 9,
            11, 12, 13,
            13, 12, 14,
            27, 8, 11,
            11, 8, 12,
            13, 14, 10,
            10, 14, 9, //
            26, 16, 17,
            17, 16, 15,
            15, 19, 18,
            16, 19, 15,
            20, 18, 21,
            21, 18, 19,
            17, 15, 20,
            20, 15, 18,
            21, 19, 26,
            26, 19, 16, //
            23, 15, 22,
            22, 15, 9,
            24, 14, 25,
            25, 14, 18,
            14, 9, 18,
            18, 9, 15,
            25, 23, 24,
            24, 23, 22,
            //Kaki kiri depan
            29, 28, 30,
            30, 28, 31,
            34, 29, 35,
            35, 29, 30,
            35, 33, 34,
            34, 33, 32,
            34, 32, 29,
            29, 32, 28,
            30, 31, 35,
            35, 31, 33,
            //Kaki kanan depan
            37, 36, 38,
            38, 36, 39,
            42, 37, 43,
            43, 37, 38,
            43, 41, 42,
            42, 41, 40,
            42, 40, 37,
            37, 40, 36,
            38, 39, 43,
            43, 39, 41,
            //Kaki kiri belakang
            45, 44, 46,
            46, 44, 47,
            50, 45, 51,
            51, 45, 46,
            51, 49, 50,
            50, 49, 48,
            50, 48, 45,
            45, 48, 44,
            46, 47, 51,
            51, 47, 49,
            //Kaki kanan belakang
            53, 52, 54,
            54, 52, 55,
            58, 53, 59,
            59, 53, 54,
            59, 57, 58,
            58, 57, 56,
            58, 56, 53,
            53, 56, 52,
            54, 55, 59,
            59, 55, 57,
        };
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = materialChallengeTwoJamesYoel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
