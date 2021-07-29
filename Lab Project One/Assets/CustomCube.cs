using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCube : MonoBehaviour
{
    [SerializeField]
    public Material cubeMaterial;

    private const int V = 6;
    float width = 1.0f;
    float height = 1.0f;
    float thick = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[8];

        vertices[0] = new Vector3(-width, -height, thick);
        vertices[1] = new Vector3(-width, height, thick);
        vertices[2] = new Vector3(width, height, thick);
        vertices[3] = new Vector3(width, -height, thick);

        vertices[4] = new Vector3(-width, -height, -thick);
        vertices[5] = new Vector3(-width, height, -thick);
        vertices[6] = new Vector3(width, height, -thick);
        vertices[7] = new Vector3(width, -height, -thick);

        mesh.vertices = vertices;

        mesh.triangles = new int[]{
            2, 1, 0,
            3, 2, 0,
            3, 0, 4,
            4, 7, 3,
            3, 6, 2,
            3, 7, 6,
            6, 5, 2,
            5, 1, 2,
            5, 6, 4,
            6, 7, 4,
            1, 5, 4,
            4, 0, 1
        };
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = cubeMaterial;

        cubeMaterial.color = new Color(0.33f, 0.61f, 0.17f);
    }

    void FixedUpdate(){
        float cubeTime = Time.time;
        if(cubeTime % 2.0f == 0){
            var valueR = Random.Range(0.0f, 1.0f);
            var valueG = Random.Range(0.0f, 1.0f);
            var valueB = Random.Range(0.0f, 1.0f);
            GetComponent<MeshRenderer>().material.color = new Color(valueR, valueG, valueB);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
