using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 10;
    public float damage = 1;
    public float knockbackForce = 10;
    Vector3 direction;
    public (float,float) xyoffset = (0f,0f);
     void Start()
        {
        Vector3 mousePositon = Input.mousePosition;
        mousePositon = Camera.main.ScreenToWorldPoint(mousePositon);
        direction = new Vector3(mousePositon.x - transform.position.x + xyoffset.Item1, mousePositon.y - transform.position.y+xyoffset.Item2, 0).normalized;
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //transform.eulerAngles = new Vector3(0, 0, angle);
        }
    void Update()
    {
        transform.position+=direction * speed * Time.deltaTime;
        DestroyObject(gameObject, 2);
    }

}
