/*using UnityEngine;

public class Ghost : MonoBehaviour
{
    public string name;
    public Color color;
    private Vector3 currentPos;

    void Start()
    {
        currentPos = transform.position;
    }

    public void Chase(Vector3 pacmanPos)
    {
        // Define different chase behaviors here
        if (name == "Blinky")
        {
            // Blinky chases Pac-Man directly
            transform.position = Vector3.MoveTowards(transform.position, pacmanPos, Time.deltaTime);
        }
        else if (name == "Pinky")
        {
            // Pinky chases four units ahead of Pac-Man's current position
            Vector3 pinkyTarget = pacmanPos + 4 * (pacmanPos - currentPos);
            transform.position = Vector3.MoveTowards(transform.position, pinkyTarget, Time.deltaTime);
        }
        else if (name == "Inky")
        {
            // Inky's chase target is two units ahead of Pac-Man's position, plus the vector between Blinky and Pac-Man
            GameObject blinky = GameObject.Find("Blinky");
            Vector3 inkyTarget = pacmanPos + 2 * (pacmanPos - currentPos) + (pacmanPos - blinky.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, inkyTarget, Time.deltaTime);
        }
        else if (name == "Clyde")
        {
            // Clyde chases Pac-Man when he is more than eight units away, otherwise he runs away
            float distance = Vector3.Distance(transform.position, pacmanPos);
            if (distance > 8)
            {
                transform.position = Vector3.MoveTowards(transform.position, pacmanPos, Time.deltaTime);
            }
            else
            {
                Vector3 clydeTarget = 2 * currentPos - pacmanPos;
                transform.position = Vector3.MoveTowards(transform.position, clydeTarget, Time.deltaTime);
            }
        }
    }
}
*/


/*
 using UnityEngine;
using UnityEngine.AI;

public class Ghost : MonoBehaviour
{
    public string name;
    public Color color;
    private NavMeshAgent navAgent;
    private Vector3 currentPos;

    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        currentPos = transform.position;
    }

    public void Chase(Vector3 pacmanPos)
    {
        // Define different chase behaviors here
        if (name == "Blinky")
        {
            // Blinky chases Pac-Man directly
            navAgent.SetDestination(pacmanPos);
        }
        else if (name == "Pinky")
        {
            // Pinky chases four units ahead of Pac-Man's current position
            Vector3 pinkyTarget = pacmanPos + 4 * (pacmanPos - currentPos);
            navAgent.SetDestination(pinkyTarget);
        }
        else if (name == "Inky")
        {
            // Inky's chase target is two units ahead of Pac-Man's position, plus the vector between Blinky and Pac-Man
            GameObject blinky = GameObject.Find("Blinky");
            Vector3 inkyTarget = pacmanPos + 2 * (pacmanPos - currentPos) + (pacmanPos - blinky.transform.position);
            navAgent.SetDestination(inkyTarget);
        }
        else if (name == "Clyde")
        {
            // Clyde chases Pac-Man when he is more than eight units away, otherwise he runs away
            float distance = Vector3.Distance(transform.position, pacmanPos);
            if (distance > 8)
            {
                navAgent.SetDestination(pacmanPos);
            }
            else
            {
                Vector3 clydeTarget = 2 * currentPos - pacmanPos;
                navAgent.SetDestination(clydeTarget);
            }
        }
    }
}

     */







/*
 using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{
    public Ghost[] ghosts;
    private Vector3 pacmanPos;

    void Start()
    {
        for (int i = 0; i < ghosts.Length; i++)
        {
            ghosts[i].navAgent = ghosts[i].GetComponent<NavMeshAgent>();
        }
    }

    void Update()
    {
        pacmanPos = GameObject.Find("Pacman").transform.position;
        for (int i = 0; i < ghosts.Length; i++)
        {
            ghosts[i].Chase(pacmanPos);
        }
    }
}

public class Ghost : MonoBehaviour
{
    public string name;
    public Color color;
    public NavMeshAgent navAgent;
    private Vector3 currentPos;

    public void Chase(Vector3 pacmanPos)
    {
        // Define different chase behaviors here
        if (name == "Blinky")
        {
            // Blinky chases Pac-Man directly
            navAgent.SetDestination(pacmanPos);
        }
        else if (name == "Pinky")
        {
            // Pinky chases four units ahead of Pac-Man's current position
            Vector3 pinkyTarget = pacmanPos + 4 * (pacmanPos - currentPos);
            navAgent.SetDestination(pinkyTarget);
        }
        else if (name == "Inky")
        {
            // Inky's chase target is two units ahead of Pac-Man's position, plus the vector between Blinky and Pac-Man
            GameObject blinky = GameObject.Find("Blinky");
            Vector3 inkyTarget = pacmanPos + 2 * (pacmanPos - currentPos) + (pacmanPos - blinky.transform.position);
            navAgent.SetDestination(inkyTarget);
        }
        else if (name == "Clyde")
        {
            // Clyde chases Pac-Man when he is more than eight units away, otherwise he runs away
            float distance = Vector3.Distance(transform.position, pacmanPos);
            if (distance > 8)
            {
                navAgent.SetDestination(pacmanPos);
            }
            else
            {
                Vector3 clydeTarget = 2 * currentPos - pacmanPos;
                navAgent.SetDestination(clydeTarget);
            }
        }
    }
}

 */







