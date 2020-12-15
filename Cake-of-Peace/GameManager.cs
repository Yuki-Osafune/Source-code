using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum GameState{
    Start,
    Wavecount,
    PlayStart,
    Play,
    result,
    end,
    ReStart
}

public class GameManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    int enemyNum = 0;//敵の数
    int WaveCounter = 0;
    public static GameManager Instance;
    private GameState currentGameState;
    float enemyLoc;//敵生成位置
    private Text WaveText;
    private Text Restart;
    private GameObject cakeObj;//ケーキスクリプト
    private CakeScript CakeSc;//ケーキスクリプト参照
    GameObject[] tagObjects;
    private int countUp;
    private int PrefabNum;//色が違うプレハブを呼ぶ
    private int loopcount = 0;
    private int RestartCount;
    // Start is called before the first frame update
    void Start()
    {
        WaveText = GameObject.Find("WaveText").GetComponent<Text>();
        Restart = GameObject.Find("Restart").GetComponent<Text>();
        WaveText.enabled = false;
        Restart.enabled = false;
        cakeObj = GameObject.Find("cake");
        CakeSc = cakeObj.GetComponent<CakeScript>();
        enemyNum = Mathf.Clamp(0,0,12);
        //startcoRutine("wait");
    }
    void Awake(){
        //Instance = this;
        SetCurrentState (GameState.Start);
    }

    public void SetCurrentState(GameState state){
        currentGameState = state;
        OnGameStateChanged (currentGameState);
    }

    void OnGameStateChanged(GameState state)
    {
        switch (state)
        {
            case GameState.Start:
                Debug.Log("GameState.Start");
                Invoke("StartAction",1);
                break;
            case GameState.Wavecount:
                Invoke("WaveManeg",1);
                Debug.Log("GameState.Wavecount");
                break;
            case GameState.PlayStart:
                Invoke("PlayStart",1);
                Debug.Log("GameState.PlayStart");
                break;
            case GameState.Play:
                Invoke("Play",1);
                Debug.Log("now playing");
                break;
            case GameState.result:
                Invoke("Result",1);
                break;
            case GameState.ReStart:
                Invoke("ReStart",1);
                Debug.Log("GameState.reStart");
                break;
        }
    }

    //スタートになったときの処理
    void StartAction()
    {
        Debug.Log("Startaaaaaa");
        SetCurrentState (GameState.Wavecount);
    }

    void WaveManeg()
    {
        WaveCounter = WaveCounter + 1;
        WaveText.text = "WAVE " + WaveCounter;
        WaveText.enabled = true;
        Debug.Log("waveCounter : " + WaveCounter);
        SetCurrentState (GameState.PlayStart);
    }

    void PlayStart()
    {
        enemyNum = 4 + WaveCounter;
        Debug.Log("敵のかず" + enemyNum);
        for(int i = 0; i < enemyNum; i++){
            enemyLoc = Random.Range(-100f,100f);
            PrefabNum = Random.Range(0,3);
            loopcount += 1;
            if(loopcount >= 5)
            {
                loopcount = 1;
            }
                if(loopcount == 1){
                Instantiate(enemyPrefab[PrefabNum], new Vector3(enemyLoc, 0, 100f), Quaternion.Euler(-90, 180, 0));
                }
                if(loopcount == 2){
                Instantiate(enemyPrefab[PrefabNum], new Vector3(enemyLoc, 0, -100f), Quaternion.Euler(-90, 0, 0));
                }
                if(loopcount == 3){
                Instantiate(enemyPrefab[PrefabNum], new Vector3(100f, 0, enemyLoc), Quaternion.Euler(-90, 270, 0));
                }
                if(loopcount == 4){
                Instantiate(enemyPrefab[PrefabNum], new Vector3(-100f, 0, enemyLoc), Quaternion.Euler(-90, 90, 0));
                }
        }
        SetCurrentState(GameState.Play);
    }

    void Play()
    {
        Debug.Log("WAVE " + WaveCounter + " START");
        Check("enemy");
        if(tagObjects.Length == 0 && CakeSc.cakeHP > 0)
        {
            loopcount = 0;
            Debug.Log("Play" + WaveCounter + "end " +" Again");
            Debug.Log("EndCheck " + tagObjects.Length);
            enemyNum = 0;
            SetCurrentState(GameState.Start);
        }else if(CakeSc.cakeHP > 0){
            SetCurrentState(GameState.Play);
            
        }
        if(CakeSc.cakeHP <= 0)
        {
            loopcount = 0;
            Debug.Log("cake:0");
            SetCurrentState(GameState.result);
        }
    }

    void Check(string enemy){//タグのついたオブジェクトを数える
        tagObjects = GameObject.FindGameObjectsWithTag(enemy);
        Debug.Log("Check " + tagObjects.Length);
    }

    void Result()
    {
        //ゲーム結果、製作者などなど
        foreach (GameObject enemy in tagObjects){
        Destroy(enemy);
        }
        Restart.enabled = true;
        Restart.text = "Restart : Space";
        SetCurrentState(GameState.ReStart);
    }

    void ReStart()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Restart");
            Restart.enabled = false;
            WaveText.enabled = false;
            CakeSc.cakeHP = 150;
            WaveCounter = 0;
            RestartCount = 0;
            SetCurrentState(GameState.Start);
        }else{
            SetCurrentState(GameState.ReStart);
        }
    }
    
}
