using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Biology
{
    [SerializeField] float axisSpeed = 5.0f; // ī�޶� x��� y���� ȸ�� �ӵ� 

    [SerializeField] GameObject eye;

    private float eulerAngleX;
    private float eulerAngleY;
    private int magazine = 10;

    [SerializeField] float distance = 100.0f;
    [SerializeField] float speed;
    [SerializeField] float gravity = 20.0f;
    [SerializeField] LayerMask layer;
    [SerializeField] GameObject hitEffect;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
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
            audioSource.Play();
            animator.SetBool("Run", false);
         
            if (magazine <= 0)
            {
                StartCoroutine(Reload());
            }
        }

        MoveTo(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));

        // �ٴڰ� �浹���� �ʾҴٸ�
        if(characterControl.isGrounded == false)
        {
            // �߷��� �ۿ��ϵ��� �����մϴ�.
            direction.y -= gravity * Time.deltaTime;
        }

        characterControl.Move(direction * Time.deltaTime);

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
            // �ٴڰ� �浹�� ���¶��
            if(characterControl.isGrounded)
            {
                // ������ �� �� �ֵ��� �����մϴ�.
                direction.y = 7.5f;
            }         
        }
    }

    public void MoveTo(Vector3 directionForce)
    {
        if(characterControl.velocity != Vector3.zero && !Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("Run", true);
        }
        else if(characterControl.velocity == Vector3.zero)
        {
            animator.SetBool("Run", false);
        }

        // ī�޶� ȸ������ ���� ������ ���ϱ� ������ ȸ�� ���� ���ؼ� �����մϴ�.
        directionForce = transform.rotation * new Vector3(directionForce.x, 0, directionForce.z);

        // ��/ �Ʒ��� �ٶ󺸰� �̵��� �� ĳ���� ������Ʈ�� �������� �̵��ϰų� �Ʒ��� ����ɱ� ������
        // direction�� �״�� ������� �ʰ�, moveForce ������ x�� z���� �־ ����մϴ�.
        direction = new Vector3(directionForce.x * speed, direction.y, directionForce.z * speed);
    }


    public void UpdateRotate(float mouseX, float mouseY)
    {
        eulerAngleY += mouseX * axisSpeed; // ���콺 ��/�� �̵����� ī�޶� y�� ȸ��

        // ���콺 �Ʒ��� ������ -�� �����ε� ������Ʈ�� x���� + �������� ȸ���ؾ� �Ʒ��� ���� �����Դϴ�.
        eulerAngleX -= mouseY * axisSpeed; // ���콺 ��/�Ʒ� �̵����� ī�޶� x�� ȸ��

        // ī�޶� x�� ȸ���� ��� ȸ�� ������ �����մϴ�.
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

        // ȭ���� �߾� ��ǥ (Cross Hair�� �������� Raycast�� �����մϴ�.)
        Ray ray = Camera.main.ViewportPointToRay(Vector2.one * 0.5f);

        // ���� ��Ÿ� �ȿ� �ε����� ������Ʈ�� ������ target�� ������ �ε��� ��ġ�� �����մϴ�.
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
