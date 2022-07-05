using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingCube : MonoBehaviour
{
    public float amp;
    public float freq;
    
    float AnchorY;
    float posX;
    float posY;
    float posZ;
    
    public float rotY;
    float timer;

    void Start() {
        timer = 0f;
        posX = transform.position.x;
        AnchorY = transform.position.y;
        posZ = transform.position.z;
    }

    void Update() {
        timer++;
        posY = AnchorY + (Mathf.Sin(timer * freq / 7) * amp);
        transform.position = new Vector3(posX, posY, posZ);
        transform.Rotate(0F, rotY, 0F);
    }
}
