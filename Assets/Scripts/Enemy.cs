using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _lifeTime;
    [SerializeField] private float _speed;

    private float _runningTime = 0f;
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        _transform.Translate(0, _speed * Time.deltaTime * -1, 0);

        if (_runningTime >= _lifeTime)
            Destroy(gameObject);

        _runningTime += Time.deltaTime;
    }
}
