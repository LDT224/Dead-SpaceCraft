using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShitControl : MonoBehaviour
{
    public Vector3 target;
    private float moveSpeed = 0.75f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((transform.position - target) * moveSpeed * Time.deltaTime*-1);
        
    }
}
