using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Text;
using System.Linq.Expressions;
using System.Collections.ObjectModel;
using System.Web.UI.WebControls;

namespace ListControl.Extension
{
    public static class ListControlExtensions
    {
        public static MvcHtmlString RadioButtonList(this HtmlHelper htmlHelper, string name, List<SelectListItem> items, string cssClass=null,bool disabled=false)
        {
            return ListControlUtil.GenerateHtml(name, items, ControlType.Radio, null, cssClass, disabled);
        }
        public static MvcHtmlString RadioButtonListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, List<SelectListItem> items, string cssClass = null, bool disabled = false)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression<TModel, TProperty>(expression, htmlHelper.ViewData);
            string name = ExpressionHelper.GetExpressionText(expression);
            string fullHtmlFieldName = htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);
            return ListControlUtil.GenerateHtml(fullHtmlFieldName, items, ControlType.Radio, metadata.Model, cssClass, disabled);
        }

        public static MvcHtmlString CheckBoxList(this HtmlHelper htmlHelper, string name, List<SelectListItem> items, string cssClass = null, bool disabled = false)
        {
            return ListControlUtil.GenerateHtml(name, items, ControlType.CheckBox, null, cssClass, disabled);
        }
        public static MvcHtmlString CheckBoxListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, List<SelectListItem> items, string cssClass = null, bool disabled = false)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression<TModel, TProperty>(expression, htmlHelper.ViewData);
            string name = ExpressionHelper.GetExpressionText(expression);
            string fullHtmlFieldName = htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);
            return ListControlUtil.GenerateHtml(fullHtmlFieldName, items, ControlType.CheckBox, metadata.Model, cssClass, disabled);
        }
    }
}