using System.Collections;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float margin = 11f;
    [SerializeField] private int startPosX = 20;

    private void Start()
    {
        for (int i = 0; i <= 20; i += 4)
        {
            GenerateObstacles(i);
        }

        StartCoroutine(CreataNewObstales());
    }

    private IEnumerator CreataNewObstales()
    {
        GenerateObstacles(startPosX += 4);
        yield return new WaitForSeconds(2f);
        StartCoroutine(CreataNewObstales());
    }

    private void GenerateObstacles(int i)
    {
        float randomY = Random.Range(1f, 8f);

        GameObject obstacleClone1 = Instantiate(obstaclePrefab);
        obstacleClone1.transform.SetParent(transform);
        obstacleClone1.transform.position = new Vector3(i, randomY, 0f);

        GameObject obstacleClone2 = Instantiate(obstaclePrefab);
        obstacleClone2.transform.SetParent(transform);
        obstacleClone2.transform.position = new Vector3(i, randomY - margin + 0f);
    }
}
