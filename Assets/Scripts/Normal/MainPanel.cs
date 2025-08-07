 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    //1获得控件
    //2监听事件
    //3更新面板
    //4显影
    public Text textName;
    public Text textLev;
    public Text textMoney;
    public Text textGem;
    public Text textPower;
    public Button butRole;
    public Button btnSkill;

    private static MainPanel panel;

    public static MainPanel Panel{
    
        get{ return panel; }
}

    // Start is called before the first frame update
    void Start()
    {
        butRole.onClick.AddListener(ClickButRole);
        btnSkill.onClick.AddListener(ShowSkillPanel);

       
    }

    //显示技能面板
    private void ShowSkillPanel()
    {
        
     
        RolePanel.Show();
    }
    public static void Hide()
    {
        ////直接销毁
        //if (panel != null)
        //{
        //    Destroy(panel);
        //    panel = null;
        //} 
        //不激活
        if (panel !=null)
        {
            Debug.Log("1111111");
            panel.gameObject.SetActive(false);
        }
    }

    public static void Show()
    {
        if (panel!=null&& panel.gameObject.activeSelf == false)
        {
            panel.gameObject.SetActive(true);
        }
        //如果有一个对象就不执行
        
       if (panel == null)
        {
            //实例化面版对象
            GameObject res = Resources.Load<GameObject>("UI/MainPanelUi");
            GameObject obj = Instantiate(res);
            obj.transform.SetParent(GameObject.Find("Canvas").transform, false);
            panel = obj.GetComponent<MainPanel>();
            panel.UpdateInfo();
        }
     

    }

    private void ClickButRole()
    {
        //点击逻辑
       

    }

    //更新逻辑
    public void UpdateInfo()
    {
        textName.text = PlayerPrefs.GetString("name", "liu");
        textLev.text=PlayerPrefs.GetInt("textLev",2).ToString();
        textMoney.text = PlayerPrefs.GetInt("textMonkey", 100).ToString();
        textGem.text=PlayerPrefs.GetInt("textGem",999).ToString();
        textPower.text = PlayerPrefs.GetInt("textPower", 999).ToString();
       
    }
}
