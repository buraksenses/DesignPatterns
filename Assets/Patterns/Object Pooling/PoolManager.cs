using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Pool;

namespace Patterns.Object_Pooling
{
    public class PoolManager : MonoBehaviour
    {
        [SerializeField] private Enemy spawnObject;

        private Transform _spawnTransform;

        private IObjectPool<Enemy> _pool;
        private void Awake()
        {
            _spawnTransform = transform;

            _pool = new ObjectPool<Enemy>(
                ObjectSpawn,
                OnGet,
                OnRelease
            );
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _pool.Get();
        }

        private Enemy ObjectSpawn()
        {
            Enemy go = Instantiate(spawnObject);
            go.SetPool(_pool);
            return go;
        }
        private void OnGet(Enemy obj)
        { 
            obj.gameObject.SetActive(true);
            obj.transform.position = _spawnTransform.position;
        }
        private void OnRelease(Enemy obj)
        {
            obj.gameObject.SetActive(false);
        }
        
    }
}
