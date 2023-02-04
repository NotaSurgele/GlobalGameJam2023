using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 _direction = Vector3.zero;

    public float speed = 5;

    public float rotationSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = -Input.GetAxis("Vertical");
        float my = Input.GetAxis("Mouse Y");
        this._direction.x = x;
        
        this.transform.Rotate(new Vector3(0, my * rotationSpeed, 0));
        this.transform.Translate(this._direction * speed * Time.deltaTime);
    }
}
