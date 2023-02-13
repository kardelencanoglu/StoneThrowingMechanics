using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;
    public float force;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    //private void Update()
    //{
    //    Debug.Log("Temas");


    //    Vector3 direction = player.transform.position - transform.position;
    //    rb.velocity = new Vector3(direction.x, direction.y, direction.z).normalized * force;

    //    float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
    //    transform.rotation = Quaternion.Euler(0, 0, rot);
    //}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Temas");


        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector3(direction.x, direction.y, direction.z).normalized * force;

        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }


}
