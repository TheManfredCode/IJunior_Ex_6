using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _template;
    
    private Transform _transform;

    public void Spawn()
    {
        Instantiate(_template, _transform.position, Quaternion.identity);
    }

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }
}
