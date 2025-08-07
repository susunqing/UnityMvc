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

    //1��ÿؼ�
    //2�����¼�
    //3�������
    //4��Ӱ



    // Start is called before the first frame update
    void Start()
    {
        //2�����¼�
        btnClose.onClick.AddListener(ClickClose);
        btnLevUp.onClick.AddListener(ClickLevUp);
      
    }

    //3.��ʾ
    public static void Show()
    {
        if (panel == null)
        {
            //ʵ����������
            GameObject res = Resources.Load<GameObject>("UI/RolePanel");
            GameObject obj = Instantiate(res);
            //���ø�����
            obj.transform.SetParent(GameObject.Find("Canvas").transform, false);
            panel = obj.GetComponent<RolePanel>();
        }
        panel.gameObject.SetActive(true);
    }

    //���ؼ���ҳ�棬����������
    private void ClickClose()
    {
        Debug.Log("���Close");
        Hide();
        MainPanel.Show();
    }

    //���ؼ��ܽ���
    private void Hide()
    {
        panel.gameObject.SetActive(false);
        
    }
    private void ClickLevUp()
    {
        //��ȡ��������
        int Lev = PlayerPrefs.GetInt("textLev");
        int Hp = PlayerPrefs.GetInt("textHp");
        int Atk = PlayerPrefs.GetInt("textAtk");
        int Def = PlayerPrefs.GetInt("textDef");
        int DCrit = PlayerPrefs.GetInt("textDCrit");
        int Miss = PlayerPrefs.GetInt("textMiss");
        int Luck = PlayerPrefs.GetInt("textLuck");
        //��������
        Lev += 1;
        Hp += 10;
        Atk += 10;
        Def += 10;
        DCrit += 10;
        Miss += 10;
        Luck += 10;
        //�浽����
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

    //�������
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
