using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetControl : MonoBehaviour
{
    GameObject obj;
    float MinSize = 1f;
    float MaxSize = 1.5f;
    Vector3 Size;
    private GameObject gameController;
   
    // Start is called before the first frame update
    void Start()
    {      
        obj = gameObject;
        Upsize();
        gameController = GameObject.FindGameObjectWithTag("GameController");
    }
    void Upsize()
    {
        Size = transform.localScale;
        Size.x = Size.y = Size.z = Random.Range(MinSize, MaxSize);
        transform.localScale = Size;
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag.Equals("Respawn"))
        {
            Destroy(obj);
            gameController.GetComponent<GameController>().GetPoint();
        }
    }
    
}
