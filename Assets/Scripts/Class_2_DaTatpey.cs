using UnityEngine;

// 三條斜線是摘要 (XML語言) 用來做簡短說明，可加在類別與變數上方
/// <summary>
/// 認識 C# 資料類型
/// </summary>
public class Class_2_DaTatpey:MonoBehaviour
{
    // 變數語法:
    // 修飾詞 資料類型 變數名稱 指定 預設值;
    // 四大常用資料類型
    // 整  數 : 儲存沒有小數點的數值 int 
    // 浮點數 : 儲存有小數點的數值 float
    // 字  串 : 儲存文字，必須用雙引號 string
    // 布林值 : 儲存正與反 bool 只用兩種值 true 與 false
    public int count = 7;
    public float movespeed = 4.5f;     //浮點數必須添加F後綴
    public float turnspeed = 30.7f;   //大小 F 皆可
    public string cgaracter = "蓋倫";
    public bool isDead = false; 　   //是否死亡:否
    public bool gameOver = true;    //是否結束:是
    
}
