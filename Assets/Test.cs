using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
	{
		private int hp = 100; //体力
	    private int power = 25; //攻撃力
	    private int mp = 53;

	    //攻撃用の関数
	    public void Attack()
		{
		   Debug.Log( this.power + "のダメージを与えた");
		}
		//防御用の関数
		public void Defence(int damage)
		{
			Debug.Log( damage+"のダメージを受けた");
			//残りhpを減らす
			this.hp -= damage;
		}
		//魔法攻撃の関数
	    public void Magic()
		{
			if(this.mp > 5)
			{
				this.mp -= 5;
				Debug.Log( "魔法攻撃をした。残りMPは"+ mp + "。");
			}
			else if(mp <= 4)
			{
			   Debug.Log( "MPが足りないため魔法が使えない。");
			}
		}
	}


public class Test : MonoBehaviour
	{
		// Use this for initialization
	    void Start ()
		{
			 //array
			 int[] array = {1,2,3,4,5};
                //順に表示
                for(int i = 0; i < array.Length; i++)
				{
					Debug.Log(array[i]);
				}
				//逆順表示
				for(int i = 4; i >= 0; i--)
				{
					Debug.Log(array[i]);				
				}

			 //この下の処理に進みたい
			 //Bossクラスの変数を宣言してインスタンスを代入
			 Boss lastboss = new Boss ();
			 //攻撃用の関数を呼び出す
			 lastboss.Attack();
			 //防御用の関数を呼び出す
			 lastboss.Defence(3);		
			 for(int i = 0; i < 11; i ++)
			 	{
			 		//魔法攻撃用の関数を呼び出す
			 		lastboss.Magic();
			 	}

		}

	}
	



