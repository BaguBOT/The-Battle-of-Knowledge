using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

using UnityEngine.UI;


public class GamesGeography : MonoBehaviour
{
    public GameObject panelPause;
    public GameObject SelectAnuterGames;
    public GameObject geneticGame;
    public GameObject taskGame;
    void Start()
    {
        if (panelPause != null)
            panelPause.SetActive(false);
       if (SelectAnuterGames != null)
            SelectAnuterGames.SetActive(true);
    }

  
//public class CountryMap : MonoBehaviour, IPointerClickHandler
//{
//    Image CountryImg;
//    Image SelectCountry;
//    public event CountryMapEvent TapEvent;

//    void Awake()
//    {
//        CountryImg = GetComponent<Image>();
//        SelectCountry = transform.GetChild(0).GetComponent<Image>();
//        SelectCountry.sprite = Resources.Load<Sprite>("Image/Countries/" + CountryImg.sprite.name);
//    }
//    private bool IsAlphaPoint(PointerEventData eventData)
//    {
//        Vector2 localCursor;
//        RectTransformUtility.ScreenPointToLocalPointInRectangle(GetComponent<RectTransform>(), eventData.position, eventData.pressEventCamera, out localCursor);
//        Rect r = RectTransformUtility.PixelAdjustRect(GetComponent<RectTransform>(), GetComponent<Canvas>());
//        Vector2 ll = new Vector2(localCursor.x - r.x, localCursor.y - r.y);

//        int x = (int)(ll.x / r.height * CountryImg.sprite.textureRect.height);
//        int y = (int)(ll.y / r.height * CountryImg.sprite.textureRect.height);
//        if (CountryImg.sprite.texture.GetPixel(x, y).a > 0) return false;
//        else return true;
//    }
//    public void MayBeYouWantClickMe(List<CountryMap> ResultsCountryMap, PointerEventData eventData)
//    {
//        if (!IsAlphaPoint(eventData))
//        {
//            print(gameObject.name);
//            if (TapEvent != null) TapEvent(this);
//        }
//        else
//        {
//            ResultsCountryMap.Remove(this);
//            if (ResultsCountryMap.Count > 0) ResultsCountryMap[0].MayBeYouWantClickMe(ResultsCountryMap, eventData);
//        }
//    }
//    public void OnPointerClick(PointerEventData eventData)
//    {

//        if (!IsAlphaPoint(eventData))
//        {
//            print(gameObject.name);
//            if (TapEvent != null) TapEvent(this);
//        }
//        else
//        {
//            List<RaycastResult> raycastResults = new List<RaycastResult>();
//            EventSystem.current.RaycastAll(eventData, raycastResults);
//            List<CountryMap> ResultsCountryMap = raycastResults.Select(x => x.gameObject.GetComponent<CountryMap>()).ToList();
//            ResultsCountryMap.RemoveAll(x => x == null || x.gameObject == gameObject);
//            if (ResultsCountryMap.Count > 0) ResultsCountryMap[0].MayBeYouWantClickMe(ResultsCountryMap, eventData);

//        }
//    }

//    public void StopSelect()
//    {
//        StopAllCoroutines();
//        SelectCountry.color = new Color32(255, 255, 255, 0);
//    }
//    public void StartSelect()
//    {
//        StartCoroutine(Selecting());
//    }
//    IEnumerator Selecting()
//    {
//        int alpha = 0;
//        int count = 0;
//        while (true)
//        {
//            alpha = (int)Mathf.PingPong(count, 150);
//            count = count > 300 ? 0 : count + 5;
//            SelectCountry.color = new Color32(255, 255, 255, (byte)alpha);
//            yield return new WaitForFixedUpdate();
//        }
//    }
//}






public void SelectPause()
    {
        if (panelPause.activeSelf == false)
        {
            panelPause.SetActive(true);
        }
        else
        {
            panelPause.SetActive(false);
        }
    }
    public void exit()
    {
        SceneManager.LoadScene("PlayGame");
    }
}
