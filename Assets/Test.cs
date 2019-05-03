using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // 魔力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法攻撃用の関数
    public void Magic()
    {
        if (this.mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

        else
        {
            //残りmpを減らす
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");

        }
    }
}

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 配列を初期化する
        int[] array = { 1, 2, 3, 4, 5 };

        // 配列の要素数だけ順番に処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        // 配列の要素数だけ逆順に処理を繰り返す
        for (int i = array.Length -1; 0 <= i; i--)
        {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 魔法攻撃用の関数を呼び出す
        for(int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}