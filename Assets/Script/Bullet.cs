using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject origin;
    [SerializeField] int speed = 5;

    private void Start()
    {
         Destroy(this.gameObject, 3);
    }

    void Update()
    {
        transform.Translate(origin.transform.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
           Instantiate
           (
             Resources.Load<GameObject>("WFX_BImpact Concrete"),
             transform.position,
             transform.rotation
            );

            other.transform.GetComponentInParent<AIControl>().health -= 20;
            other.transform.GetComponentInParent<AIControl>().Death();

            Destroy(this.gameObject);
        } 
    }
}
