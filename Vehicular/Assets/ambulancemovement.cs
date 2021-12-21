using UnityEngine;
using UnityEngine.AI;

public class ambulancemovement : MonoBehaviour
{
    [SerializeField] private Transform movePosition;

    public NavMeshAgent agent;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            agent.destination = movePosition.position;
        }   }
}