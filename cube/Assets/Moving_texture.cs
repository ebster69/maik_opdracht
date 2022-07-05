using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_texture : MonoBehaviour
{
    public float scrollSpeed;
    float offsetX;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        offsetX = 0f;
        //scrollSpeed = -2f;
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offsetX += scrollSpeed * Time.deltaTime;
        rend.material.mainTextureOffset = new Vector2(offsetX,0f);

    }
}
