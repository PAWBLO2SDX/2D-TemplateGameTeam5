using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CaretakerPath : MonoBehaviour
{
    public Transform[] patrolPoints;
    public int targetPoint;
    public float speed;
    private bool can_Move = true;
    // Start is called before the first frame update
    void Start()
    {
        targetPoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == patrolPoints[targetPoint].position && can_Move == true)
        {
            StartCoroutine(NextDelay());
        }
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[targetPoint].position, speed * Time.deltaTime);
    }

    private IEnumerator NextDelay()
    {
        can_Move = false;
        yield return new WaitForSeconds(3);
        can_Move = true;
        increaseTargetInt();
    }

    void increaseTargetInt()
    {
        targetPoint++;
        if (targetPoint >= patrolPoints.Length)
        {
            targetPoint = 0;
        }
    }
}
