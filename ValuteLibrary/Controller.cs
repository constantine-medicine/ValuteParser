using Newtonsoft.Json;
using System.Linq;
using System.Net;

namespace ValuteLibrary
{
    public class Controller
    {
        public static ValuteInfo GetValuteFromUrl(string url)
        {
            url = "https://www.cbr-xml-daily.ru/daily_json.js";
            WebRequest request = (WebRequest)WebRequest.Create(url);
            HttpWebResponse response;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception)
            {
                return new ValuteInfo();
                throw;
            }


            string responseString;
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                responseString = sr.ReadToEnd();
            }

            //TODO: Сделать проверку
            var valuteInfo = JsonConvert.DeserializeObject<ValuteInfo>(responseString);
            return valuteInfo;
        }
        public static Dictionary<string, string> PrintInfo(string valuteName, Dictionary<string, ValuteFullInfo> valutes)
        {
            var current = from g in valutes where g.Key == valuteName select g;
            var dict = new Dictionary<string, string>();

            foreach (var item in current)
            {
                dict.Add("Название валюты", item.Value.Name);
                dict.Add("Значение валюты", Math.Round(item.Value.Value, 2).ToString());
                dict.Add("Предыдущее значение", Math.Round(item.Value.Previous, 2).ToString());
                dict.Add("Изменение", item.Value.GetResult());
            }
            return dict;
        }
    }
}
