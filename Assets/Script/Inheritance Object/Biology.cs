
using UnityEngine;
using UnityEngine.AI;

public class Biology : MonoBehaviour
{
    public float health;
    protected Animator animator;
    protected Vector3 direction;
 
    protected CharacterController characterControl;

    protected AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponentInChildren<Animator>();
        characterControl = GetComponent<CharacterController>();
    }

    protected void OnEnable()
    {
        health = 100;
    }
}
