using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pagar : MonoBehaviour
{
    [SerializeField]
    public Material cubeMaterial;
    public Texture myTexture;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[500];
        var uvs = new Vector2[vertices.Length];

        myTexture = Resources.Load<Texture>("Textures/Pagar2");
        cubeMaterial.mainTexture = myTexture;
        
        vertices[0] = new Vector3(-6.0f, 0.0f, 0.0f);
        vertices[1] = new Vector3(15.0f, 0.0f, 0.0f);
        vertices[2] = new Vector3(-6.0f, 0.0f, -0.25f);
        vertices[3] = new Vector3(15.0f, 0.0f, -0.25f);

        uvs[0] = new Vector2(0.0f, 0.0f);
        uvs[1] = new Vector2(1.0f, 0.0f);
        uvs[2] = new Vector2(0.0f, 1.0f);
        uvs[3] = new Vector2(1.0f, 1.0f);

        vertices[4] = new Vector3(-6.0f, 4.0f, 0.0f);
        vertices[5] = new Vector3(15.0f, 4.0f, 0.0f);
        vertices[6] = new Vector3(-6.0f, 4.0f, -0.25f);
        vertices[7] = new Vector3(15.0f, 4.0f, -0.25f);

        uvs[4] = new Vector2(0.0f, 0.0f);
        uvs[5] = new Vector2(1.0f, 0.0f);
        uvs[6] = new Vector2(0.0f, 1.0f);
        uvs[7] = new Vector2(1.0f, 1.0f);

        vertices[8] = new Vector3(-6.0f, 0.0f, 0.0f);
        vertices[9] = new Vector3(15.0f, 0.0f, 0.0f);
        vertices[10] = new Vector3(-6.0f, 4.0f, 0.0f);
        vertices[11] = new Vector3(15.0f, 4.0f, 0.0f);

        uvs[8] = new Vector2(0.0f, 0.0f);
        uvs[9] = new Vector2(1.0f, 0.0f);
        uvs[10] = new Vector2(0.0f, 1.0f);
        uvs[11] = new Vector2(1.0f, 1.0f);

        vertices[12] = new Vector3(-6.0f, 0.0f, -0.25f);
        vertices[13] = new Vector3(-6.0f, 0.0f, 0.0f);
        vertices[14] = new Vector3(-6.0f, 4.0f, -0.25f);
        vertices[15] = new Vector3(-6.0f, 4.0f, 0.0f);

        uvs[12] = new Vector2(0.0f, 1.0f);
        uvs[13] = new Vector2(0.0f, 0.0f);
        uvs[14] = new Vector2(1.0f, 1.0f);
        uvs[15] = new Vector2(1.0f, 0.0f);

        vertices[16] = new Vector3(15.0f, 0.0f, -0.25f);
        vertices[17] = new Vector3(-6.0f, 0.0f, -0.25f);
        vertices[18] = new Vector3(15.0f, 4.0f, -0.25f);
        vertices[19] = new Vector3(-6.0f, 4.0f, -0.25f);

        uvs[16] = new Vector2(0.0f, 0.0f);
        uvs[17] = new Vector2(1.0f, 0.0f);
        uvs[18] = new Vector2(0.0f, 1.0f);
        uvs[19] = new Vector2(1.0f, 1.0f);

        vertices[20] = new Vector3(15.0f, 0.0f, 0.0f);
        vertices[21] = new Vector3(15.0f, 0.0f, -0.25f);
        vertices[22] = new Vector3(15.0f, 4.0f, 0.0f);
        vertices[23] = new Vector3(15.0f, 4.0f, -0.25f);

        uvs[20] = new Vector2(0.0f, 1.0f);
        uvs[21] = new Vector2(0.0f, 0.0f);
        uvs[22] = new Vector2(1.0f, 1.0f);
        uvs[23] = new Vector2(1.0f, 0.0f);

        vertices[24] = new Vector3(-6.0f, 0.0f, 0.0f);
        vertices[25] = new Vector3(-6.0f, 0.0f, 18.0f);
        vertices[26] = new Vector3(-5.75f, 0.0f, 0.0f);
        vertices[27] = new Vector3(-5.75f, 0.0f, 18.0f);

        uvs[24] = new Vector2(0.0f, 0.0f);
        uvs[25] = new Vector2(1.0f, 0.0f);
        uvs[26] = new Vector2(0.0f, 1.0f);
        uvs[27] = new Vector2(1.0f, 1.0f);

        vertices[28] = new Vector3(-6.0f, 4.0f, 0.0f);
        vertices[29] = new Vector3(-6.0f, 4.0f, 18.0f);
        vertices[30] = new Vector3(-5.75f, 4.0f, 0.0f);
        vertices[31] = new Vector3(-5.75f, 4.0f, 18.0f);

        uvs[28] = new Vector2(0.0f, 0.0f);
        uvs[29] = new Vector2(1.0f, 0.0f);
        uvs[39] = new Vector2(0.0f, 1.0f);
        uvs[31] = new Vector2(1.0f, 1.0f);

        vertices[32] = new Vector3(-6.0f, 0.0f, 0.0f);
        vertices[33] = new Vector3(-6.0f, 0.0f, 18.0f);
        vertices[34] = new Vector3(-6.0f, 4.0f, 0.0f);
        vertices[35] = new Vector3(-6.0f, 4.0f, 18.0f);

        uvs[32] = new Vector2(0.0f, 0.0f);
        uvs[33] = new Vector2(1.0f, 0.0f);
        uvs[34] = new Vector2(0.0f, 1.0f);
        uvs[35] = new Vector2(1.0f, 1.0f);

        vertices[36] = new Vector3(-5.75f, 0.0f, 0.0f);
        vertices[37] = new Vector3(-6.0f, 0.0f, 0.0f);
        vertices[38] = new Vector3(-5.75f, 4.0f, 0.0f);
        vertices[39] = new Vector3(-6.0f, 4.0f, 0.0f);

        uvs[36] = new Vector2(0.0f, 1.0f);
        uvs[37] = new Vector2(0.0f, 0.0f);
        uvs[38] = new Vector2(1.0f, 1.0f);
        uvs[39] = new Vector2(1.0f, 0.0f);

        vertices[40] = new Vector3(-5.75f, 0.0f, 18.0f);
        vertices[41] = new Vector3(-5.75f, 0.0f, 0.0f);
        vertices[42] = new Vector3(-5.75f, 4.0f, 18.0f);
        vertices[43] = new Vector3(-5.75f, 4.0f, 0.0f);

        uvs[40] = new Vector2(0.0f, 0.0f);
        uvs[41] = new Vector2(1.0f, 0.0f);
        uvs[42] = new Vector2(0.0f, 1.0f);
        uvs[43] = new Vector2(1.0f, 1.0f);

        vertices[44] = new Vector3(-6.0f, 0.0f, 18.0f);
        vertices[45] = new Vector3(-5.75f, 0.0f, 18.0f);
        vertices[46] = new Vector3(-6.0f, 4.0f, 18.0f);
        vertices[47] = new Vector3(-5.75f, 4.0f, 18.0f);

        uvs[44] = new Vector2(0.0f, 1.0f);
        uvs[45] = new Vector2(0.0f, 0.0f);
        uvs[46] = new Vector2(1.0f, 1.0f);
        uvs[47] = new Vector2(1.0f, 0.0f);

        vertices[48] = new Vector3(15.0f, 0.0f, 0.0f);
        vertices[49] = new Vector3(15.0f, 0.0f, 18.0f);
        vertices[50] = new Vector3(14.75f, 0.0f, 0.0f);
        vertices[51] = new Vector3(14.75f, 0.0f, 18.0f);

        uvs[48] = new Vector2(0.0f, 0.0f);
        uvs[49] = new Vector2(1.0f, 0.0f);
        uvs[50] = new Vector2(0.0f, 1.0f);
        uvs[51] = new Vector2(1.0f, 1.0f);

        vertices[52] = new Vector3(15.0f, 4.0f, 0.0f);
        vertices[53] = new Vector3(15.0f, 4.0f, 18.0f);
        vertices[54] = new Vector3(14.75f, 4.0f, 0.0f);
        vertices[55] = new Vector3(14.75f, 4.0f, 18.0f);

        uvs[52] = new Vector2(0.0f, 0.0f);
        uvs[53] = new Vector2(1.0f, 0.0f);
        uvs[54] = new Vector2(0.0f, 1.0f);
        uvs[55] = new Vector2(1.0f, 1.0f);

        vertices[56] = new Vector3(15.0f, 0.0f, 0.0f);
        vertices[57] = new Vector3(15.0f, 0.0f, 18.0f);
        vertices[58] = new Vector3(15.0f, 4.0f, 0.0f);
        vertices[59] = new Vector3(15.0f, 4.0f, 18.0f);

        uvs[56] = new Vector2(0.0f, 0.0f);
        uvs[57] = new Vector2(1.0f, 0.0f);
        uvs[58] = new Vector2(0.0f, 1.0f);
        uvs[59] = new Vector2(1.0f, 1.0f);

        vertices[60] = new Vector3(14.75f, 0.0f, 0.0f);
        vertices[61] = new Vector3(15.0f, 0.0f, 0.0f);
        vertices[62] = new Vector3(14.75f, 4.0f, 0.0f);
        vertices[63] = new Vector3(15.0f, 4.0f, 0.0f);

        uvs[60] = new Vector2(0.0f, 1.0f);
        uvs[61] = new Vector2(0.0f, 0.0f);
        uvs[62] = new Vector2(1.0f, 1.0f);
        uvs[63] = new Vector2(1.0f, 0.0f);

        vertices[64] = new Vector3(14.75f, 0.0f, 18.0f);
        vertices[65] = new Vector3(14.75f, 0.0f, 0.0f);
        vertices[66] = new Vector3(14.75f, 4.0f, 18.0f);
        vertices[67] = new Vector3(14.75f, 4.0f, 0.0f);

        uvs[64] = new Vector2(0.0f, 0.0f);
        uvs[65] = new Vector2(1.0f, 0.0f);
        uvs[66] = new Vector2(0.0f, 1.0f);
        uvs[67] = new Vector2(1.0f, 1.0f);

        vertices[68] = new Vector3(15.0f, 0.0f, 18.0f);
        vertices[69] = new Vector3(14.75f, 0.0f, 18.0f);
        vertices[70] = new Vector3(15.0f, 4.0f, 18.0f);
        vertices[71] = new Vector3(14.75f, 4.0f, 18.0f);

        uvs[68] = new Vector2(0.0f, 1.0f);
        uvs[69] = new Vector2(0.0f, 0.0f);
        uvs[70] = new Vector2(1.0f, 1.0f);
        uvs[71] = new Vector2(1.0f, 0.0f);

        vertices[72] = new Vector3(-6.0f, 4.0f, 0.0f);
        vertices[73] = new Vector3(-4.0f, 4.0f, 0.0f);
        vertices[74] = new Vector3(-5.0f, 5.0f, 0.0f);

        uvs[72] = new Vector2(0.0f, 0.0f);
        uvs[73] = new Vector2(1.0f, 0.0f);
        uvs[74] = new Vector2(0.5f, 1.0f);

        vertices[75] = new Vector3(-6.0f, 4.0f, -0.25f);
        vertices[76] = new Vector3(-4.0f, 4.0f, -0.25f);
        vertices[77] = new Vector3(-5.0f, 5.0f, -0.25f);

        uvs[75] = new Vector2(0.0f, 0.0f);
        uvs[76] = new Vector2(1.0f, 0.0f);
        uvs[77] = new Vector2(0.5f, 1.0f);

        vertices[78] = new Vector3(-4.0f, 4.0f, 0.0f);
        vertices[79] = new Vector3(-4.0f, 4.0f, -0.25f);
        vertices[80] = new Vector3(-5.0f, 5.0f, 0.0f);
        vertices[81] = new Vector3(-5.0f, 5.0f, -0.25f);

        uvs[78] = new Vector2(0.0f, 1.0f);
        uvs[79] = new Vector2(0.0f, 0.0f);
        uvs[80] = new Vector2(1.0f, 1.0f);
        uvs[81] = new Vector2(1.0f, 0.0f);

        vertices[82] = new Vector3(-6.0f, 4.0f, -0.25f);
        vertices[83] = new Vector3(-6.0f, 4.0f, 0.0f);
        vertices[84] = new Vector3(-5.0f, 5.0f, -0.25f);
        vertices[85] = new Vector3(-5.0f, 5.0f, 0.0f);

        uvs[82] = new Vector2(0.0f, 1.0f);
        uvs[83] = new Vector2(0.0f, 0.0f);
        uvs[84] = new Vector2(1.0f, 1.0f);
        uvs[85] = new Vector2(1.0f, 0.0f);

        vertices[86] = new Vector3(-4.0f, 4.0f, 0.0f);
        vertices[87] = new Vector3(-2.0f, 4.0f, 0.0f);
        vertices[88] = new Vector3(-3.0f, 5.0f, 0.0f);

        uvs[86] = new Vector2(0.0f, 0.0f);
        uvs[87] = new Vector2(1.0f, 0.0f);
        uvs[88] = new Vector2(0.5f, 1.0f);

        vertices[89] = new Vector3(-4.0f, 4.0f, -0.25f);
        vertices[90] = new Vector3(-2.0f, 4.0f, -0.25f);
        vertices[91] = new Vector3(-3.0f, 5.0f, -0.25f);

        uvs[89] = new Vector2(0.0f, 0.0f);
        uvs[90] = new Vector2(1.0f, 0.0f);
        uvs[91] = new Vector2(0.5f, 1.0f);

        vertices[92] = new Vector3(-2.0f, 4.0f, 0.0f);
        vertices[93] = new Vector3(-2.0f, 4.0f, -0.25f);
        vertices[94] = new Vector3(-3.0f, 5.0f, 0.0f);
        vertices[95] = new Vector3(-3.0f, 5.0f, -0.25f);

        uvs[92] = new Vector2(0.0f, 1.0f);
        uvs[93] = new Vector2(0.0f, 0.0f);
        uvs[94] = new Vector2(1.0f, 1.0f);
        uvs[95] = new Vector2(1.0f, 0.0f);

        vertices[96] = new Vector3(-4.0f, 4.0f, -0.25f);
        vertices[97] = new Vector3(-4.0f, 4.0f, 0.0f);
        vertices[98] = new Vector3(-3.0f, 5.0f, -0.25f);
        vertices[99] = new Vector3(-3.0f, 5.0f, 0.0f);

        uvs[96] = new Vector2(0.0f, 1.0f);
        uvs[97] = new Vector2(0.0f, 0.0f);
        uvs[98] = new Vector2(1.0f, 1.0f);
        uvs[99] = new Vector2(1.0f, 0.0f);

        vertices[100] = new Vector3(-2.0f, 4.0f, 0.0f);
        vertices[101] = new Vector3(0.0f, 4.0f, 0.0f);
        vertices[102] = new Vector3(-1.0f, 5.0f, 0.0f);

        uvs[100] = new Vector2(0.0f, 0.0f);
        uvs[101] = new Vector2(1.0f, 0.0f);
        uvs[102] = new Vector2(0.5f, 1.0f);

        vertices[103] = new Vector3(-2.0f, 4.0f, -0.25f);
        vertices[104] = new Vector3(0.0f, 4.0f, -0.25f);
        vertices[105] = new Vector3(-1.0f, 5.0f, -0.25f);

        uvs[103] = new Vector2(0.0f, 0.0f);
        uvs[104] = new Vector2(1.0f, 0.0f);
        uvs[105] = new Vector2(0.5f, 1.0f);
        
        vertices[106] = new Vector3(0.0f, 4.0f, 0.0f);
        vertices[107] = new Vector3(0.0f, 4.0f, -0.25f);
        vertices[108] = new Vector3(-1.0f, 5.0f, 0.0f);
        vertices[109] = new Vector3(-1.0f, 5.0f, -0.25f);

        uvs[106] = new Vector2(0.0f, 1.0f);
        uvs[107] = new Vector2(0.0f, 0.0f);
        uvs[108] = new Vector2(1.0f, 1.0f);
        uvs[109] = new Vector2(1.0f, 0.0f);

        vertices[110] = new Vector3(-2.0f, 4.0f, -0.25f);
        vertices[111] = new Vector3(-2.0f, 4.0f, 0.0f);
        vertices[112] = new Vector3(-1.0f, 5.0f, -0.25f);
        vertices[113] = new Vector3(-1.0f, 5.0f, 0.0f);

        uvs[110] = new Vector2(0.0f, 1.0f);
        uvs[111] = new Vector2(0.0f, 0.0f);
        uvs[112] = new Vector2(1.0f, 1.0f);
        uvs[113] = new Vector2(1.0f, 0.0f);

        vertices[114] = new Vector3(0.0f, 4.0f, 0.0f);
        vertices[115] = new Vector3(2.0f, 4.0f, 0.0f);
        vertices[116] = new Vector3(1.0f, 5.0f, 0.0f);

        uvs[114] = new Vector2(0.0f, 0.0f);
        uvs[115] = new Vector2(1.0f, 0.0f);
        uvs[116] = new Vector2(0.5f, 1.0f);

        vertices[117] = new Vector3(0.0f, 4.0f, -0.25f);
        vertices[118] = new Vector3(2.0f, 4.0f, -0.25f);
        vertices[119] = new Vector3(1.0f, 5.0f, -0.25f);

        uvs[117] = new Vector2(0.0f, 0.0f);
        uvs[118] = new Vector2(1.0f, 0.0f);
        uvs[119] = new Vector2(0.5f, 1.0f);

        vertices[120] = new Vector3(2.0f, 4.0f, 0.0f);
        vertices[121] = new Vector3(2.0f, 4.0f, -0.25f);
        vertices[122] = new Vector3(1.0f, 5.0f, 0.0f);
        vertices[123] = new Vector3(1.0f, 5.0f, -0.25f);

        uvs[120] = new Vector2(0.0f, 1.0f);
        uvs[121] = new Vector2(0.0f, 0.0f);
        uvs[122] = new Vector2(1.0f, 1.0f);
        uvs[123] = new Vector2(1.0f, 0.0f);

        vertices[124] = new Vector3(0.0f, 4.0f, -0.25f);
        vertices[125] = new Vector3(0.0f, 4.0f, 0.0f);
        vertices[126] = new Vector3(1.0f, 5.0f, -0.25f);
        vertices[127] = new Vector3(1.0f, 5.0f, 0.0f);

        uvs[124] = new Vector2(0.0f, 1.0f);
        uvs[125] = new Vector2(0.0f, 0.0f);
        uvs[126] = new Vector2(1.0f, 1.0f);
        uvs[127] = new Vector2(1.0f, 0.0f);

        vertices[128] = new Vector3(2.0f, 4.0f, 0.0f);
        vertices[129] = new Vector3(4.0f, 4.0f, 0.0f);
        vertices[130] = new Vector3(3.0f, 5.0f, 0.0f);

        uvs[128] = new Vector2(0.0f, 0.0f);
        uvs[129] = new Vector2(1.0f, 0.0f);
        uvs[130] = new Vector2(0.5f, 1.0f);

        vertices[131] = new Vector3(2.0f, 4.0f, -0.25f);
        vertices[132] = new Vector3(4.0f, 4.0f, -0.25f);
        vertices[133] = new Vector3(3.0f, 5.0f, -0.25f);

        uvs[131] = new Vector2(0.0f, 0.0f);
        uvs[132] = new Vector2(1.0f, 0.0f);
        uvs[133] = new Vector2(0.5f, 1.0f);

        vertices[134] = new Vector3(4.0f, 4.0f, 0.0f);
        vertices[135] = new Vector3(4.0f, 4.0f, -0.25f);
        vertices[136] = new Vector3(3.0f, 5.0f, 0.0f);
        vertices[137] = new Vector3(3.0f, 5.0f, -0.25f);

        uvs[134] = new Vector2(0.0f, 1.0f);
        uvs[135] = new Vector2(0.0f, 0.0f);
        uvs[136] = new Vector2(1.0f, 1.0f);
        uvs[137] = new Vector2(1.0f, 0.0f);

        vertices[138] = new Vector3(2.0f, 4.0f, -0.25f);
        vertices[139] = new Vector3(2.0f, 4.0f, 0.0f);
        vertices[140] = new Vector3(3.0f, 5.0f, -0.25f);
        vertices[141] = new Vector3(3.0f, 5.0f, 0.0f);

        uvs[138] = new Vector2(0.0f, 1.0f);
        uvs[139] = new Vector2(0.0f, 0.0f);
        uvs[140] = new Vector2(1.0f, 1.0f);
        uvs[141] = new Vector2(1.0f, 0.0f);

        vertices[142] = new Vector3(5.0f, 4.0f, 0.0f);
        vertices[143] = new Vector3(7.0f, 4.0f, 0.0f);
        vertices[144] = new Vector3(6.0f, 5.0f, 0.0f);

        uvs[142] = new Vector2(0.0f, 0.0f);
        uvs[143] = new Vector2(1.0f, 0.0f);
        uvs[144] = new Vector2(0.5f, 1.0f);

        vertices[145] = new Vector3(5.0f, 4.0f, -0.25f);
        vertices[146] = new Vector3(7.0f, 4.0f, -0.25f);
        vertices[147] = new Vector3(6.0f, 5.0f, -0.25f);

        uvs[145] = new Vector2(0.0f, 0.0f);
        uvs[146] = new Vector2(1.0f, 0.0f);
        uvs[147] = new Vector2(0.5f, 1.0f);

        vertices[148] = new Vector3(7.0f, 4.0f, 0.0f);
        vertices[149] = new Vector3(7.0f, 4.0f, -0.25f);
        vertices[150] = new Vector3(6.0f, 5.0f, 0.0f);
        vertices[151] = new Vector3(6.0f, 5.0f, -0.25f);

        uvs[148] = new Vector2(0.0f, 1.0f);
        uvs[149] = new Vector2(0.0f, 0.0f);
        uvs[150] = new Vector2(1.0f, 1.0f);
        uvs[151] = new Vector2(1.0f, 0.0f);

        vertices[152] = new Vector3(5.0f, 4.0f, -0.25f);
        vertices[153] = new Vector3(5.0f, 4.0f, 0.0f);
        vertices[154] = new Vector3(6.0f, 5.0f, -0.25f);
        vertices[155] = new Vector3(6.0f, 5.0f, 0.0f);

        uvs[152] = new Vector2(0.0f, 1.0f);
        uvs[153] = new Vector2(0.0f, 0.0f);
        uvs[154] = new Vector2(1.0f, 1.0f);
        uvs[155] = new Vector2(1.0f, 0.0f);

        vertices[156] = new Vector3(7.0f, 4.0f, 0.0f);
        vertices[157] = new Vector3(9.0f, 4.0f, 0.0f);
        vertices[158] = new Vector3(8.0f, 5.0f, 0.0f);

        uvs[156] = new Vector2(0.0f, 0.0f);
        uvs[157] = new Vector2(1.0f, 0.0f);
        uvs[158] = new Vector2(0.5f, 1.0f);

        vertices[159] = new Vector3(7.0f, 4.0f, -0.25f);
        vertices[160] = new Vector3(9.0f, 4.0f, -0.25f);
        vertices[161] = new Vector3(8.0f, 5.0f, -0.25f);

        uvs[159] = new Vector2(0.0f, 0.0f);
        uvs[160] = new Vector2(1.0f, 0.0f);
        uvs[161] = new Vector2(0.5f, 1.0f);

        vertices[162] = new Vector3(9.0f, 4.0f, 0.0f);
        vertices[163] = new Vector3(9.0f, 4.0f, -0.25f);
        vertices[164] = new Vector3(8.0f, 5.0f, 0.0f);
        vertices[165] = new Vector3(8.0f, 5.0f, -0.25f);

        uvs[162] = new Vector2(0.0f, 1.0f);
        uvs[163] = new Vector2(0.0f, 0.0f);
        uvs[164] = new Vector2(1.0f, 1.0f);
        uvs[165] = new Vector2(1.0f, 0.0f);

        vertices[166] = new Vector3(7.0f, 4.0f, -0.25f);
        vertices[167] = new Vector3(7.0f, 4.0f, 0.0f);
        vertices[168] = new Vector3(8.0f, 5.0f, -0.25f);
        vertices[169] = new Vector3(8.0f, 5.0f, 0.0f);

        uvs[166] = new Vector2(0.0f, 1.0f);
        uvs[167] = new Vector2(0.0f, 0.0f);
        uvs[168] = new Vector2(1.0f, 1.0f);
        uvs[169] = new Vector2(1.0f, 0.0f);

        vertices[170] = new Vector3(9.0f, 4.0f, 0.0f);
        vertices[171] = new Vector3(11.0f, 4.0f, 0.0f);
        vertices[172] = new Vector3(10.0f, 5.0f, 0.0f);

        uvs[170] = new Vector2(0.0f, 0.0f);
        uvs[171] = new Vector2(1.0f, 0.0f);
        uvs[172] = new Vector2(0.5f, 1.0f);

        vertices[173] = new Vector3(9.0f, 4.0f, -0.25f);
        vertices[174] = new Vector3(11.0f, 4.0f, -0.25f);
        vertices[175] = new Vector3(10.0f, 5.0f, -0.25f);

        uvs[173] = new Vector2(0.0f, 0.0f);
        uvs[174] = new Vector2(1.0f, 0.0f);
        uvs[175] = new Vector2(0.5f, 1.0f);

        vertices[176] = new Vector3(11.0f, 4.0f, 0.0f);
        vertices[177] = new Vector3(11.0f, 4.0f, -0.25f);
        vertices[178] = new Vector3(10.0f, 5.0f, 0.0f);
        vertices[179] = new Vector3(10.0f, 5.0f, -0.25f);

        uvs[176] = new Vector2(0.0f, 1.0f);
        uvs[177] = new Vector2(0.0f, 0.0f);
        uvs[178] = new Vector2(1.0f, 1.0f);
        uvs[179] = new Vector2(1.0f, 0.0f);

        vertices[180] = new Vector3(9.0f, 4.0f, -0.25f);
        vertices[181] = new Vector3(9.0f, 4.0f, 0.0f);
        vertices[182] = new Vector3(10.0f, 5.0f, -0.25f);
        vertices[183] = new Vector3(10.0f, 5.0f, 0.0f);

        uvs[180] = new Vector2(0.0f, 1.0f);
        uvs[181] = new Vector2(0.0f, 0.0f);
        uvs[182] = new Vector2(1.0f, 1.0f);
        uvs[183] = new Vector2(1.0f, 0.0f);

        vertices[184] = new Vector3(11.0f, 4.0f, 0.0f);
        vertices[185] = new Vector3(13.0f, 4.0f, 0.0f);
        vertices[186] = new Vector3(12.0f, 5.0f, 0.0f);

        uvs[184] = new Vector2(0.0f, 0.0f);
        uvs[185] = new Vector2(1.0f, 0.0f);
        uvs[186] = new Vector2(0.5f, 1.0f);

        vertices[187] = new Vector3(11.0f, 4.0f, -0.25f);
        vertices[188] = new Vector3(13.0f, 4.0f, -0.25f);
        vertices[189] = new Vector3(12.0f, 5.0f, -0.25f);

        uvs[187] = new Vector2(0.0f, 0.0f);
        uvs[188] = new Vector2(1.0f, 0.0f);
        uvs[189] = new Vector2(0.5f, 1.0f);

        vertices[190] = new Vector3(13.0f, 4.0f, 0.0f);
        vertices[191] = new Vector3(13.0f, 4.0f, -0.25f);
        vertices[192] = new Vector3(12.0f, 5.0f, 0.0f);
        vertices[193] = new Vector3(12.0f, 5.0f, -0.25f);

        uvs[190] = new Vector2(0.0f, 1.0f);
        uvs[191] = new Vector2(0.0f, 0.0f);
        uvs[192] = new Vector2(1.0f, 1.0f);
        uvs[193] = new Vector2(1.0f, 0.0f);

        vertices[194] = new Vector3(11.0f, 4.0f, -0.25f);
        vertices[195] = new Vector3(11.0f, 4.0f, 0.0f);
        vertices[196] = new Vector3(12.0f, 5.0f, -0.25f);
        vertices[197] = new Vector3(12.0f, 5.0f, 0.0f);

        uvs[194] = new Vector2(0.0f, 1.0f);
        uvs[195] = new Vector2(0.0f, 0.0f);
        uvs[196] = new Vector2(1.0f, 1.0f);
        uvs[197] = new Vector2(1.0f, 0.0f);
        
        vertices[198] = new Vector3(13.0f, 4.0f, 0.0f);
        vertices[199] = new Vector3(15.0f, 4.0f, 0.0f);
        vertices[200] = new Vector3(14.0f, 5.0f, 0.0f);

        uvs[198] = new Vector2(0.0f, 0.0f);
        uvs[199] = new Vector2(1.0f, 0.0f);
        uvs[200] = new Vector2(0.5f, 1.0f);

        vertices[201] = new Vector3(13.0f, 4.0f, -0.25f);
        vertices[202] = new Vector3(15.0f, 4.0f, -0.25f);
        vertices[203] = new Vector3(14.0f, 5.0f, -0.25f);

        uvs[201] = new Vector2(0.0f, 0.0f);
        uvs[202] = new Vector2(1.0f, 0.0f);
        uvs[203] = new Vector2(0.5f, 1.0f);

        vertices[204] = new Vector3(15.0f, 4.0f, 0.0f);
        vertices[205] = new Vector3(15.0f, 4.0f, -0.25f);
        vertices[206] = new Vector3(14.0f, 5.0f, 0.0f);
        vertices[207] = new Vector3(14.0f, 5.0f, -0.25f);

        uvs[204] = new Vector2(0.0f, 1.0f);
        uvs[205] = new Vector2(0.0f, 0.0f);
        uvs[206] = new Vector2(1.0f, 1.0f);
        uvs[207] = new Vector2(1.0f, 0.0f);

        vertices[208] = new Vector3(13.0f, 4.0f, -0.25f);
        vertices[209] = new Vector3(13.0f, 4.0f, 0.0f);
        vertices[210] = new Vector3(14.0f, 5.0f, -0.25f);
        vertices[211] = new Vector3(14.0f, 5.0f, 0.0f);

        uvs[208] = new Vector2(0.0f, 1.0f);
        uvs[209] = new Vector2(0.0f, 0.0f);
        uvs[210] = new Vector2(1.0f, 1.0f);
        uvs[211] = new Vector2(1.0f, 0.0f);

        vertices[212] = new Vector3(-6.0f, 4.0f, 0.0f);
        vertices[213] = new Vector3(-6.0f, 4.0f, 2.0f);
        vertices[214] = new Vector3(-6.0f, 5.0f, 1.0f);

        uvs[212] = new Vector2(0.0f, 0.0f);
        uvs[213] = new Vector2(1.0f, 0.0f);
        uvs[214] = new Vector2(0.5f, 1.0f);

        vertices[215] = new Vector3(-5.75f, 4.0f, 0.0f);
        vertices[216] = new Vector3(-5.75f, 4.0f, 2.0f);
        vertices[217] = new Vector3(-5.75f, 5.0f, 1.0f);

        uvs[215] = new Vector2(0.0f, 0.0f);
        uvs[216] = new Vector2(1.0f, 0.0f);
        uvs[217] = new Vector2(0.5f, 1.0f);

        vertices[218] = new Vector3(-6.0f, 4.0f, 2.0f);
        vertices[219] = new Vector3(-5.75f, 4.0f, 2.0f);
        vertices[220] = new Vector3(-6.0f, 5.0f, 1.0f);
        vertices[221] = new Vector3(-5.75f, 5.0f, 1.0f);

        uvs[218] = new Vector2(0.0f, 1.0f);
        uvs[219] = new Vector2(0.0f, 0.0f);
        uvs[220] = new Vector2(1.0f, 1.0f);
        uvs[221] = new Vector2(1.0f, 0.0f);

        vertices[222] = new Vector3(-5.75f, 4.0f, 0.0f);
        vertices[223] = new Vector3(-6.0f, 4.0f, 0.0f);
        vertices[224] = new Vector3(-5.75f, 5.0f, 1.0f);
        vertices[225] = new Vector3(-6.0f, 5.0f, 1.0f);

        uvs[222] = new Vector2(0.0f, 1.0f);
        uvs[223] = new Vector2(0.0f, 0.0f);
        uvs[224] = new Vector2(1.0f, 1.0f);
        uvs[225] = new Vector2(1.0f, 0.0f);

        vertices[226] = new Vector3(-6.0f, 4.0f, 2.0f);
        vertices[227] = new Vector3(-6.0f, 4.0f, 4.0f);
        vertices[228] = new Vector3(-6.0f, 5.0f, 3.0f);

        uvs[226] = new Vector2(0.0f, 0.0f);
        uvs[227] = new Vector2(1.0f, 0.0f);
        uvs[228] = new Vector2(0.5f, 1.0f);

        vertices[229] = new Vector3(-5.75f, 4.0f, 2.0f);
        vertices[230] = new Vector3(-5.75f, 4.0f, 4.0f);
        vertices[231] = new Vector3(-5.75f, 5.0f, 3.0f);

        uvs[229] = new Vector2(0.0f, 0.0f);
        uvs[230] = new Vector2(1.0f, 0.0f);
        uvs[231] = new Vector2(0.5f, 1.0f);
        
        vertices[232] = new Vector3(-6.0f, 4.0f, 4.0f);
        vertices[233] = new Vector3(-5.75f, 4.0f, 4.0f);
        vertices[234] = new Vector3(-6.0f, 5.0f, 3.0f);
        vertices[235] = new Vector3(-5.75f, 5.0f, 3.0f);

        uvs[232] = new Vector2(0.0f, 1.0f);
        uvs[233] = new Vector2(0.0f, 0.0f);
        uvs[234] = new Vector2(1.0f, 1.0f);
        uvs[235] = new Vector2(1.0f, 0.0f);

        vertices[236] = new Vector3(-5.75f, 4.0f, 2.0f);
        vertices[237] = new Vector3(-6.0f, 4.0f, 2.0f);
        vertices[238] = new Vector3(-5.75f, 5.0f, 3.0f);
        vertices[239] = new Vector3(-6.0f, 5.0f, 3.0f);

        uvs[236] = new Vector2(0.0f, 1.0f);
        uvs[237] = new Vector2(0.0f, 0.0f);
        uvs[238] = new Vector2(1.0f, 1.0f);
        uvs[239] = new Vector2(1.0f, 0.0f);

        vertices[240] = new Vector3(-6.0f, 4.0f, 4.0f);
        vertices[241] = new Vector3(-6.0f, 4.0f, 6.0f);
        vertices[242] = new Vector3(-6.0f, 5.0f, 5.0f);

        uvs[240] = new Vector2(0.0f, 0.0f);
        uvs[241] = new Vector2(1.0f, 0.0f);
        uvs[242] = new Vector2(0.5f, 1.0f);

        vertices[243] = new Vector3(-5.75f, 4.0f, 4.0f);
        vertices[244] = new Vector3(-5.75f, 4.0f, 6.0f);
        vertices[245] = new Vector3(-5.75f, 5.0f, 5.0f);

        uvs[243] = new Vector2(0.0f, 0.0f);
        uvs[244] = new Vector2(1.0f, 0.0f);
        uvs[245] = new Vector2(0.5f, 1.0f);

        vertices[246] = new Vector3(-6.0f, 4.0f, 6.0f);
        vertices[247] = new Vector3(-5.75f, 4.0f, 6.0f);
        vertices[248] = new Vector3(-6.0f, 5.0f, 5.0f);
        vertices[249] = new Vector3(-5.75f, 5.0f, 5.0f);

        uvs[246] = new Vector2(0.0f, 1.0f);
        uvs[247] = new Vector2(0.0f, 0.0f);
        uvs[248] = new Vector2(1.0f, 1.0f);
        uvs[249] = new Vector2(1.0f, 0.0f);
        
        vertices[250] = new Vector3(-5.75f, 4.0f, 4.0f);
        vertices[251] = new Vector3(-6.0f, 4.0f, 4.0f);
        vertices[252] = new Vector3(-5.75f, 5.0f, 5.0f);
        vertices[253] = new Vector3(-6.0f, 5.0f, 5.0f);

        uvs[250] = new Vector2(0.0f, 1.0f);
        uvs[251] = new Vector2(0.0f, 0.0f);
        uvs[252] = new Vector2(1.0f, 1.0f);
        uvs[253] = new Vector2(1.0f, 0.0f);

        vertices[460] = new Vector3(-6.0f, 4.0f, 6.0f);
        vertices[461] = new Vector3(-6.0f, 4.0f, 8.0f);
        vertices[462] = new Vector3(-6.0f, 5.0f, 7.0f);

        uvs[460] = new Vector2(0.0f, 0.0f);
        uvs[461] = new Vector2(1.0f, 0.0f);
        uvs[462] = new Vector2(0.5f, 1.0f);

        vertices[463] = new Vector3(-5.75f, 4.0f, 6.0f);
        vertices[464] = new Vector3(-5.75f, 4.0f, 8.0f);
        vertices[465] = new Vector3(-5.75f, 5.0f, 7.0f);

        uvs[463] = new Vector2(0.0f, 0.0f);
        uvs[464] = new Vector2(1.0f, 0.0f);
        uvs[465] = new Vector2(0.5f, 1.0f);
        
        vertices[466] = new Vector3(-6.0f, 4.0f, 8.0f);
        vertices[467] = new Vector3(-5.75f, 4.0f, 8.0f);
        vertices[468] = new Vector3(-6.0f, 5.0f, 7.0f);
        vertices[469] = new Vector3(-5.75f, 5.0f, 7.0f);

        uvs[466] = new Vector2(0.0f, 1.0f);
        uvs[467] = new Vector2(0.0f, 0.0f);
        uvs[468] = new Vector2(1.0f, 1.0f);
        uvs[469] = new Vector2(1.0f, 0.0f);

        vertices[470] = new Vector3(-5.75f, 4.0f, 6.0f);
        vertices[471] = new Vector3(-6.0f, 4.0f, 6.0f);
        vertices[472] = new Vector3(-5.75f, 5.0f, 7.0f);
        vertices[473] = new Vector3(-6.0f, 5.0f, 7.0f);

        uvs[470] = new Vector2(0.0f, 1.0f);
        uvs[471] = new Vector2(0.0f, 0.0f);
        uvs[472] = new Vector2(1.0f, 1.0f);
        uvs[473] = new Vector2(1.0f, 0.0f);

        vertices[264] = new Vector3(-6.0f, 4.0f, 8.0f);
        vertices[265] = new Vector3(-6.0f, 4.0f, 10.0f);
        vertices[266] = new Vector3(-6.0f, 5.0f, 9.0f);

        uvs[264] = new Vector2(0.0f, 0.0f);
        uvs[265] = new Vector2(1.0f, 0.0f);
        uvs[266] = new Vector2(0.5f, 1.0f);

        vertices[267] = new Vector3(-5.75f, 4.0f, 8.0f);
        vertices[268] = new Vector3(-5.75f, 4.0f, 10.0f);
        vertices[269] = new Vector3(-5.75f, 5.0f, 9.0f);

        uvs[267] = new Vector2(0.0f, 0.0f);
        uvs[268] = new Vector2(1.0f, 0.0f);
        uvs[269] = new Vector2(0.5f, 1.0f);
        
        vertices[270] = new Vector3(-6.0f, 4.0f, 10.0f);
        vertices[271] = new Vector3(-5.75f, 4.0f, 10.0f);
        vertices[272] = new Vector3(-6.0f, 5.0f, 9.0f);
        vertices[273] = new Vector3(-5.75f, 5.0f, 9.0f);

        uvs[270] = new Vector2(0.0f, 1.0f);
        uvs[271] = new Vector2(0.0f, 0.0f);
        uvs[272] = new Vector2(1.0f, 1.0f);
        uvs[273] = new Vector2(1.0f, 0.0f);
        
        vertices[274] = new Vector3(-5.75f, 4.0f, 8.0f);
        vertices[275] = new Vector3(-6.0f, 4.0f, 8.0f);
        vertices[276] = new Vector3(-5.75f, 5.0f, 9.0f);
        vertices[277] = new Vector3(-6.0f, 5.0f, 9.0f);

        uvs[274] = new Vector2(0.0f, 1.0f);
        uvs[275] = new Vector2(0.0f, 0.0f);
        uvs[276] = new Vector2(1.0f, 1.0f);
        uvs[277] = new Vector2(1.0f, 0.0f);

        vertices[278] = new Vector3(-6.0f, 4.0f, 10.0f);
        vertices[279] = new Vector3(-6.0f, 4.0f, 12.0f);
        vertices[280] = new Vector3(-6.0f, 5.0f, 11.0f);

        uvs[278] = new Vector2(0.0f, 0.0f);
        uvs[279] = new Vector2(1.0f, 0.0f);
        uvs[280] = new Vector2(0.5f, 1.0f);

        vertices[281] = new Vector3(-5.75f, 4.0f, 10.0f);
        vertices[282] = new Vector3(-5.75f, 4.0f, 12.0f);
        vertices[283] = new Vector3(-5.75f, 5.0f, 11.0f);

        uvs[281] = new Vector2(0.0f, 0.0f);
        uvs[282] = new Vector2(1.0f, 0.0f);
        uvs[283] = new Vector2(0.5f, 1.0f);
        
        vertices[284] = new Vector3(-6.0f, 4.0f, 12.0f);
        vertices[285] = new Vector3(-5.75f, 4.0f, 12.0f);
        vertices[286] = new Vector3(-6.0f, 5.0f, 11.0f);
        vertices[287] = new Vector3(-5.75f, 5.0f, 11.0f);

        uvs[284] = new Vector2(0.0f, 1.0f);
        uvs[285] = new Vector2(0.0f, 0.0f);
        uvs[286] = new Vector2(1.0f, 1.0f);
        uvs[287] = new Vector2(1.0f, 0.0f);
        
        vertices[288] = new Vector3(-5.75f, 4.0f, 10.0f);
        vertices[289] = new Vector3(-6.0f, 4.0f, 10.0f);
        vertices[290] = new Vector3(-5.75f, 5.0f, 11.0f);
        vertices[291] = new Vector3(-6.0f, 5.0f, 11.0f);

        uvs[288] = new Vector2(0.0f, 1.0f);
        uvs[289] = new Vector2(0.0f, 0.0f);
        uvs[290] = new Vector2(1.0f, 1.0f);
        uvs[291] = new Vector2(1.0f, 0.0f);

        vertices[292] = new Vector3(-6.0f, 4.0f, 12.0f);
        vertices[293] = new Vector3(-6.0f, 4.0f, 14.0f);
        vertices[294] = new Vector3(-6.0f, 5.0f, 13.0f);

        uvs[292] = new Vector2(0.0f, 0.0f);
        uvs[293] = new Vector2(1.0f, 0.0f);
        uvs[294] = new Vector2(0.5f, 1.0f);

        vertices[295] = new Vector3(-5.75f, 4.0f, 12.0f);
        vertices[296] = new Vector3(-5.75f, 4.0f, 14.0f);
        vertices[297] = new Vector3(-5.75f, 5.0f, 13.0f);

        uvs[295] = new Vector2(0.0f, 0.0f);
        uvs[296] = new Vector2(1.0f, 0.0f);
        uvs[297] = new Vector2(0.5f, 1.0f);
        
        vertices[298] = new Vector3(-6.0f, 4.0f, 14.0f);
        vertices[299] = new Vector3(-5.75f, 4.0f, 14.0f);
        vertices[300] = new Vector3(-6.0f, 5.0f, 13.0f);
        vertices[301] = new Vector3(-5.75f, 5.0f, 13.0f);

        uvs[298] = new Vector2(0.0f, 1.0f);
        uvs[299] = new Vector2(0.0f, 0.0f);
        uvs[300] = new Vector2(1.0f, 1.0f);
        uvs[301] = new Vector2(1.0f, 0.0f);
        
        vertices[302] = new Vector3(-5.75f, 4.0f, 12.0f);
        vertices[303] = new Vector3(-6.0f, 4.0f, 12.0f);
        vertices[304] = new Vector3(-5.75f, 5.0f, 13.0f);
        vertices[305] = new Vector3(-6.0f, 5.0f, 13.0f);

        uvs[302] = new Vector2(0.0f, 1.0f);
        uvs[303] = new Vector2(0.0f, 0.0f);
        uvs[304] = new Vector2(1.0f, 1.0f);
        uvs[305] = new Vector2(1.0f, 0.0f);

        vertices[306] = new Vector3(-6.0f, 4.0f, 14.0f);
        vertices[307] = new Vector3(-6.0f, 4.0f, 16.0f);
        vertices[308] = new Vector3(-6.0f, 5.0f, 15.0f);

        uvs[306] = new Vector2(0.0f, 0.0f);
        uvs[307] = new Vector2(1.0f, 0.0f);
        uvs[308] = new Vector2(0.5f, 1.0f);

        vertices[309] = new Vector3(-5.75f, 4.0f, 14.0f);
        vertices[310] = new Vector3(-5.75f, 4.0f, 16.0f);
        vertices[311] = new Vector3(-5.75f, 5.0f, 15.0f);

        uvs[309] = new Vector2(0.0f, 0.0f);
        uvs[310] = new Vector2(1.0f, 0.0f);
        uvs[311] = new Vector2(0.5f, 1.0f);
        
        vertices[312] = new Vector3(-6.0f, 4.0f, 16.0f);
        vertices[313] = new Vector3(-5.75f, 4.0f, 16.0f);
        vertices[314] = new Vector3(-6.0f, 5.0f, 15.0f);
        vertices[315] = new Vector3(-5.75f, 5.0f, 15.0f);

        uvs[312] = new Vector2(0.0f, 1.0f);
        uvs[313] = new Vector2(0.0f, 0.0f);
        uvs[314] = new Vector2(1.0f, 1.0f);
        uvs[315] = new Vector2(1.0f, 0.0f);
        
        vertices[316] = new Vector3(-5.75f, 4.0f, 14.0f);
        vertices[317] = new Vector3(-6.0f, 4.0f, 14.0f);
        vertices[318] = new Vector3(-5.75f, 5.0f, 15.0f);
        vertices[319] = new Vector3(-6.0f, 5.0f, 15.0f);

        uvs[316] = new Vector2(0.0f, 1.0f);
        uvs[317] = new Vector2(0.0f, 0.0f);
        uvs[318] = new Vector2(1.0f, 1.0f);
        uvs[319] = new Vector2(1.0f, 0.0f);

        vertices[320] = new Vector3(-6.0f, 4.0f, 16.0f);
        vertices[321] = new Vector3(-6.0f, 4.0f, 18.0f);
        vertices[322] = new Vector3(-6.0f, 5.0f, 17.0f);

        uvs[320] = new Vector2(0.0f, 0.0f);
        uvs[321] = new Vector2(1.0f, 0.0f);
        uvs[322] = new Vector2(0.5f, 1.0f);

        vertices[323] = new Vector3(-5.75f, 4.0f, 16.0f);
        vertices[324] = new Vector3(-5.75f, 4.0f, 18.0f);
        vertices[325] = new Vector3(-5.75f, 5.0f, 17.0f);

        uvs[323] = new Vector2(0.0f, 0.0f);
        uvs[324] = new Vector2(1.0f, 0.0f);
        uvs[325] = new Vector2(0.5f, 1.0f);
        
        vertices[326] = new Vector3(-6.0f, 4.0f, 18.0f);
        vertices[327] = new Vector3(-5.75f, 4.0f, 18.0f);
        vertices[328] = new Vector3(-6.0f, 5.0f, 17.0f);
        vertices[329] = new Vector3(-5.75f, 5.0f, 17.0f);

        uvs[326] = new Vector2(0.0f, 1.0f);
        uvs[327] = new Vector2(0.0f, 0.0f);
        uvs[328] = new Vector2(1.0f, 1.0f);
        uvs[329] = new Vector2(1.0f, 0.0f);
        
        vertices[330] = new Vector3(-5.75f, 4.0f, 16.0f);
        vertices[331] = new Vector3(-6.0f, 4.0f, 16.0f);
        vertices[332] = new Vector3(-5.75f, 5.0f, 17.0f);
        vertices[333] = new Vector3(-6.0f, 5.0f, 17.0f);

        uvs[330] = new Vector2(0.0f, 1.0f);
        uvs[331] = new Vector2(0.0f, 0.0f);
        uvs[332] = new Vector2(1.0f, 1.0f);
        uvs[333] = new Vector2(1.0f, 0.0f);

        vertices[334] = new Vector3(15.0f, 4.0f, 0.0f);
        vertices[335] = new Vector3(15.0f, 4.0f, 2.0f);
        vertices[336] = new Vector3(15.0f, 5.0f, 1.0f);

        uvs[334] = new Vector2(0.0f, 0.0f);
        uvs[335] = new Vector2(1.0f, 0.0f);
        uvs[336] = new Vector2(0.5f, 1.0f);

        vertices[337] = new Vector3(14.75f, 4.0f, 0.0f);
        vertices[338] = new Vector3(14.75f, 4.0f, 2.0f);
        vertices[339] = new Vector3(14.75f, 5.0f, 1.0f);

        uvs[337] = new Vector2(0.0f, 0.0f);
        uvs[338] = new Vector2(1.0f, 0.0f);
        uvs[339] = new Vector2(0.5f, 1.0f);
        
        vertices[340] = new Vector3(15.0f, 4.0f, 2.0f);
        vertices[341] = new Vector3(14.75f, 4.0f, 2.0f);
        vertices[342] = new Vector3(15.0f, 5.0f, 1.0f);
        vertices[343] = new Vector3(14.75f, 5.0f, 1.0f);

        uvs[340] = new Vector2(0.0f, 1.0f);
        uvs[341] = new Vector2(0.0f, 0.0f);
        uvs[342] = new Vector2(1.0f, 1.0f);
        uvs[343] = new Vector2(1.0f, 0.0f);
        
        vertices[344] = new Vector3(14.75f, 4.0f, 0.0f);
        vertices[345] = new Vector3(15.0f, 4.0f, 0.0f);
        vertices[346] = new Vector3(14.75f, 5.0f, 1.0f);
        vertices[347] = new Vector3(15.0f, 5.0f, 1.0f);

        uvs[344] = new Vector2(0.0f, 1.0f);
        uvs[345] = new Vector2(0.0f, 0.0f);
        uvs[346] = new Vector2(1.0f, 1.0f);
        uvs[347] = new Vector2(1.0f, 0.0f);

        vertices[348] = new Vector3(15.0f, 4.0f, 2.0f);
        vertices[349] = new Vector3(15.0f, 4.0f, 4.0f);
        vertices[350] = new Vector3(15.0f, 5.0f, 3.0f);

        uvs[348] = new Vector2(0.0f, 0.0f);
        uvs[349] = new Vector2(1.0f, 0.0f);
        uvs[350] = new Vector2(0.5f, 1.0f);

        vertices[351] = new Vector3(14.75f, 4.0f, 2.0f);
        vertices[352] = new Vector3(14.75f, 4.0f, 4.0f);
        vertices[353] = new Vector3(14.75f, 5.0f, 3.0f);

        uvs[351] = new Vector2(0.0f, 0.0f);
        uvs[352] = new Vector2(1.0f, 0.0f);
        uvs[353] = new Vector2(0.5f, 1.0f);
        
        vertices[354] = new Vector3(15.0f, 4.0f, 4.0f);
        vertices[355] = new Vector3(14.75f, 4.0f, 4.0f);
        vertices[356] = new Vector3(15.0f, 5.0f, 3.0f);
        vertices[357] = new Vector3(14.75f, 5.0f, 3.0f);

        uvs[354] = new Vector2(0.0f, 1.0f);
        uvs[355] = new Vector2(0.0f, 0.0f);
        uvs[356] = new Vector2(1.0f, 1.0f);
        uvs[357] = new Vector2(1.0f, 0.0f);
        
        vertices[358] = new Vector3(14.75f, 4.0f, 2.0f);
        vertices[359] = new Vector3(15.0f, 4.0f, 2.0f);
        vertices[360] = new Vector3(14.75f, 5.0f, 3.0f);
        vertices[361] = new Vector3(15.0f, 5.0f, 3.0f);

        uvs[358] = new Vector2(0.0f, 1.0f);
        uvs[359] = new Vector2(0.0f, 0.0f);
        uvs[360] = new Vector2(1.0f, 1.0f);
        uvs[361] = new Vector2(1.0f, 0.0f);

        vertices[362] = new Vector3(15.0f, 4.0f, 4.0f);
        vertices[363] = new Vector3(15.0f, 4.0f, 6.0f);
        vertices[364] = new Vector3(15.0f, 5.0f, 5.0f);

        uvs[362] = new Vector2(0.0f, 0.0f);
        uvs[363] = new Vector2(1.0f, 0.0f);
        uvs[364] = new Vector2(0.5f, 1.0f);

        vertices[365] = new Vector3(14.75f, 4.0f, 4.0f);
        vertices[366] = new Vector3(14.75f, 4.0f, 6.0f);
        vertices[367] = new Vector3(14.75f, 5.0f, 5.0f);

        uvs[365] = new Vector2(0.0f, 0.0f);
        uvs[366] = new Vector2(1.0f, 0.0f);
        uvs[367] = new Vector2(0.5f, 1.0f);
        
        vertices[368] = new Vector3(15.0f, 4.0f, 6.0f);
        vertices[369] = new Vector3(14.75f, 4.0f, 6.0f);
        vertices[370] = new Vector3(15.0f, 5.0f, 5.0f);
        vertices[371] = new Vector3(14.75f, 5.0f, 5.0f);

        uvs[368] = new Vector2(0.0f, 1.0f);
        uvs[369] = new Vector2(0.0f, 0.0f);
        uvs[370] = new Vector2(1.0f, 1.0f);
        uvs[371] = new Vector2(1.0f, 0.0f);
        
        vertices[372] = new Vector3(14.75f, 4.0f, 4.0f);
        vertices[373] = new Vector3(15.0f, 4.0f, 4.0f);
        vertices[374] = new Vector3(14.75f, 5.0f, 5.0f);
        vertices[375] = new Vector3(15.0f, 5.0f, 5.0f);

        uvs[372] = new Vector2(0.0f, 1.0f);
        uvs[373] = new Vector2(0.0f, 0.0f);
        uvs[374] = new Vector2(1.0f, 1.0f);
        uvs[375] = new Vector2(1.0f, 0.0f);

        vertices[480] = new Vector3(15.0f, 4.0f, 6.0f);
        vertices[481] = new Vector3(15.0f, 4.0f, 8.0f);
        vertices[482] = new Vector3(15.0f, 5.0f, 7.0f);

        uvs[480] = new Vector2(0.0f, 0.0f);
        uvs[481] = new Vector2(1.0f, 0.0f);
        uvs[482] = new Vector2(0.5f, 1.0f);

        vertices[483] = new Vector3(14.75f, 4.0f, 6.0f);
        vertices[484] = new Vector3(14.75f, 4.0f, 8.0f);
        vertices[485] = new Vector3(14.75f, 5.0f, 7.0f);

        uvs[483] = new Vector2(0.0f, 0.0f);
        uvs[484] = new Vector2(1.0f, 0.0f);
        uvs[485] = new Vector2(0.5f, 1.0f);
        
        vertices[486] = new Vector3(15.0f, 4.0f, 8.0f);
        vertices[487] = new Vector3(14.75f, 4.0f, 8.0f);
        vertices[488] = new Vector3(15.0f, 5.0f, 7.0f);
        vertices[489] = new Vector3(14.75f, 5.0f, 7.0f);

        uvs[486] = new Vector2(0.0f, 1.0f);
        uvs[487] = new Vector2(0.0f, 0.0f);
        uvs[488] = new Vector2(1.0f, 1.0f);
        uvs[489] = new Vector2(1.0f, 0.0f);
        
        vertices[490] = new Vector3(14.75f, 4.0f, 6.0f);
        vertices[491] = new Vector3(15.0f, 4.0f, 6.0f);
        vertices[492] = new Vector3(14.75f, 5.0f, 7.0f);
        vertices[493] = new Vector3(15.0f, 5.0f, 7.0f);

        uvs[490] = new Vector2(0.0f, 1.0f);
        uvs[491] = new Vector2(0.0f, 0.0f);
        uvs[492] = new Vector2(1.0f, 1.0f);
        uvs[493] = new Vector2(1.0f, 0.0f);

        vertices[386] = new Vector3(15.0f, 4.0f, 8.0f);
        vertices[387] = new Vector3(15.0f, 4.0f, 10.0f);
        vertices[388] = new Vector3(15.0f, 5.0f, 9.0f);

        uvs[386] = new Vector2(0.0f, 0.0f);
        uvs[387] = new Vector2(1.0f, 0.0f);
        uvs[388] = new Vector2(0.5f, 1.0f);

        vertices[389] = new Vector3(14.75f, 4.0f, 8.0f);
        vertices[390] = new Vector3(14.75f, 4.0f, 10.0f);
        vertices[391] = new Vector3(14.75f, 5.0f, 9.0f);

        uvs[389] = new Vector2(0.0f, 0.0f);
        uvs[390] = new Vector2(1.0f, 0.0f);
        uvs[391] = new Vector2(0.5f, 1.0f);
        
        vertices[392] = new Vector3(15.0f, 4.0f, 10.0f);
        vertices[393] = new Vector3(14.75f, 4.0f, 10.0f);
        vertices[394] = new Vector3(15.0f, 5.0f, 9.0f);
        vertices[395] = new Vector3(14.75f, 5.0f, 9.0f);

        uvs[392] = new Vector2(0.0f, 1.0f);
        uvs[393] = new Vector2(0.0f, 0.0f);
        uvs[394] = new Vector2(1.0f, 1.0f);
        uvs[395] = new Vector2(1.0f, 0.0f);
        
        vertices[396] = new Vector3(14.75f, 4.0f, 8.0f);
        vertices[397] = new Vector3(15.0f, 4.0f, 8.0f);
        vertices[398] = new Vector3(14.75f, 5.0f, 9.0f);
        vertices[399] = new Vector3(15.0f, 5.0f, 9.0f);

        uvs[396] = new Vector2(0.0f, 1.0f);
        uvs[397] = new Vector2(0.0f, 0.0f);
        uvs[398] = new Vector2(1.0f, 1.0f);
        uvs[399] = new Vector2(1.0f, 0.0f);

        vertices[400] = new Vector3(15.0f, 4.0f, 10.0f);
        vertices[401] = new Vector3(15.0f, 4.0f, 12.0f);
        vertices[402] = new Vector3(15.0f, 5.0f, 11.0f);

        uvs[400] = new Vector2(0.0f, 0.0f);
        uvs[401] = new Vector2(1.0f, 0.0f);
        uvs[402] = new Vector2(0.5f, 1.0f);

        vertices[403] = new Vector3(14.75f, 4.0f, 10.0f);
        vertices[404] = new Vector3(14.75f, 4.0f, 12.0f);
        vertices[405] = new Vector3(14.75f, 5.0f, 11.0f);

        uvs[403] = new Vector2(0.0f, 0.0f);
        uvs[404] = new Vector2(1.0f, 0.0f);
        uvs[405] = new Vector2(0.5f, 1.0f);
        
        vertices[406] = new Vector3(15.0f, 4.0f, 12.0f);
        vertices[407] = new Vector3(14.75f, 4.0f, 12.0f);
        vertices[408] = new Vector3(15.0f, 5.0f, 11.0f);
        vertices[409] = new Vector3(14.75f, 5.0f, 11.0f);

        uvs[406] = new Vector2(0.0f, 1.0f);
        uvs[407] = new Vector2(0.0f, 0.0f);
        uvs[408] = new Vector2(1.0f, 1.0f);
        uvs[409] = new Vector2(1.0f, 0.0f);
        
        vertices[410] = new Vector3(14.75f, 4.0f, 10.0f);
        vertices[411] = new Vector3(15.0f, 4.0f, 10.0f);
        vertices[412] = new Vector3(14.75f, 5.0f, 11.0f);
        vertices[413] = new Vector3(15.0f, 5.0f, 11.0f);

        uvs[410] = new Vector2(0.0f, 1.0f);
        uvs[411] = new Vector2(0.0f, 0.0f);
        uvs[412] = new Vector2(1.0f, 1.0f);
        uvs[413] = new Vector2(1.0f, 0.0f);

        vertices[414] = new Vector3(15.0f, 4.0f, 12.0f);
        vertices[415] = new Vector3(15.0f, 4.0f, 14.0f);
        vertices[416] = new Vector3(15.0f, 5.0f, 13.0f);

        uvs[414] = new Vector2(0.0f, 0.0f);
        uvs[415] = new Vector2(1.0f, 0.0f);
        uvs[416] = new Vector2(0.5f, 1.0f);

        vertices[417] = new Vector3(14.75f, 4.0f, 12.0f);
        vertices[418] = new Vector3(14.75f, 4.0f, 14.0f);
        vertices[419] = new Vector3(14.75f, 5.0f, 13.0f);

        uvs[417] = new Vector2(0.0f, 0.0f);
        uvs[418] = new Vector2(1.0f, 0.0f);
        uvs[419] = new Vector2(0.5f, 1.0f);
        
        vertices[420] = new Vector3(15.0f, 4.0f, 14.0f);
        vertices[421] = new Vector3(14.75f, 4.0f, 14.0f);
        vertices[422] = new Vector3(15.0f, 5.0f, 13.0f);
        vertices[423] = new Vector3(14.75f, 5.0f, 13.0f);

        uvs[420] = new Vector2(0.0f, 1.0f);
        uvs[421] = new Vector2(0.0f, 0.0f);
        uvs[422] = new Vector2(1.0f, 1.0f);
        uvs[423] = new Vector2(1.0f, 0.0f);
        
        vertices[424] = new Vector3(14.75f, 4.0f, 12.0f);
        vertices[425] = new Vector3(15.0f, 4.0f, 12.0f);
        vertices[426] = new Vector3(14.75f, 5.0f, 13.0f);
        vertices[427] = new Vector3(15.0f, 5.0f, 13.0f);

        uvs[424] = new Vector2(0.0f, 1.0f);
        uvs[425] = new Vector2(0.0f, 0.0f);
        uvs[426] = new Vector2(1.0f, 1.0f);
        uvs[427] = new Vector2(1.0f, 0.0f);

        vertices[428] = new Vector3(15.0f, 4.0f, 14.0f);
        vertices[429] = new Vector3(15.0f, 4.0f, 16.0f);
        vertices[430] = new Vector3(15.0f, 5.0f, 15.0f);

        uvs[428] = new Vector2(0.0f, 0.0f);
        uvs[429] = new Vector2(1.0f, 0.0f);
        uvs[430] = new Vector2(0.5f, 1.0f);

        vertices[431] = new Vector3(14.75f, 4.0f, 14.0f);
        vertices[432] = new Vector3(14.75f, 4.0f, 16.0f);
        vertices[433] = new Vector3(14.75f, 5.0f, 15.0f);

        uvs[431] = new Vector2(0.0f, 0.0f);
        uvs[432] = new Vector2(1.0f, 0.0f);
        uvs[433] = new Vector2(0.5f, 1.0f);
        
        vertices[434] = new Vector3(15.0f, 4.0f, 16.0f);
        vertices[435] = new Vector3(14.75f, 4.0f, 16.0f);
        vertices[436] = new Vector3(15.0f, 5.0f, 15.0f);
        vertices[437] = new Vector3(14.75f, 5.0f, 15.0f);

        uvs[434] = new Vector2(0.0f, 1.0f);
        uvs[435] = new Vector2(0.0f, 0.0f);
        uvs[436] = new Vector2(1.0f, 1.0f);
        uvs[437] = new Vector2(1.0f, 0.0f);
        
        vertices[438] = new Vector3(14.75f, 4.0f, 14.0f);
        vertices[439] = new Vector3(15.0f, 4.0f, 14.0f);
        vertices[440] = new Vector3(14.75f, 5.0f, 15.0f);
        vertices[441] = new Vector3(15.0f, 5.0f, 15.0f);

        uvs[438] = new Vector2(0.0f, 1.0f);
        uvs[439] = new Vector2(0.0f, 0.0f);
        uvs[440] = new Vector2(1.0f, 1.0f);
        uvs[441] = new Vector2(1.0f, 0.0f);

        vertices[442] = new Vector3(15.0f, 4.0f, 16.0f);
        vertices[443] = new Vector3(15.0f, 4.0f, 18.0f);
        vertices[444] = new Vector3(15.0f, 5.0f, 17.0f);

        uvs[442] = new Vector2(0.0f, 0.0f);
        uvs[443] = new Vector2(1.0f, 0.0f);
        uvs[444] = new Vector2(0.5f, 1.0f);

        vertices[445] = new Vector3(14.75f, 4.0f, 16.0f);
        vertices[446] = new Vector3(14.75f, 4.0f, 18.0f);
        vertices[447] = new Vector3(14.75f, 5.0f, 17.0f);

        uvs[445] = new Vector2(0.0f, 0.0f);
        uvs[446] = new Vector2(1.0f, 0.0f);
        uvs[447] = new Vector2(0.5f, 1.0f);
        
        vertices[448] = new Vector3(15.0f, 4.0f, 18.0f);
        vertices[449] = new Vector3(14.75f, 4.0f, 18.0f);
        vertices[450] = new Vector3(15.0f, 5.0f, 17.0f);
        vertices[451] = new Vector3(14.75f, 5.0f, 17.0f);

        uvs[448] = new Vector2(0.0f, 1.0f);
        uvs[449] = new Vector2(0.0f, 0.0f);
        uvs[450] = new Vector2(1.0f, 1.0f);
        uvs[451] = new Vector2(1.0f, 0.0f);
        
        vertices[452] = new Vector3(14.75f, 4.0f, 16.0f);
        vertices[453] = new Vector3(15.0f, 4.0f, 16.0f);
        vertices[454] = new Vector3(14.75f, 5.0f, 17.0f);
        vertices[455] = new Vector3(15.0f, 5.0f, 17.0f);

        uvs[452] = new Vector2(0.0f, 1.0f);
        uvs[453] = new Vector2(0.0f, 0.0f);
        uvs[454] = new Vector2(1.0f, 1.0f);
        uvs[455] = new Vector2(1.0f, 0.0f);
        
        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[]{
            443, 444, 442,
            446, 445, 447,
            450, 448, 449,
            450, 449, 451,
            454, 452, 453,
            454, 453, 455,

            429, 430, 428,
            432, 431, 433,
            436, 434, 435,
            436, 435, 437,
            440, 438, 439,
            440, 439, 441,

            415, 416, 414,
            418, 417, 419,
            422, 420, 421,
            422, 421, 423,
            426, 424, 425,
            426, 425, 427,

            401, 402, 400,
            404, 403, 405,
            408, 406, 407,
            408, 407, 409,
            412, 410, 411,
            412, 411, 413,

            387, 388, 386,
            390, 389, 391,
            394, 392, 393,
            394, 393, 395,
            398, 396, 397,
            398, 397, 399,

            481, 482, 480,
            484, 483, 485,
            488, 486, 487,
            488, 487, 489,
            492, 490, 491,
            492, 491, 493,

            363, 364, 362,
            366, 365, 367,
            370, 368, 369,
            370, 369, 371,
            374, 372, 373,
            374, 373, 375,

            349, 350, 348,
            352, 351, 353,
            356, 354, 355,
            356, 355, 357,
            360, 358, 359,
            360, 359, 361,

            335, 336, 334,
            338, 337, 339,
            342, 340, 341,
            342, 341, 343,
            346, 344, 345,
            346, 345, 347,

            321, 322, 320,
            324, 323, 325,
            328, 326, 327,
            328, 327, 329,
            332, 330, 331,
            332, 331, 333,

            307, 308, 306,
            310, 309, 311,
            314, 312, 313,
            314, 313, 315,
            318, 316, 317,
            318, 317, 319,

            293, 294, 292,
            296, 295, 297,
            300, 298, 299,
            300, 299, 301,
            304, 302, 303,
            304, 303, 305,

            279, 280, 278,
            282, 281, 283,
            286, 284, 285,
            286, 285, 287,
            290, 288, 289,
            290, 289, 291,

            265, 266, 264,
            268, 267, 269,
            272, 270, 271,
            272, 271, 273,
            276, 274, 275,
            276, 275, 277,

            461, 462, 460,
            464, 463, 465,
            468, 466, 467,
            468, 467, 469,
            472, 470, 471,
            472, 471, 473,

            241, 242, 240,
            244, 243, 245,
            248, 246, 247,
            248, 247, 249,
            252, 250, 251,
            252, 251, 253,

            227, 228, 226,
            230, 229, 231,
            234, 232, 233,
            234, 233, 235,
            238, 236, 237,
            238, 237, 239,

            213, 214, 212,
            216, 215, 217,
            220, 218, 219,
            220, 219, 221,
            224, 222, 223,
            224, 223, 225,

            199, 200, 198,
            202, 201, 203,
            206, 204, 205,
            206, 205, 207,
            210, 208, 209,
            210, 209, 211,

            185, 186, 184,
            188, 187, 189,
            192, 190, 191,
            192, 191, 193,
            196, 194, 195,
            196, 195, 197,

            171, 172, 170,
            174, 173, 175,
            178, 176, 177,
            178, 177, 179,
            182, 180, 181,
            182, 181, 183,

            157, 158, 156,
            160, 159, 161,
            164, 162, 163,
            164, 163, 165,
            168, 166, 167,
            168, 167, 169,

            143, 144, 142,
            146, 145, 147,
            150, 148, 149,
            150, 149, 151,
            154, 152, 153,
            154, 153, 155,

            129, 130, 128,
            132, 131, 133,
            136, 134, 135,
            136, 135, 137,
            140, 138, 139,
            140, 139, 141,
            
            115, 116, 114,
            118, 117, 119,
            122, 120, 121,
            122, 121, 123,
            126, 124, 125,
            126, 125, 127,

            101, 102, 100,
            104, 103, 105,
            108, 106, 107,
            108, 107, 109,
            112, 110, 111,
            112, 111, 113,

            87, 88, 86,
            90, 89, 91,
            94, 92, 93,
            94, 93, 95,
            98, 96, 97,
            98, 97, 99,

            73, 74, 72,
            76, 75, 77,
            80, 78, 79,
            80, 79, 81,
            84, 82, 83,
            84, 83, 85,

            // 2, 1, 0,
            // 2, 3, 1,
            6, 4, 5,
            6, 5, 7,
            10, 8, 9,
            10, 9, 11,
            14, 12, 13,
            14, 13, 15,
            18, 16, 17,
            18, 17, 19,
            22, 20, 21,
            22, 21, 23,

            // 26, 25, 24,
            // 26, 27, 25,
            30, 28, 29,
            30, 29, 31,
            34, 32, 33,
            34, 33, 35,
            38, 36, 37,
            38, 37, 39,
            42, 40, 41,
            42, 41, 43,
            46, 44, 45,
            46, 45, 47,

            // 50, 48, 49,
            // 50, 49, 51,
            54, 53, 52,
            54, 55, 53,
            58, 57, 56,
            58, 59, 57,
            62, 61, 60,
            62, 63, 61,
            66, 65, 64,
            66, 67, 65,
            70, 69, 68,
            70, 71, 69,
        };

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = cubeMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
