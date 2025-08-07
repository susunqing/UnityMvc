using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RolePanel : MonoBehaviour
{

    public Text textLev;
    public Text textHp;
    public Text textAtk;
    public Text textDef;
    public Text textDCrit;
    public Text textMiss;
    public Text textLuck;
    public Button btnClose;
    public Button btnLevUp;
    private static RolePanel panel;

    //1获得控件
    //2监听事件
    //3更新面板
    //4显影



    // Start is called before the first frame update
    void Start()
    {
        //2监听事件
        btnClose.onClick.AddListener(ClickClose);
        btnLevUp.onClick.AddListener(ClickLevUp);
      
    }

    //3.显示
    public static void Show()
    {
        if (panel == null)
        {
            //实例化面板对象
            GameObject res = Resources.Load<GameObject>("UI/RolePanel");
            GameObject obj = Instantiate(res);
            //设置父物体
            obj.transform.SetParent(GameObject.Find("Canvas").transform, false);
            panel = obj.GetComponent<RolePanel>();
        }
        panel.gameObject.SetActive(true);
    }

    //隐藏技能页面，返回主界面
    private void ClickClose()
    {
        Debug.Log("点击Close");
        Hide();
        MainPanel.Show();
    }

    //隐藏技能界面
    private void Hide()
    {
        panel.gameObject.SetActive(false);
        
    }
    private void ClickLevUp()
    {
        //获取本地数据
        int Lev = PlayerPrefs.GetInt("textLev");
        int Hp = PlayerPrefs.GetInt("textHp");
        int Atk = PlayerPrefs.GetInt("textAtk");
        int Def = PlayerPrefs.GetInt("textDef");
        int DCrit = PlayerPrefs.GetInt("textDCrit");
        int Miss = PlayerPrefs.GetInt("textMiss");
        int Luck = PlayerPrefs.GetInt("textLuck");
        //升级规则
        Lev += 1;
        Hp += 10;
        Atk += 10;
        Def += 10;
        DCrit += 10;
        Miss += 10;
        Luck += 10;
        //存到本地
        PlayerPrefs.SetInt("textLev", Lev);
        PlayerPrefs.SetInt("textHp",Hp);
        PlayerPrefs.SetInt("textAtk",Atk);
        PlayerPrefs.SetInt("textDef",Def);
        PlayerPrefs.SetInt("textDcrit",DCrit);
        PlayerPrefs.SetInt("textMiss",Miss);
        PlayerPrefs.SetInt("textLuck",Luck);
        UpdateInfo();
    MainPanel.Panel.UpdateInfo();
    }

    //更新面板
    public void UpdateInfo()
    {
        textLev.text = PlayerPrefs.GetInt("textLev", 10).ToString();
        textHp.text = PlayerPrefs.GetInt("textHp", 110).ToString();
        textAtk.text = PlayerPrefs.GetInt("textAtk", 120).ToString();
        textDef.text = PlayerPrefs.GetInt("textDef", 110).ToString();
        textDCrit.text = PlayerPrefs.GetInt("textDCrit", 210).ToString();
        textMiss.text = PlayerPrefs.GetInt("textMiss", 100).ToString();
        textLuck.text = PlayerPrefs.GetInt("textLuck", 1110).ToString();

    }
}
