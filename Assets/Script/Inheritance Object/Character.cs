using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Biology
{
    private float mouseX;
    private int magazine = 10;

    [SerializeField] float speed;
    [SerializeField] float mouseSpeed;
    [SerializeField] float gravity = 20.0f;
    [SerializeField] float distance = 100.0f;

    [SerializeField] LayerMask layer;
    [SerializeField] GameObject hitEffect;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {    
        if (Input.GetButtonDown("Fire1") && magazine-- > 0)
        {      
            TwoStepRay();
            audioSource.Play();

            if (magazine <= 0)
            {
                StartCoroutine(Reload());
            }
        }

        direction.y -= gravity * Time.deltaTime;

        direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        direction = characterControl.transform.TransformDirection(direction);

        characterControl.Move(direction * speed * Time.deltaTime);

        mouseX += Input.GetAxis("Mouse X") * speed;
        transform.eulerAngles = new Vector3(0, mouseX, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 바닥과 충돌한 상태라면
            if (characterControl.isGrounded)
            {
                // 점프를 할 수 있도록 설정합니다.
                direction.y = 7.5f;
            }
        }
    }

    private IEnumerator Reload()
    {
        animator.Play("Character_Reload");
 
        yield return new WaitForSeconds(0.01f);

        float curAnimationTime = animator.GetCurrentAnimatorStateInfo(0).length;
  
        yield return new WaitForSeconds(curAnimationTime);

        magazine = 10;
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
