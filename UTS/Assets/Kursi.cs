using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kursi : MonoBehaviour
{
    [SerializeField]
    public Material cubeMaterial;
    public Texture myTexture;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[150];
        var uvs = new Vector2[vertices.Length];

        myTexture = Resources.Load<Texture>("Textures/Wood");
        cubeMaterial.mainTexture = myTexture;

        vertices[0] = new Vector3(0.0f, 0.0f, 0.0f);
        vertices[1] = new Vector3(1.0f, 0.0f, 0.0f);
        vertices[2] = new Vector3(0.0f, 0.0f, -1.0f);
        vertices[3] = new Vector3(1.0f, 0.0f, -1.0f);

        uvs[0] = new Vector2(0.0f, 0.0f);
        uvs[1] = new Vector2(1.0f, 0.0f);
        uvs[2] = new Vector2(0.0f, 1.0f);
        uvs[3] = new Vector2(1.0f, 1.0f);

        vertices[4] = new Vector3(0.0f, 3.0f, 0.0f);
        vertices[5] = new Vector3(1.0f, 3.0f, 0.0f);
        vertices[6] = new Vector3(0.0f, 3.0f, -1.0f);
        vertices[7] = new Vector3(1.0f, 3.0f, -1.0f);

        uvs[4] = new Vector2(0.0f, 0.0f);
        uvs[5] = new Vector2(1.0f, 0.0f);
        uvs[6] = new Vector2(0.0f, 1.0f);
        uvs[7] = new Vector2(1.0f, 1.0f);

        vertices[8] = new Vector3(0.0f, 0.0f, 0.0f);
        vertices[9] = new Vector3(1.0f, 0.0f, 0.0f);
        vertices[10] = new Vector3(0.0f, 3.0f, 0.0f);
        vertices[11] = new Vector3(1.0f, 3.0f, 0.0f);

        uvs[8] = new Vector2(0.0f, 1.0f);
        uvs[9] = new Vector2(0.0f, 0.0f);
        uvs[10] = new Vector2(1.0f, 1.0f);
        uvs[11] = new Vector2(1.0f, 0.0f);

        vertices[12] = new Vector3(0.0f, 0.0f, -1.0f);
        vertices[13] = new Vector3(0.0f, 0.0f, 0.0f);
        vertices[14] = new Vector3(0.0f, 3.0f, -1.0f);
        vertices[15] = new Vector3(0.0f, 3.0f, 0.0f);

        uvs[12] = new Vector2(0.0f, 1.0f);
        uvs[13] = new Vector2(0.0f, 0.0f);
        uvs[14] = new Vector2(1.0f, 1.0f);
        uvs[15] = new Vector2(1.0f, 0.0f);

        vertices[16] = new Vector3(1.0f, 0.0f, -1.0f);
        vertices[17] = new Vector3(0.0f, 0.0f, -1.0f);
        vertices[18] = new Vector3(1.0f, 3.0f, -1.0f);
        vertices[19] = new Vector3(0.0f, 3.0f, -1.0f);

        uvs[16] = new Vector2(0.0f, 1.0f);
        uvs[17] = new Vector2(0.0f, 0.0f);
        uvs[18] = new Vector2(1.0f, 1.0f);
        uvs[19] = new Vector2(1.0f, 0.0f);

        vertices[20] = new Vector3(1.0f, 0.0f, 0.0f);
        vertices[21] = new Vector3(1.0f, 0.0f, -1.0f);
        vertices[22] = new Vector3(1.0f, 3.0f, 0.0f);
        vertices[23] = new Vector3(1.0f, 3.0f, -1.0f);

        uvs[20] = new Vector2(0.0f, 1.0f);
        uvs[21] = new Vector2(0.0f, 0.0f);
        uvs[22] = new Vector2(1.0f, 1.0f);
        uvs[23] = new Vector2(1.0f, 0.0f);

        vertices[24] = new Vector3(3.0f, 0.0f, 0.0f);
        vertices[25] = new Vector3(4.0f, 0.0f, 0.0f);
        vertices[26] = new Vector3(3.0f, 0.0f, -1.0f);
        vertices[27] = new Vector3(4.0f, 0.0f, -1.0f);

        uvs[24] = new Vector2(0.0f, 0.0f);
        uvs[25] = new Vector2(1.0f, 0.0f);
        uvs[26] = new Vector2(0.0f, 1.0f);
        uvs[27] = new Vector2(1.0f, 1.0f);

        vertices[28] = new Vector3(3.0f, 3.0f, 0.0f);
        vertices[29] = new Vector3(4.0f, 3.0f, 0.0f);
        vertices[30] = new Vector3(3.0f, 3.0f, -1.0f);
        vertices[31] = new Vector3(4.0f, 3.0f, -1.0f);

        uvs[28] = new Vector2(0.0f, 0.0f);
        uvs[29] = new Vector2(1.0f, 0.0f);
        uvs[30] = new Vector2(0.0f, 1.0f);
        uvs[31] = new Vector2(1.0f, 1.0f);

        vertices[32] = new Vector3(3.0f, 0.0f, 0.0f);
        vertices[33] = new Vector3(4.0f, 0.0f, 0.0f);
        vertices[34] = new Vector3(3.0f, 3.0f, 0.0f);
        vertices[35] = new Vector3(4.0f, 3.0f, 0.0f);

        uvs[32] = new Vector2(0.0f, 1.0f);
        uvs[33] = new Vector2(0.0f, 0.0f);
        uvs[34] = new Vector2(1.0f, 1.0f);
        uvs[35] = new Vector2(1.0f, 0.0f);

        vertices[36] = new Vector3(3.0f, 0.0f, 0.0f);
        vertices[37] = new Vector3(3.0f, 0.0f, -1.0f);
        vertices[38] = new Vector3(3.0f, 3.0f, 0.0f);
        vertices[39] = new Vector3(3.0f, 3.0f, -1.0f);

        uvs[36] = new Vector2(0.0f, 1.0f);
        uvs[37] = new Vector2(0.0f, 0.0f);
        uvs[38] = new Vector2(1.0f, 1.0f);
        uvs[39] = new Vector2(1.0f, 0.0f);

        vertices[40] = new Vector3(4.0f, 0.0f, -1.0f);
        vertices[41] = new Vector3(3.0f, 0.0f, -1.0f);
        vertices[42] = new Vector3(4.0f, 3.0f, -1.0f);
        vertices[43] = new Vector3(3.0f, 3.0f, -1.0f);

        uvs[40] = new Vector2(0.0f, 1.0f);
        uvs[41] = new Vector2(0.0f, 0.0f);
        uvs[42] = new Vector2(1.0f, 1.0f);
        uvs[43] = new Vector2(1.0f, 0.0f);

        vertices[44] = new Vector3(4.0f, 0.0f, 0.0f);
        vertices[45] = new Vector3(4.0f, 0.0f, -1.0f);
        vertices[46] = new Vector3(4.0f, 3.0f, 0.0f);
        vertices[47] = new Vector3(4.0f, 3.0f, -1.0f);

        uvs[44] = new Vector2(0.0f, 1.0f);
        uvs[45] = new Vector2(0.0f, 0.0f);
        uvs[46] = new Vector2(1.0f, 1.0f);
        uvs[47] = new Vector2(1.0f, 0.0f);

        vertices[48] = new Vector3(0.0f, 0.0f, -3.0f);
        vertices[49] = new Vector3(1.0f, 0.0f, -3.0f);
        vertices[50] = new Vector3(0.0f, 0.0f, -4.0f);
        vertices[51] = new Vector3(1.0f, 0.0f, -4.0f);

        uvs[48] = new Vector2(0.0f, 0.0f);
        uvs[49] = new Vector2(1.0f, 0.0f);
        uvs[50] = new Vector2(0.0f, 1.0f);
        uvs[51] = new Vector2(1.0f, 1.0f);

        vertices[52] = new Vector3(0.0f, 3.0f, -3.0f);
        vertices[53] = new Vector3(1.0f, 3.0f, -3.0f);
        vertices[54] = new Vector3(0.0f, 3.0f, -4.0f);
        vertices[55] = new Vector3(1.0f, 3.0f, -4.0f);

        uvs[52] = new Vector2(0.0f, 0.0f);
        uvs[53] = new Vector2(1.0f, 0.0f);
        uvs[54] = new Vector2(0.0f, 1.0f);
        uvs[55] = new Vector2(1.0f, 1.0f);

        vertices[56] = new Vector3(0.0f, 0.0f, -3.0f);
        vertices[57] = new Vector3(1.0f, 0.0f, -3.0f);
        vertices[58] = new Vector3(0.0f, 3.0f, -3.0f);
        vertices[59] = new Vector3(1.0f, 3.0f, -3.0f);

        uvs[56] = new Vector2(0.0f, 1.0f);
        uvs[57] = new Vector2(0.0f, 0.0f);
        uvs[58] = new Vector2(1.0f, 1.0f);
        uvs[59] = new Vector2(1.0f, 0.0f);

        vertices[60] = new Vector3(0.0f, 0.0f, -4.0f);
        vertices[61] = new Vector3(0.0f, 0.0f, -3.0f);
        vertices[62] = new Vector3(0.0f, 3.0f, -4.0f);
        vertices[63] = new Vector3(0.0f, 3.0f, -3.0f);

        uvs[60] = new Vector2(0.0f, 1.0f);
        uvs[61] = new Vector2(0.0f, 0.0f);
        uvs[62] = new Vector2(1.0f, 1.0f);
        uvs[63] = new Vector2(1.0f, 0.0f);

        vertices[64] = new Vector3(1.0f, 0.0f, -4.0f);
        vertices[65] = new Vector3(0.0f, 0.0f, -4.0f);
        vertices[66] = new Vector3(1.0f, 3.0f, -4.0f);
        vertices[67] = new Vector3(0.0f, 3.0f, -4.0f);

        uvs[64] = new Vector2(0.0f, 1.0f);
        uvs[65] = new Vector2(0.0f, 0.0f);
        uvs[66] = new Vector2(1.0f, 1.0f);
        uvs[67] = new Vector2(1.0f, 0.0f);

        vertices[68] = new Vector3(1.0f, 0.0f, -3.0f);
        vertices[69] = new Vector3(1.0f, 0.0f, -4.0f);
        vertices[70] = new Vector3(1.0f, 3.0f, -3.0f);
        vertices[71] = new Vector3(1.0f, 3.0f, -4.0f);

        uvs[68] = new Vector2(0.0f, 1.0f);
        uvs[69] = new Vector2(0.0f, 0.0f);
        uvs[70] = new Vector2(1.0f, 1.0f);
        uvs[71] = new Vector2(1.0f, 0.0f);

        vertices[72] = new Vector3(3.0f, 0.0f, -3.0f);
        vertices[73] = new Vector3(4.0f, 0.0f, -3.0f);
        vertices[74] = new Vector3(3.0f, 0.0f, -4.0f);
        vertices[75] = new Vector3(4.0f, 0.0f, -4.0f);

        uvs[72] = new Vector2(0.0f, 0.0f);
        uvs[73] = new Vector2(1.0f, 0.0f);
        uvs[74] = new Vector2(0.0f, 1.0f);
        uvs[75] = new Vector2(1.0f, 1.0f);

        vertices[76] = new Vector3(3.0f, 3.0f, -3.0f);
        vertices[77] = new Vector3(4.0f, 3.0f, -3.0f);
        vertices[78] = new Vector3(3.0f, 3.0f, -4.0f);
        vertices[79] = new Vector3(4.0f, 3.0f, -4.0f);

        uvs[76] = new Vector2(0.0f, 0.0f);
        uvs[77] = new Vector2(1.0f, 0.0f);
        uvs[78] = new Vector2(0.0f, 1.0f);
        uvs[79] = new Vector2(1.0f, 1.0f);

        vertices[80] = new Vector3(3.0f, 0.0f, -3.0f);
        vertices[81] = new Vector3(4.0f, 0.0f, -3.0f);
        vertices[82] = new Vector3(3.0f, 3.0f, -3.0f);
        vertices[83] = new Vector3(4.0f, 3.0f, -3.0f);

        uvs[80] = new Vector2(0.0f, 1.0f);
        uvs[81] = new Vector2(0.0f, 0.0f);
        uvs[82] = new Vector2(1.0f, 1.0f);
        uvs[83] = new Vector2(1.0f, 0.0f);

        vertices[84] = new Vector3(3.0f, 0.0f, -4.0f);
        vertices[85] = new Vector3(3.0f, 0.0f, -3.0f);
        vertices[86] = new Vector3(3.0f, 3.0f, -4.0f);
        vertices[87] = new Vector3(3.0f, 3.0f, -3.0f);

        uvs[84] = new Vector2(0.0f, 1.0f);
        uvs[85] = new Vector2(0.0f, 0.0f);
        uvs[86] = new Vector2(1.0f, 1.0f);
        uvs[87] = new Vector2(1.0f, 0.0f);

        vertices[88] = new Vector3(4.0f, 0.0f, -4.0f);
        vertices[89] = new Vector3(3.0f, 0.0f, -4.0f);
        vertices[90] = new Vector3(4.0f, 3.0f, -4.0f);
        vertices[91] = new Vector3(3.0f, 3.0f, -4.0f);

        uvs[88] = new Vector2(0.0f, 1.0f);
        uvs[89] = new Vector2(0.0f, 0.0f);
        uvs[90] = new Vector2(1.0f, 1.0f);
        uvs[91] = new Vector2(1.0f, 0.0f);

        vertices[92] = new Vector3(4.0f, 0.0f, -3.0f);
        vertices[93] = new Vector3(4.0f, 0.0f, -4.0f);
        vertices[94] = new Vector3(4.0f, 3.0f, -3.0f);
        vertices[95] = new Vector3(4.0f, 3.0f, -4.0f);

        uvs[92] = new Vector2(0.0f, 1.0f);
        uvs[93] = new Vector2(0.0f, 0.0f);
        uvs[94] = new Vector2(1.0f, 1.0f);
        uvs[95] = new Vector2(1.0f, 0.0f);

        vertices[96] = new Vector3(0.0f, 3.0f, 0.0f);
        vertices[97] = new Vector3(4.0f, 3.0f, 0.0f);
        vertices[98] = new Vector3(0.0f, 3.0f, -4.0f);
        vertices[99] = new Vector3(4.0f, 3.0f, -4.0f);

        uvs[96] = new Vector2(0.0f, 0.0f);
        uvs[97] = new Vector2(1.0f, 0.0f);
        uvs[98] = new Vector2(0.0f, 1.0f);
        uvs[99] = new Vector2(1.0f, 1.0f);

        vertices[100] = new Vector3(0.0f, 4.0f, 0.0f);
        vertices[101] = new Vector3(4.0f, 4.0f, 0.0f);
        vertices[102] = new Vector3(0.0f, 4.0f, -4.0f);
        vertices[103] = new Vector3(4.0f, 4.0f, -4.0f);

        uvs[100] = new Vector2(0.0f, 0.0f);
        uvs[101] = new Vector2(1.0f, 0.0f);
        uvs[102] = new Vector2(0.0f, 1.0f);
        uvs[103] = new Vector2(1.0f, 1.0f);

        vertices[104] = new Vector3(0.0f, 3.0f, 0.0f);
        vertices[105] = new Vector3(4.0f, 3.0f, 0.0f);
        vertices[106] = new Vector3(0.0f, 4.0f, 0.0f);
        vertices[107] = new Vector3(4.0f, 4.0f, 0.0f);

        uvs[104] = new Vector2(0.0f, 0.0f);
        uvs[105] = new Vector2(1.0f, 0.0f);
        uvs[106] = new Vector2(0.0f, 1.0f);
        uvs[107] = new Vector2(1.0f, 1.0f);

        vertices[108] = new Vector3(0.0f, 3.0f, -4.0f);
        vertices[109] = new Vector3(0.0f, 3.0f, 0.0f);
        vertices[110] = new Vector3(0.0f, 4.0f, -4.0f);
        vertices[111] = new Vector3(0.0f, 4.0f, 0.0f);

        uvs[108] = new Vector2(0.0f, 0.0f);
        uvs[109] = new Vector2(1.0f, 0.0f);
        uvs[110] = new Vector2(0.0f, 1.0f);
        uvs[111] = new Vector2(1.0f, 1.0f);

        vertices[112] = new Vector3(4.0f, 3.0f, -4.0f);
        vertices[113] = new Vector3(0.0f, 3.0f, -4.0f);
        vertices[114] = new Vector3(4.0f, 4.0f, -4.0f);
        vertices[115] = new Vector3(0.0f, 4.0f, -4.0f);

        uvs[112] = new Vector2(0.0f, 0.0f);
        uvs[113] = new Vector2(1.0f, 0.0f);
        uvs[114] = new Vector2(0.0f, 1.0f);
        uvs[115] = new Vector2(1.0f, 1.0f);

        vertices[116] = new Vector3(4.0f, 3.0f, 0.0f);
        vertices[117] = new Vector3(4.0f, 3.0f, -4.0f);
        vertices[118] = new Vector3(4.0f, 4.0f, 0.0f);
        vertices[119] = new Vector3(4.0f, 4.0f, -4.0f);

        uvs[116] = new Vector2(0.0f, 0.0f);
        uvs[117] = new Vector2(1.0f, 0.0f);
        uvs[118] = new Vector2(0.0f, 1.0f);
        uvs[119] = new Vector2(1.0f, 1.0f);

        vertices[120] = new Vector3(0.0f, 4.0f, -3.0f);
        vertices[121] = new Vector3(4.0f, 4.0f, -3.0f);
        vertices[122] = new Vector3(0.0f, 4.0f, -4.0f);
        vertices[123] = new Vector3(4.0f, 4.0f, -4.0f);

        uvs[120] = new Vector2(0.0f, 0.0f);
        uvs[121] = new Vector2(1.0f, 0.0f);
        uvs[122] = new Vector2(0.0f, 1.0f);
        uvs[123] = new Vector2(1.0f, 1.0f);

        vertices[124] = new Vector3(0.0f, 8.0f, -3.0f);
        vertices[125] = new Vector3(4.0f, 8.0f, -3.0f);
        vertices[126] = new Vector3(0.0f, 8.0f, -4.0f);
        vertices[127] = new Vector3(4.0f, 8.0f, -4.0f);

        uvs[124] = new Vector2(0.0f, 0.0f);
        uvs[125] = new Vector2(1.0f, 0.0f);
        uvs[126] = new Vector2(0.0f, 1.0f);
        uvs[127] = new Vector2(1.0f, 1.0f);

        vertices[128] = new Vector3(0.0f, 4.0f, -3.0f);
        vertices[129] = new Vector3(4.0f, 4.0f, -3.0f);
        vertices[130] = new Vector3(0.0f, 8.0f, -3.0f);
        vertices[131] = new Vector3(4.0f, 8.0f, -3.0f);

        uvs[128] = new Vector2(0.0f, 0.0f);
        uvs[129] = new Vector2(1.0f, 0.0f);
        uvs[130] = new Vector2(0.0f, 1.0f);
        uvs[131] = new Vector2(1.0f, 1.0f);

        vertices[132] = new Vector3(0.0f, 4.0f, -4.0f);
        vertices[133] = new Vector3(0.0f, 4.0f, -3.0f);
        vertices[134] = new Vector3(0.0f, 8.0f, -4.0f);
        vertices[135] = new Vector3(0.0f, 8.0f, -3.0f);

        uvs[132] = new Vector2(0.0f, 0.0f);
        uvs[133] = new Vector2(1.0f, 0.0f);
        uvs[134] = new Vector2(0.0f, 1.0f);
        uvs[135] = new Vector2(1.0f, 1.0f);

        vertices[136] = new Vector3(4.0f, 4.0f, -4.0f);
        vertices[137] = new Vector3(0.0f, 4.0f, -4.0f);
        vertices[138] = new Vector3(4.0f, 8.0f, -4.0f);
        vertices[139] = new Vector3(0.0f, 8.0f, -4.0f);

        uvs[136] = new Vector2(0.0f, 0.0f);
        uvs[137] = new Vector2(1.0f, 0.0f);
        uvs[138] = new Vector2(0.0f, 1.0f);
        uvs[139] = new Vector2(1.0f, 1.0f);

        vertices[140] = new Vector3(4.0f, 4.0f, -3.0f);
        vertices[141] = new Vector3(4.0f, 4.0f, -4.0f);
        vertices[142] = new Vector3(4.0f, 8.0f, -3.0f);
        vertices[143] = new Vector3(4.0f, 8.0f, -4.0f);

        uvs[140] = new Vector2(0.0f, 0.0f);
        uvs[141] = new Vector2(1.0f, 0.0f);
        uvs[142] = new Vector2(0.0f, 1.0f);
        uvs[143] = new Vector2(1.0f, 1.0f);


        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[]{
            // 2, 1, 0,
            // 2, 3, 1,
            6, 4, 5,
            6, 5, 7,
            10, 8, 9,
            10, 9, 11,
            14, 12, 13,
            14, 13, 15,
            19, 16, 17,
            19, 18, 16,
            22, 20, 21,
            22, 21, 23,

            // 26, 25, 24,
            // 26, 27, 25,
            30, 28, 29,
            30, 29, 31,
            34, 32, 33,
            34, 33, 35,
            39, 37, 36,
            39, 36, 38,
            43, 40, 41,
            43, 42, 40,
            46, 44, 45,
            46, 45, 47,

            // 50, 49, 48,
            // 50, 51, 49,
            54, 52, 53,
            54, 53, 55,
            58, 56, 57,
            58, 57, 59,
            62, 60, 61,
            62, 61, 63,
            67, 64, 65,
            67, 66, 64,
            70, 68, 69,
            70, 69, 71,

            // 74, 73, 72,
            // 74, 75, 73,
            78, 76, 77,
            78, 77, 79,
            82, 80, 81,
            82, 81, 83,
            86, 84, 85,
            86, 85, 87,
            91, 88, 89,
            91, 90, 88,
            94, 92, 93,
            94, 93, 95,

            97, 96, 98,
            97, 98, 99,
            102, 100, 101,
            103, 102, 101,
            106, 104, 105,
            106, 105, 107,
            111, 108, 109,
            111, 110, 108,
            114, 112, 113,
            113, 115, 114,
            118, 116, 117,
            117, 119, 118,

            121, 120, 122,
            121, 122, 123,
            126, 124, 125,
            127, 126, 125,
            130, 128, 129,
            130, 129, 131,
            135, 132, 133,
            135, 134, 132,
            138, 136, 137,
            137, 139, 138,
            142, 140, 141,
            141, 143, 142
        };
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = cubeMaterial;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
