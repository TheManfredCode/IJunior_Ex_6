using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject Template;
    
    private Transform _transform;

    public void Spawn()
    {
        Instantiate(Template, _transform.position, Quaternion.identity);
    }

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }
}
