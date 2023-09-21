using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp_Shop : MonoBehaviour
{
    private List<int> ShopInventory;
    private ItemStatsManager itemStatsManager;
    private ShopItemBar shopItemBar;
    [SerializeField] public Transform[] SpawnPoints;
    [SerializeField] public GameObject ShopItemBarPrefab;
    private GameObject ButtonUI;
    private List<GameObject> Bars;
    private PlayerInfo playerInfo;
    private bool startIsRun = true;

    private List<List<GameObject>> Pages;
    private int currentPageIndex = 0; // 현재 페이지 인덱스

    private void Start()
    {
        Bars = new List<GameObject>();
        ShopInventory = new List<int>();
        AddItem(4);
        AddItem(5);
        AddItem(6);
        AddItem(7);
        AddItem(8);
        AddItem(9);
        AddItem(10);

        Pages = new List<List<GameObject>>();
        CreatePages(); // 페이지 생성 함수 호출

        ShowPage(currentPageIndex); // 시작 시 첫 번째 페이지 보이기

        startIsRun = false;
    }

    private void CreatePages()
    {
        int Cur;
        int Count = 0;
        List<GameObject> currentPage = new List<GameObject>();

        for (int i = 0; i < ShopInventory.Count; i++)
        {
            if (Count % 3 == 0)
            {
                if (currentPage.Count > 0)
                {
                    Pages.Add(currentPage);
                }
                currentPage = new List<GameObject>();
                Count = 0;
            }

            GameObject ShopItemBar = Instantiate(ShopItemBarPrefab, SpawnPoints[Count].position, Quaternion.identity);
            Cur = ShopInventory[i];
            if (Cur != 0)
            {
                shopItemBar = ShopItemBar.GetComponent<ShopItemBar>();
                shopItemBar.UpdateUI(itemStatsManager.GetItem(Cur));
                shopItemBar.SetPlayerInfo(playerInfo);
            }
            Bars.Add(ShopItemBar);
            currentPage.Add(ShopItemBar);
            Count++;
        }

        if (currentPage.Count > 0)
        {
            Pages.Add(currentPage);
        }
    }

    private void ShowPage(int pageIndex)
    {
        // 모든 아이템 숨기기
        foreach (GameObject slot in Bars)
        {
            slot.SetActive(false);
        }

        // 현재 페이지의 아이템 보이기
        List<GameObject> currentPage = Pages[pageIndex];
        foreach (GameObject slot in currentPage)
        {
            slot.SetActive(true);
        }
    }

    // 다음 페이지로 이동하는 함수
    public void NextPage()
    {
        if (currentPageIndex < Pages.Count - 1)
        {
            currentPageIndex++;
            ShowPage(currentPageIndex);
        }
    }

    // 이전 페이지로 이동하는 함수
    public void PreviousPage()
    {
        if (currentPageIndex > 0)
        {
            currentPageIndex--;
            ShowPage(currentPageIndex);
        }
    }

    // 나머지 메서드는 이전 코드와 동일하게 유지합니다...

    private void OnEnable()
    {
        if (!startIsRun)
        {
            if (Bars != null)
            {
                for (int i = 0; i < Bars.Count; i++)
                {
                    Bars[i].SetActive(true);
                }
            }
        }
    }

    public void SetButtonUI(GameObject ButtonUI)
    {
        this.ButtonUI = ButtonUI;
    }

    public void ClickCloseButton()
    {
        foreach (GameObject slot in Bars)
        {
            slot.SetActive(false);
        }
        ButtonUI.SetActive(true);
        this.gameObject.SetActive(false);
    }
    public void AddItem(int ItemNumber)
    {
        ShopInventory.Add(ItemNumber);
    }

    public void SetItemStatesManager(ItemStatsManager itemStatsManager)
    {
        this.itemStatsManager = itemStatsManager;
    }

    public void SetPlayerInfo(PlayerInfo playerInfo)
    {
        this.playerInfo = playerInfo;
    }
 
}
