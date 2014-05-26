using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.ObjectModel;
using System.Web.UI.WebControls;
using System.Text;

namespace RadioButtonListHelper
{
    public static class ListControlUtil
    {
        public static MvcHtmlString GenerateHtml(string name, List<SelectListItem> codes, RepeatDirection repeatDirection, string type, object stateValue)
        {
            TagBuilder table = new TagBuilder("table");
            int i = 0;
            bool isCheckBox = type == "checkbox";
            if (repeatDirection == RepeatDirection.Horizontal)
            {
                TagBuilder tr = new TagBuilder("tr");
                foreach (var code in codes)
                {
                    i++;
                    string id = string.Format("{0}_{1}", name, i);
                    TagBuilder td = new TagBuilder("td");

                    bool isChecked = false;
                    if (isCheckBox)
                    {
                        IEnumerable<int> currentValues = stateValue as IEnumerable<int>;
                        isChecked = (null != currentValues && currentValues.Contains(Convert.ToInt32(code.Value)));
                    }
                    else
                    {
                        string currentValue = stateValue as string;
                        isChecked = (null != currentValue && code.Value == currentValue);
                    }

                    td.InnerHtml = GenerateRadioHtml(name, id, code.Text, code.Value, isChecked,type);
                    tr.InnerHtml += td.ToString();
                }
                table.InnerHtml = tr.ToString();
            }
            else
            {
                foreach (var code in codes)
                {
                    TagBuilder tr = new TagBuilder("tr");
                    i++;
                    string id = string.Format("{0}_{1}", name, i);
                    TagBuilder td = new TagBuilder("td");

                    bool isChecked = false;
                    if (isCheckBox)
                    {
                        IEnumerable<int> currentValues = stateValue as IEnumerable<int>;
                        isChecked = (null != currentValues && currentValues.Contains(Convert.ToInt32(code.Value)));
                    }
                    else
                    {
                        string currentValue = stateValue as string;
                        isChecked = (null != currentValue && code.Value == currentValue);
                    }

                    td.InnerHtml = GenerateRadioHtml(name, id, code.Text, code.Value, isChecked, type);
                    tr.InnerHtml = td.ToString();
                    table.InnerHtml += tr.ToString();
                }
            }
            return new MvcHtmlString(table.ToString());
        }

        private static string GenerateRadioHtml(string name, string id, string labelText, string value, bool isChecked, string type)
        {
            StringBuilder sb = new StringBuilder();

            TagBuilder label = new TagBuilder("label");
            label.MergeAttribute("for", id);
            label.SetInnerText(labelText);

            TagBuilder input = new TagBuilder("input");
            input.GenerateId(id);
            input.MergeAttribute("name", name);
            input.MergeAttribute("type", type);
            input.MergeAttribute("value", value);
            if (isChecked)
            {
                input.MergeAttribute("checked", "checked");
            }
            sb.AppendLine(input.ToString());
            sb.AppendLine(label.ToString());
            return sb.ToString();
        }
    }
}