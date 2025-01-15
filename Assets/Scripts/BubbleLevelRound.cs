using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleLevelRound : MonoBehaviour
{
    Renderer renderer;
    public GameObject cylinder;
    float offsetX;
    float offsetZ;
    public float speed;
    public float initialOffsetX, initialOffsetY;

    // Start is called before the first frame update
    void Start()
    {
        renderer = cylinder.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offsetX = Mathf.LerpAngle(offsetX, transform.rotation.eulerAngles.x, Time.deltaTime * speed);
        offsetZ = Mathf.LerpAngle(offsetZ, transform.rotation.eulerAngles.z, Time.deltaTime * speed);
        renderer.material.SetTextureOffset("_MainTex", new Vector2((-offsetZ / 180.0f) + initialOffsetX, (offsetX / 180.0f) + initialOffsetY));
    }
}
