using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image diaImg;
    public Text diaText;
    public Button addDiaBtn; // ���̾� ���� ȭ������ ��ȯ
    public Image goldImg;
    public Text goldText;

    #region Taps
    public GameObject mainUI;
    public GameObject characterUI;
    public GameObject skillUI;
    public GameObject petUI;
    public GameObject shopUI;
    #endregion

    #region Tap Buttons
    public Button mainUIButton;
    public Button characterUIButton;
    public Button skillUIButton;
    public Button petUIButton;
    public Button shopUIButton;
    #endregion

    public GameObject eventObj; // �̺�Ʈ ���� �� Ȱ��ȭ
    public Text currLevelText; // ���� ����
    public Text nextLevelText; // ���� ����

    #region Skill UI
    public GameObject skillContent; // ��ų �κ��丮
    public GameObject skillItemPrefab; // ��ų ������ ������
    public GameObject skillInfoPanel; // ��ų ���� �ǳ�
    #endregion

    #region Pet UI
    public Image petImg; // �� �̹���
    public Text petNameText; // �� �̸�
    public Text petInfoTxt; // �� ����
    public Text priceTxt; // �� �Ǹ� ���
    public Image[] petLevelImgs; // �� ���� �̹��� �迭
    public GameObject petContent; // �� �κ��丮
    public GameObject petItemPrefab; // �� ������ ������
    #endregion

    void Start()
    {
        mainUI.gameObject.SetActive(true);
        characterUI.gameObject.SetActive(false);
        skillUI.gameObject.SetActive(false);
        petUI.gameObject.SetActive(false);
        shopUI.gameObject.SetActive(false);
    }

    // ���� ���̾�, ��� UI ������Ʈ
    public void UpdateUI()
    {
        /* diaText.text = GameManager.instance.dia.ToString();
         goldText.text = GameManager.instance.gold.ToString();*/
    }
    #region Tap Button Methods
    public void OnClickMainTap()
    {
        mainUI.SetActive(true);
        characterUI.SetActive(false);
        skillUI.SetActive(false);
        petUI.SetActive(false);
        shopUI.SetActive(false);
    }
    public void OnClickCharacterTap()
    {
        mainUI.SetActive(false);
        characterUI.SetActive(true);
        skillUI.SetActive(false);
        petUI.SetActive(false);
        shopUI.SetActive(false);
    }
    public void OnClickSkillTap()
    {
        mainUI.SetActive(false);
        characterUI.SetActive(false);
        skillUI.SetActive(true);
        petUI.SetActive(false);
        shopUI.SetActive(false);
    }
    public void OnClickPetTap()
    {
        mainUI.SetActive(false);
        characterUI.SetActive(false);
        skillUI.SetActive(false);
        petUI.SetActive(true);
        shopUI.SetActive(false);
    }
    public void OnClickShopTap()
    {
        mainUI.SetActive(false);
        characterUI.SetActive(false);
        skillUI.SetActive(false);
        petUI.SetActive(false);
        shopUI.SetActive(true);
    }
    #endregion

    #region ���� UI ��ư �޼���
    public void OnClickStage()
    {
        // �������� ������ ��ȯ
    }

    public void OnClickEndlessStage()
    {
        // ���� ��� ������ ��ȯ
    }

    public void OnClickEvent()
    {
        // �̺�Ʈ �ǳ� Ȱ��ȭ
    }

    public void OnClickRank()
    {
        // ��ŷ �ǳ� Ȱ��ȭ
    }

    public void OnClickGoals()
    {
        // ���� �ǳ� Ȱ��ȭ
    }

    public void OnClickOption()
    {
        // �ɼ� �ǳ� Ȱ��ȭ
    }
    #endregion

    #region ĳ���� UI ��ư �޼���    
    public void OnClickAtt()
    {
        // ���ݷ� ���� ������ ��ȯ
    }

    public void OnClickDef()
    {
        // ���� ���� ������ ��ȯ
    }

    public void OnClickHp()
    {
        // ü�� ���� ������ ��ȯ
    }

    public void OnClickStat()
    {
        // ��ü ���� �ǳ� Ȱ��ȭ
    }

    public void OnClickLevelUp()
    {
        // ���� ��
    }
    #endregion

    #region ��ų UI ��ư �޼���
    public void OnClickSkillItem()
    {
        // ��ų ������ Ŭ�� �� ��ų ���� �ǳ� Ȱ��ȭ
    }

    public void OnClickCloseSkillInfo()
    {
        // ��ų ���� �ǳ� ��Ȱ��ȭ
    }
    #endregion

    #region �� UI ��ư �޼���
    public void OnClickUsePet()
    {
        // �� ���
    }

    public void OnClickSell()
    {
        // �� �Ǹ�
    }

    public void OnClickFusion()
    {
        // �� �ռ�
    }

    public void OnClickPetItem()
    {
        // �� ������ Ŭ�� �� �� ���� ������Ʈ
        // petImg.sprite = ������ ���� �̹���
        // petNameText.text = ������ ���� �̸�
        // petInfoTxt.text = ������ ���� ����
        // priceTxt.text = ������ ���� �Ǹ� ���
    }
    #endregion

    #region ���� UI ��ư �޼���
    public void OnClickBuy()
    {
        // ���̾� ����
    }

    public void OnClickPetSummon()
    {
        // �� �̱�
    }

    public void OnClickSkillSummon()
    {
        // ��ų �̱�
    }
    #endregion
}
