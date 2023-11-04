using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    private float moveRange = 13.3f;
    private Vector3 oldPosition;
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        oldPosition = obj.transform.position;     
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(transform.position.x, -1 * Time.deltaTime, 0));

        if (Vector3.Distance(oldPosition, obj.transform.position) > moveRange)
        {
            obj.transform.position = oldPosition;
        }
    }
}
