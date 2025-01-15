using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    public Collider personaje, brujula;

    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(personaje,brujula);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
