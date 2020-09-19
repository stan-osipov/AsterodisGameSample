using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace Game.GamePlay
{
    internal class AsteroidSpawner : MonoBehaviour
    {
        
        [ContextMenu("test Spawn")]
        private void Spawn()
        {
            
            Debug.Log("Spanw");
            CreateAsteroid();
        }

        void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            //Gizmos.DrawIcon(transform.position);
            Gizmos.DrawSphere(transform.position, 1f);
        }

        private GameObject CreateAsteroid()
        {
            var index = Random.Range(1, 5);
            var res = Resources.Load($"Asteroids/Asteroid_{index}");
            var asteroid = (GameObject) Instantiate(res, Vector3.zero, Quaternion.identity, transform);
            asteroid.transform.localPosition = Vector3.zero;;
            
            return  asteroid;
        }
    }
}

