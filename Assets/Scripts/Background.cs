using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private float moveSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime 컴퓨터 사양의 프레임에 따라 이동되는 것을 같도록 함.

        transform.position += Vector3.down * moveSpeed * Time.deltaTime; 
        if (transform.position.y <= -10f){
            transform.position += new Vector3(0f, 20f, 0f);
        }
    }
}
