using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTerrain : MonoBehaviour
{
    public GameObject Table;
    public GameObject Player;
    private static GameObject TerrainObject;
    private Vector3 TerrainObjectSize;

    private string TablePosition;
    private static List<GameObject> PlayerSetMarker = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        SpawnTerrainObject();
        StartCoroutine(delayedInit());
    }

    IEnumerator delayedInit()
    {
        yield return new WaitForSeconds(1);
        SetLocalandServerTerrainScale();
        TerrainObjectSize = TerrainObject.GetComponent<Terrain>().terrainData.size;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ASL.ASLHelper.SendAndSetNewScene("MapDetial");
        }
    }

    private void SpawnTerrainObject()
    {
        Vector3 TerrainPosition = CalculateTerrainPosition();
        ASL.ASLHelper.InstantiateASLObject("TerrainOne", TerrainPosition, Quaternion.identity, "", "", TerrainInformation);
    }

    private static void TerrainInformation(GameObject _myGameObject)
    {
        TerrainObject = _myGameObject;
    }

    private Vector3 CalculateTerrainPosition()
    {
        Vector3 TablePosition = Table.transform.position;
        Vector3 TableSacle = Table.transform.localScale;

        Vector3 TableMinimunXZ = TablePosition - TableSacle / 2;
        TableMinimunXZ.y = TableSacle.y / 2 + TablePosition.y + 0.05f;
        return TableMinimunXZ;
    }

    private Vector3 CalculateTerrainScale()
    {
        Vector3 TerrainOriginalScale = TerrainObject.GetComponent<Terrain>().terrainData.size;
        Vector3 TableScale = Table.transform.localScale;

        float XScale = Mathf.Round(TableScale.x / TerrainOriginalScale.x);
        float ZScale = Mathf.Round(TableScale.z / TerrainOriginalScale.z);
        float YScale = 150;
        Vector3 NewTableScale = new Vector3(TableScale.x, YScale, TableScale.z);
        return NewTableScale;
    }

    private void SetLocalandServerTerrainScale()
    {
        Vector3 NewTerrainSacle = CalculateTerrainScale();
        TerrainObject.GetComponent<Terrain>().terrainData.size = NewTerrainSacle;
    }
}
