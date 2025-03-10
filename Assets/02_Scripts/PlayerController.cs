using System;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float rotate;

    [SerializeField]
    private float moveSpeed = 5.0f;
    
    [SerializeField]
    private float rotationSpeed = 200.0f;
    
    private Animator animator;
    
    void Awake()
    {
        
    }

    void OnEnable()
    {
        
    }

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // 물리 엔진의 계산주기
    void FixedUpdate()
    {
        
    }

    void Update()
    {
        Move();
        Animate();
    }

    private void Animate()
    {
        animator.SetFloat("Forward", vertical);
        animator.SetFloat("Strafe", horizontal);
    }

    void Move()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        rotate = Input.GetAxis("Mouse X");

        // transform.position += new Vector3(0, 0, 1) * 0.01f;
        // transform.position += new Vector3(1, 0, 0) * 0.01f;
        //
        // transform.position += new Vector3(0, 0, 1) * vertical * 0.01f;
        // transform.position += new Vector3(1, 0, 0) * horizontal * 0.01f;
        //
        // transform.position += transform.forward * vertical * 0.01f;
        // transform.position += transform.right * horizontal * 0.01f;
        //
        // transform.Translate(Vector3.forward * vertical * 0.01f);
        // transform.Translate(Vector3.right * horizontal * 0.01f);
        //
        // transform.Translate(Vector3.forward * vertical * Time.deltaTime * moveSpeed);
        // transform.Translate(Vector3.right * horizontal * Time.deltaTime * moveSpeed);
        //
        // Vector3 moveDir = (Vector3.forward * vertical) + (Vector3.right * horizontal);
        // transform.Translate(moveDir * Time.deltaTime * moveSpeed);
        
        Vector3 moveDir = (Vector3.forward * vertical) + (Vector3.right * horizontal);
        transform.Translate(moveDir.normalized * Time.deltaTime * moveSpeed);
        transform.Rotate(Vector3.up * Time.deltaTime * rotate * rotationSpeed);
        
        //Debug.Log($"Horizontal: {horizontal}, Vertical: {vertical}");
    }

    // Update 함수에서 계산된 결과값을 갖고 후 처리작업을 할 때
    void LateUpdate()
    {
        
    }
}
