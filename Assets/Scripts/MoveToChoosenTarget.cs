using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToChoosenTarget : MonoBehaviour
{
    [SerializeField] private Transform target; 
    [SerializeField] private float speed = 5f; 
    void Update()
    {
        if (target != null)
        {
            Vector3 direction = target.position - transform.position;

            // Ограничиваем движение по оси Y
            direction.y = 0f;

            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            // Поворачиваем объект в сторону цели только по оси Y
            Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = rotation;
        }
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
