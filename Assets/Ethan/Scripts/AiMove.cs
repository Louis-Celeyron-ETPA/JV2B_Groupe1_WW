using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMove : MonoBehaviour
{
    public List<Point> allPoints;
    int currentPoint = 0;
    Vector3 oldPos;
    Vector3 targetPoint;
    
    float pourcentage = 0f;
    float speed = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
        newTarget();
    }

    // Update is called once per frame
    void Update()
    {
        if (pourcentage<1)
        {
            Move();
            pourcentage += speed;
            Debug.Log("Move s'effectue , avec un pourcentage de : " + pourcentage);
        }
        else
        {
            pourcentage = 0;
            newTarget();
            Debug.Log("Change de cible");
        }
    }

    void Move()
    {
        transform.position = Vector3.Lerp(oldPos, targetPoint, pourcentage);
    }

    void newTarget()
    {
        Debug.Log("Lance newTarget");
        oldPos = transform.position;
        var target = allPoints[currentPoint].nearPoints[Random.Range(0, allPoints[currentPoint].nearPoints.Count)];
        targetPoint = target.theTransform.position;
        currentPoint = target.pointIndex;
    }
}
