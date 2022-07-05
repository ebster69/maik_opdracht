using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scAnimetexture : MonoBehaviour
{
    public float scrollSpeed;
    float time = 0f;
    float tposX = 0f;
    float tposY = 0f;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        time += 20f * Time.deltaTime;
        if(time>= 2f)
        {
            tposX++;
            time = 0f;
        }
        if (tposX >= 4f)
        {
            tposX = 0f;
            tposY--;
        }
        if(tposY <=-2f)
        {
            tposY = 0f;
        }
        float offsetX = tposX * scrollSpeed;
        float offsetY = tposY * scrollSpeed;
        rend.material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
