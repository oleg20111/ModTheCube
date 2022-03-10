using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private int counter = 0;
    Material material;
    
    private int Rand(int NumberA, int NumberB)
    {
        int RandomNumber = Random.Range(NumberA, NumberB);
        return RandomNumber;
    }

    private float Rand(float NumberA, float NumberB)
    {
        float RandomNumber = Random.Range(NumberA, NumberB);
        return RandomNumber;
    }

    void Start()
    {
        material = Renderer.material;
        NewPosScaleColor();
    }

    void NewPosScaleColor()
    {
        transform.position = new Vector3(Rand(-5,5), Rand(-5,5), Rand(-5,5));
        transform.localScale = Vector3.one * Rand(0,5);
        material.color = new Color(Rand(0f,1f),Rand(0f,1f),Rand(0f,1f),Rand(0f,1f));
    }
    
    void Update()
    {
        counter++;
        if(counter % 20 == 0)
        {
            NewPosScaleColor();
            //material.color = new Color(Rand(0f,1f),Rand(0f,1f),Rand(0f,1f),Rand(0f,1f));
        }
        transform.Rotate(0.0f, Rand(0f,180f) * Time.deltaTime, 0.0f);
    }
}
