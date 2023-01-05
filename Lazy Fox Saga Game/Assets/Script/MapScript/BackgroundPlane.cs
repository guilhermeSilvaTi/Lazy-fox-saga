using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundPlane : MonoBehaviour
{
    [Range(0, 3)]
    public float scrollSpeed = 0.5f;

    private float offset;

    private Material material;
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }
    void Update()
    {
        offset += Time.deltaTime * scrollSpeed;
        material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
