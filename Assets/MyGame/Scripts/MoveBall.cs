using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField] private Transform[] randomPositions;
    [SerializeField] private Transform defaultPosition;
    [SerializeField] private Transform ball;
    [SerializeField] private bool alwaysDifferentPos;

    void Start()
    {
        ball.position = defaultPosition.position;
    }

    public void BallMover()
    {
        Vector3 oldPos;
        Vector3 newPos;

        do
        {
            oldPos = ball.position;
            newPos = randomPositions[Random.Range(0, randomPositions.Length)].position;
            ball.position = newPos;
        }
        // check condition after executing the above code
        while (oldPos == newPos && alwaysDifferentPos);
    }

    public void ChangeMode(bool setting)
    {
        alwaysDifferentPos = setting;
    }
}
