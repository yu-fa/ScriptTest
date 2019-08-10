using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{

    private int hp = 100;       // 体力
    private int power = 25;     // 攻撃力
    private int mp = 53;        // 魔力


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
        if (this.mp >= 5){
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else{
            Debug.Log("MPが足りないため魔法が使えない");
        }
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        /*========================================*
         *   課題：配列を宣言して出力しましょう   *
         *========================================*/

        // 要素の個数が5のint型の配列arrayを宣言して初期化
        int[] array = { 1,5,7,10,20};

        // for文を使い配列の各要素の値を順番に出力
        for ( int i = 0; i < array.Length; i++){
            Debug.Log(array[i]);
        }

        // for文を使い配列の各要素の値を逆順に出力
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[4 - i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        // lastboss.Attack();
        // 防御用の関数を呼び出す
        // lastboss.Defence(3);

        /*========================================*
         *   課題：Magic関数　　　　　　　　　    *
         *========================================*/

        // Magic関数を10回使用
        for (int i = 0; i < 10; i++) {
            lastboss.Magic();
        }

        // 再度Magic関数使用＊メッセージ確認
        lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {

    }
}