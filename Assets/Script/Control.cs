using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int health = 100;
    [SerializeField] float axisSpeed = 5.0f; // 카메라 x축과 y축의 회전 속도 

    [SerializeField] GameObject eye;

    private float eulerAngleX;
    private float eulerAngleY;
    private int magazine = 10;

    private CharacterController characterControl;
    private Animator animator;
    private Vector3 moveForce;
 
    [SerializeField] float distance = 100.0f;
    [SerializeField] float speed;
    [SerializeField] float gravity = 20.0f;
    [SerializeField] LayerMask layer;
    [SerializeField] GameObject hitEffect;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        characterControl = GetComponent<CharacterController>();      
    }

    void Update()
    {    
        UpdateRotate(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        if (health <= 0)
        {
            Death();
        }

        if (Input.GetButtonDown("Fire1") && magazine-- > 0)
        {      
            TwoStepRay();
            SoundSystem.instance.Sound(0);
            animator.SetBool("Run", false);
         
            if (magazine <= 0)
            {
                StartCoroutine(Reload());
            }
        }

        MoveTo(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));

        // 바닥과 충돌하지 않았다면
        if(characterControl.isGrounded == false)
        {
            // 중력을 작용하도록 설정합니다.
            moveForce.y -= gravity * Time.deltaTime;
        }

        characterControl.Move(moveForce * Time.deltaTime);

        Jump();
    }

    private IEnumerator Reload()
    {
        animator.Play("Character_Reload");
 
        yield return new WaitForSeconds(0.01f);

        float curAnimationTime = animator.GetCurrentAnimatorStateInfo(0).length;
  
        yield return new WaitForSeconds(curAnimationTime);

        magazine = 10;
    }

    public void Death()
    {
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;       
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 바닥과 충돌한 상태라면
            if(characterControl.isGrounded)
            {
                // 점프를 할 수 있도록 설정합니다.
                moveForce.y = 7.5f;
            }         
        }
    }

    public void MoveTo(Vector3 direction)
    {
        if(characterControl.velocity != Vector3.zero && !Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("Run", true);
        }
        else if(characterControl.velocity == Vector3.zero)
        {
            animator.SetBool("Run", false);
        }

        // 카메라 회전으로 전방 방향이 변하기 때문에 회전 값을 곱해서 연산합니다.
        direction = transform.rotation * new Vector3(direction.x, 0, direction.z);

        // 위/ 아래를 바라보고 이동할 때 캐릭터 오브젝트가 공중으로 이동하거나 아래로 가라앉기 때문에
        // direction을 그대로 사용하지 않고, moveForce 변수에 x와 z값만 넣어서 사용합니다.
        moveForce = new Vector3(direction.x * speed, moveForce.y, direction.z * speed);
    }


    public void UpdateRotate(float mouseX, float mouseY)
    {
        eulerAngleY += mouseX * axisSpeed; // 마우스 좌/우 이동으로 카메라 y축 회전

        // 마우스 아래로 내리면 -로 음수인데 오브젝트의 x축이 + 방향으로 회전해야 아래를 보기 때문입니다.
        eulerAngleX -= mouseY * axisSpeed; // 마우스 위/아래 이동으로 카메라 x축 회전

        // 카메라 x축 회전의 경우 회전 범위를 설정합니다.
        eulerAngleX = ClampAngle(eulerAngleX, -80, 50);

        transform.rotation = Quaternion.Euler(transform.rotation.x, eulerAngleY, 0);

        eye.transform.rotation = Quaternion.Euler(eulerAngleX, transform.eulerAngles.y, 0);
    }

    public float ClampAngle(float angle, float min, float max)
    {
        return Mathf.Clamp(angle, min, max);
    }

    public void TwoStepRay()
    {
        RaycastHit hit;

        // 화면의 중앙 좌표 (Cross Hair를 기준으로 Raycast를 연산합니다.)
        Ray ray = Camera.main.ViewportPointToRay(Vector2.one * 0.5f);

        // 공격 사거리 안에 부딪히는 오브젝트가 있으면 target은 광선에 부딪힌 위치로 설정합니다.
        if (Physics.Raycast(ray, out hit, distance, layer))
        {
            hit.collider.GetComponentInParent<Zombie>().health -= 20;
            Instantiate(hitEffect, hit.point, Quaternion.identity);
        }
        else if(Physics.Raycast(ray, out hit, distance))
        {
            Instantiate(hitEffect, hit.point, Quaternion.identity);
            return;
        }      
    }
}
