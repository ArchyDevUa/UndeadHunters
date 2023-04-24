using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnClick : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Instantiate(prefab, hit.point + new Vector3(0f,1f,0f), Quaternion.identity);
            } 
        }
    }
}
