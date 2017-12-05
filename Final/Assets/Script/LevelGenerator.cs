using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LevelGenerator : MonoBehaviour {

public GameObject [] Tiles;
    public GameObject[] walls;

    public List<Vector3> createdTiles;
    public int xDistance = 0;
    public int yDistance = 0;
    public int tileAmount;
    public int tileSize;
    public float waitTime;

	void Start () {
        StartCoroutine(GenerateLevel());
        xDistance = 0;
        yDistance = 3;
    }

    private void StartCoroutine(IEnumerable enumerable)
    {
        throw new NotImplementedException();
    }

    IEnumerable GenerateLevel()
    {
        for(int i = 0; i < tileAmount; i++)
        {
            int dir = UnityEngine.Random.Range(xDistance,yDistance);

            MoveGen(dir);
            yield return new WaitForSeconds(waitTime);
        }
        yield return 0;

    }
    void MoveGen(int dir) {
        switch (dir) {

            case 0:
                transform.position = new Vector3(transform.position.x, transform.position.y + tileSize, 0);
                break;

            case 1:
                transform.position = new Vector3(transform.position.x + tileSize, transform.position.y, 0);
                break;

            case 2:
                transform.position = new Vector3(transform.position.x, transform.position.y - tileSize, 0);
                break;

            case 3:
                transform.position = new Vector3(transform.position.x - tileSize, transform.position.y, 0);
                break;


        }
    }
}
