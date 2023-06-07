using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    [SerializeField]
    private float moveSpeed;
    // Update is called once per frame
    void Update()
    {
        // 방법 1
        float horizontalInput = Input.GetAxisRaw("Horizontal"); // 키보드 방향 좌우
        //float verticalInput = Input.GetAxisRaw("Vertical"); // 키보드 뱡향 위아래
        Vector3 moveTo = new Vector3(horizontalInput, 0f, 0f);
        transform.position += moveTo * moveSpeed * Time.deltaTime;


    }
}
