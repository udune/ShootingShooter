using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
        }
    }
}

/*
 * - Collider IsTrigger 언체크
 * OnCollisionEnter
 * OnCollisionStay
 * OnCollisionExit
 *
 * - Collider IsTrigger 체크
 * OnTriggerEnter
 * OnTriggerStay
 * OnTriggerExit
 *
 * - 충돌 감지를 위한 필수 조건
 * 1. 양쪽 모두 Collider 컴포넌트를 존재
 * 2. 움직이는 게임 오브젝트에 Rigidbody 컴포넌트가 존재
 */