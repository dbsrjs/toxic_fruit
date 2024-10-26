using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 7f;  // 플레이어 이동 속도
    public float boundaryX = 2.6f; // 화면 경계 값 (조정 가능)

    private void Update()
    {
        // 입력 값 받기 (왼쪽/오른쪽 화살표 키 또는 A/D 키)
        float horizontalInput = Input.GetAxis("Horizontal");

        // 이동 처리
        Vector3 movement = new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        // 경계 값 제한 (플레이어가 화면 밖으로 나가지 않게)
        float clampedX = Mathf.Clamp(transform.position.x, -boundaryX, boundaryX);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}
