using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround_Movement : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public float Speed;
    void Update()
    {
        Vector2 Offset = meshRenderer.material.mainTextureOffset;
        Offset = Offset + new Vector2(0 , Speed * Time.deltaTime);
        meshRenderer.material.mainTextureOffset = Offset;
    }
}
