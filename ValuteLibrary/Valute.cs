namespace ValuteLibrary
{
    public class Valute
    {
        public ValuteFullInfo AUD { private get; set; }
        public ValuteFullInfo AZN { private get; set; }
        public ValuteFullInfo GBP { private get; set; }
        public ValuteFullInfo AMD { private get; set; }
        public ValuteFullInfo BYN { private get; set; }
        public ValuteFullInfo BGN { private get; set; }
        public ValuteFullInfo BRL { private get; set; }
        public ValuteFullInfo HUF { private get; set; }
        public ValuteFullInfo HKD { private get; set; }
        public ValuteFullInfo DKK { private get; set; }
        public ValuteFullInfo USD { private get; set; }
        public ValuteFullInfo EUR { private get; set; }
        public ValuteFullInfo KZT { private get; set; }
        public ValuteFullInfo CAD { private get; set; }
        public ValuteFullInfo KGS { private get; set; }
        public ValuteFullInfo CNY { private get; set; }
        public ValuteFullInfo MDL { private get; set; }
        public ValuteFullInfo NOK { private get; set; }
        public ValuteFullInfo PLN { private get; set; }
        public ValuteFullInfo INR { private get; set; }
        public ValuteFullInfo RON { private get; set; }
        public ValuteFullInfo XDR { private get; set; }
        public ValuteFullInfo SGD { private get; set; }
        public ValuteFullInfo TJS { private get; set; }
        public ValuteFullInfo TRY { private get; set; }
        public ValuteFullInfo TMT { private get; set; }
        public ValuteFullInfo UZS { private get; set; }
        public ValuteFullInfo UAH { private get; set; }
        public ValuteFullInfo CZK { private get; set; }
        public ValuteFullInfo SEK { private get; set; }
        public ValuteFullInfo CHF { private get; set; }
        public ValuteFullInfo ZAR { private get; set; }
        public ValuteFullInfo KRW { private get; set; }
        public ValuteFullInfo JPY { private get; set; }

        public Dictionary<string, ValuteFullInfo> GetAllValuteInformation()
        {
            Dictionary<string, ValuteFullInfo> full = new Dictionary<string, ValuteFullInfo>();
            full.Add("AUD", AUD);
            full.Add("AZN", AZN);
            full.Add("GBP", GBP);
            full.Add("AMD", AMD);
            full.Add("BYN", BYN);
            full.Add("BGN", BGN);
            full.Add("BRL", BRL);
            full.Add("HUF", HUF);
            full.Add("HKD", HKD);
            full.Add("DKK", DKK);
            full.Add("USD", USD);
            full.Add("EUR", EUR);
            full.Add("KZT", KZT);
            full.Add("CAD", CAD);
            full.Add("KGS", KGS);
            full.Add("CNY", CNY);
            full.Add("MDL", MDL);
            full.Add("NOK", NOK);
            full.Add("PLN", PLN);
            full.Add("INR", INR);
            full.Add("RON", RON);
            full.Add("XDR", XDR);
            full.Add("SGD", SGD);
            full.Add("TJS", TJS);
            full.Add("TRY", TRY);
            full.Add("TMT", TMT);
            full.Add("UZS", UZS);
            full.Add("UAH", UAH);
            full.Add("CZK", CZK);
            full.Add("SEK", SEK);
            full.Add("CHF", CHF);
            full.Add("ZAR", ZAR);
            full.Add("KRW", KRW);
            full.Add("JPY", JPY);

            return full;
        }
    }
}