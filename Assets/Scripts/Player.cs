using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private GameObject weapon; // 무기 객체 변수

    [SerializeField]
    private Transform shootTransform; // shootTransform 객체 위치 변수 
    // Update is called once per frame

    [SerializeField]
    private float shootInterval = 0.05f; // 0.05초 마다 미사일 속도

    private float lastShootTime = 0f; // 최근에 쏜 미사일 시간대

    void Update()
    {
        // 방법 1
        // float horizontalInput = Input.GetAxisRaw("Horizontal"); // 키보드 방향 좌우
        // //float verticalInput = Input.GetAxisRaw("Vertical"); // 키보드 뱡향 위아래
        // Vector3 moveTo = new Vector3(horizontalInput, 0f, 0f);
        // transform.position += moveTo * moveSpeed * Time.deltaTime;

        // 방법 2
        // Vector3 moveTo = new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
        // if (Input.GetKey(KeyCode.LeftArrow)) {
        //     transform.position -= moveTo;
        // } else if ( Input.GetKey(KeyCode.RightArrow)) {
        //     transform.position += moveTo;
        // }

        // 방법 3 
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float toX = Mathf.Clamp(mousePos.x , -2.35f, 2.35f);
        transform.position = new Vector3(toX, transform.position.y, transform.position.z);

        // 무기 발사
        Shoot();
    }

    void Shoot() {
        if (Time.time - lastShootTime > shootInterval) {
            Instantiate(weapon, shootTransform.position, Quaternion.identity);
            lastShootTime = Time.time;
        }
    }
}
