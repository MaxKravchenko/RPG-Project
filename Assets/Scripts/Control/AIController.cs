using System.Collections;
using System.Collections.Generic;
using RPG.Combat;
using UnityEngine;

namespace RPG.Control
{
    public class AIController : MonoBehaviour
    {
        [SerializeField] float chaseDistance = 5f;

        private void Update() 
        {
            if (GetComponent<Health>().IsDead())
            {
                GetComponent<Fighter>().Cancel();
                return;
            }

            
            GameObject player = GameObject.FindWithTag("Player");
            if(player == null) return;
            
            if (DistanceToPlayer() < chaseDistance)
            {   
                if (!GetComponent<Fighter>().CanAttack(player.gameObject)) return;

                GetComponent<Fighter>().Attack(player.gameObject);
            }
            else
            {
                GetComponent<Fighter>().Cancel();
            }
            
        }

        private float DistanceToPlayer()
        {
            GameObject player = GameObject.FindWithTag("Player");
            return Vector3.Distance(player.transform.position, transform.position);
        }
    }
}
