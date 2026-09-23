using UnityEngine;
public class CityGenerator : MonoBehaviour
{
    public int blocksX = 8, blocksZ = 8;
    public float blockSize = 24f;
    void Start()
    {
        for (int x = 0; x < blocksX; x++)
        for (int z = 0; z < blocksZ; z++)
        {
            float px = (x - blocksX / 2f) * blockSize;
            float pz = (z - blocksZ / 2f) * blockSize;

            var road = GameObject.CreatePrimitive(PrimitiveType.Cube);
            road.name = "Road";
            road.transform.position = new Vector3(px, -.5f, pz);
            road.transform.localScale = new Vector3(blockSize, 1, blockSize);

            var building = GameObject.CreatePrimitive(PrimitiveType.Cube);
            building.name = "Building";
            float h = Random.Range(5f, 22f);
            building.transform.position = new Vector3(px + 5f, h / 2f, pz + 5f);
            building.transform.localScale = new Vector3(9f, h, 9f);
        }
    }
}