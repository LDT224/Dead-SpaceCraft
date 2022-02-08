using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacecraftControl : MonoBehaviour
{
    Vector3 mousePos;
    private float moveSpeed =10;
    private GameObject obj;
    private GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
        mousePos = transform.position;
        obj = gameObject;
        gameController = GameObject.FindGameObjectWithTag("GameController");
        obj.transform.position = new Vector3(0, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        //Position Spacecraft
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos = new Vector3(mousePos.x, mousePos.y + 1.5f, 0);
        obj.transform.LookAt(mousePos);
        obj.transform.position = Vector3.Lerp(obj.transform.position, mousePos, moveSpeed * Time.deltaTime);

        //Rotation Spacecraft
        float angle = Mathf.Atan2(mousePos.x * -1, mousePos.y + 5) * Mathf.Rad2Deg;
        obj.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(obj);
        gameController.GetComponent<GameController>().EndGame();
    }

}
