using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image diaImg;
    public Text diaText;
    public Button addDiaBtn; // 다이아 구매 화면으로 전환
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

    public GameObject eventObj; // 이벤트 생성 시 활성화
    public Text currLevelText; // 현재 레벨
    public Text nextLevelText; // 다음 레벨

    #region Skill UI
    public GameObject skillContent; // 스킬 인벤토리
    public GameObject skillItemPrefab; // 스킬 아이템 프리팹
    public GameObject skillInfoPanel; // 스킬 정보 판넬
    #endregion

    #region Pet UI
    public Image petImg; // 펫 이미지
    public Text petNameText; // 펫 이름
    public Text petInfoTxt; // 펫 정보
    public Text priceTxt; // 펫 판매 골드
    public Image[] petLevelImgs; // 펫 레벨 이미지 배열
    public GameObject petContent; // 펫 인벤토리
    public GameObject petItemPrefab; // 펫 아이템 프리팹
    #endregion

    void Start()
    {
        mainUI.gameObject.SetActive(true);
        characterUI.gameObject.SetActive(false);
        skillUI.gameObject.SetActive(false);
        petUI.gameObject.SetActive(false);
        shopUI.gameObject.SetActive(false);
    }

    // 보유 다이아, 골드 UI 업데이트
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

    #region 메인 UI 버튼 메서드
    public void OnClickStage()
    {
        // 스테이지 씬으로 전환
    }

    public void OnClickEndlessStage()
    {
        // 무한 모드 씬으로 전환
    }

    public void OnClickEvent()
    {
        // 이벤트 판넬 활성화
    }

    public void OnClickRank()
    {
        // 랭킹 판넬 활성화
    }

    public void OnClickGoals()
    {
        // 업적 판넬 활성화
    }

    public void OnClickOption()
    {
        // 옵션 판넬 활성화
    }
    #endregion

    #region 캐릭터 UI 버튼 메서드    
    public void OnClickAtt()
    {
        // 공격력 레벨 업으로 전환
    }

    public void OnClickDef()
    {
        // 방어력 레벨 업으로 전환
    }

    public void OnClickHp()
    {
        // 체력 레벨 업으로 전환
    }

    public void OnClickStat()
    {
        // 전체 스텟 판넬 활성화
    }

    public void OnClickLevelUp()
    {
        // 레벨 업
    }
    #endregion

    #region 스킬 UI 버튼 메서드
    public void OnClickSkillItem()
    {
        // 스킬 아이템 클릭 시 스킬 정보 판넬 활성화
    }

    public void OnClickCloseSkillInfo()
    {
        // 스킬 정보 판넬 비활성화
    }
    #endregion

    #region 펫 UI 버튼 메서드
    public void OnClickUsePet()
    {
        // 펫 사용
    }

    public void OnClickSell()
    {
        // 펫 판매
    }

    public void OnClickFusion()
    {
        // 펫 합성
    }

    public void OnClickPetItem()
    {
        // 펫 아이템 클릭 시 상세 정보 업데이트
        // petImg.sprite = 선택한 펫의 이미지
        // petNameText.text = 선택한 펫의 이름
        // petInfoTxt.text = 선택한 펫의 정보
        // priceTxt.text = 선택한 펫의 판매 골드
    }
    #endregion

    #region 상점 UI 버튼 메서드
    public void OnClickBuy()
    {
        // 다이아 구매
    }

    public void OnClickPetSummon()
    {
        // 펫 뽑기
    }

    public void OnClickSkillSummon()
    {
        // 스킬 뽑기
    }
    #endregion
}
