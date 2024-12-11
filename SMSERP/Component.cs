 using System.Collections.Generic;

namespace ZCLINIC
{
    public class Component
    {
        public Dictionary<string, string> DataProps { get; set; }
        public Dictionary<string, string> BasicProps { get; set; }

        public Component(string CType, string CId, string CText, string CClass, string CValue, string DModal, string DHeading,
                           string DURL, string DRURL, string DScript, string DCallback, string DSubmit)
        {
            BasicProps = new Dictionary<string, string>();
            DataProps = new Dictionary<string, string>();
            if (CType != null) BasicProps.Add("type", CType);
            if (CId != null) BasicProps.Add("id", CId);
            if (CText != null) BasicProps.Add("text", CText);
            if (CClass != null) BasicProps.Add("class", CClass);
            if (CValue != null) BasicProps.Add("value", CValue);
            if (DModal != null) DataProps.Add("data-modalhorizontal", DModal);
            if (DHeading != null) DataProps.Add("data-heading", DHeading);
            if (DURL != null) DataProps.Add("data-url", DURL);
            if (DRURL != null) DataProps.Add("data-rurl", DRURL);
            if (DScript != null) DataProps.Add("data-script", DScript);
            if (DCallback != null) DataProps.Add("data-callback", DCallback);
            if (DSubmit != null) DataProps.Add("data-submit", DSubmit);
        }
    }
}
