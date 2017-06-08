using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct EnemySpawnStatus
{
    public int id;//出てくる位置
    public long spawnTime;//スポーンする時間。ミリ秒単位で管理する
    public EnemyId enemyId;//敵のID
}

public class SpawnManager : MonoBehaviour {

    string fileName;//csvファイル名
    TextAsset csvFile;
    List<string[]> csvData = new List<string[]>();
    int height = 0;

    List<EnemySpawnStatus> EnemySpawnMasterData;
    List<EnemySpawnStatus> EnemySpawnData = new List<EnemySpawnStatus>();

    public SpawnPoint[] points;

    public Enemy[] enemyData;

    static float SpawnTimeCount = 0.0f;

	// Use this for initialization
	void Start () {
        SpawnTimeCount = 0.0f;
        LoadStageData();
    }
	
	// Update is called once per frame
	void Update () {
        SpawnTimeCount += Time.deltaTime;

        if(EnemySpawnData[0].spawnTime <= SpawnTimeCount)
        {
            points[EnemySpawnData[0].id].Spawn(enemyData[(int)EnemySpawnData[0].enemyId]);
            EnemySpawnData.RemoveAt(0);
        }

        //全て出し終わったらマスターデータからコピーしてくる
        if(EnemySpawnData.Count <= 0)
        {
            EnemySpawnData = new List<EnemySpawnStatus>(EnemySpawnMasterData);
            SpawnTimeCount = 0;
        }
    }

    void LoadStageData()
    {
        EnemySpawnStatus status;
        fileName = "Stage";
        csvFile = Resources.Load("CSV/" + fileName) as TextAsset;
        StringReader reader = new StringReader(csvFile.text);

        while (reader.Peek() > -1)
        {
            string line = reader.ReadLine();
            string[] data = line.Split(',');

            //コメントがある行はぬかす
            if(data[0].IndexOf("#") >= 0)
            {
                continue;
            }

            status.enemyId = (EnemyId)int.Parse(data[0]);
            status.id = int.Parse(data[1]);
            status.spawnTime = long.Parse(data[2]);

            csvData.Add(data);

            EnemySpawnData.Add(status);
            height++;
        }
        EnemySpawnData.Sort((a,b) => (int)a.spawnTime - (int)b.spawnTime);
        EnemySpawnMasterData = new List<EnemySpawnStatus>(EnemySpawnData);
    }
}
