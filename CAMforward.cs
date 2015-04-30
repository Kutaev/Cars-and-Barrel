using UnityEngine;
using System.Collections;

public class CAMforward : MonoBehaviour {

    public int begin;
    public int begend;
    public int end;
    public float speed = 1.5f;
    public Vector3 direction;
    public float tim; 
    int num;
	void Update () {
	if (num >= -0.1)
    {
        tim -= Time.deltaTime;
        num = (int)tim;
    }
    if (num <= 0)
    {
        gameObject.transform.Translate(direction * speed * Time.deltaTime);

        if (gameObject.transform.position.z <= begin)
            speed += Time.deltaTime;
        if (gameObject.transform.position.z >= begend)
            speed -= Time.deltaTime;
        if (gameObject.transform.position.z >= end)
        {
            direction.z = 0;
            speed = 0;
        }
    }
	}
}
