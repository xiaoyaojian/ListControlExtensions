using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Text;
using System.Linq.Expressions;
using System.Collections.ObjectModel;
using System.Web.UI.WebControls;
using RadioButtonListHelper;

namespace BM.Web.MVC.HtmlHelpers
{
    public static class ListControlExtensions
    {
        public static MvcHtmlString RadioButtonList(this HtmlHelper htmlHelper, string name, List<SelectListItem> items, RepeatDirection repeatDirection = RepeatDirection.Horizontal)
        {
            return ListControlUtil.GenerateHtml(name, items, repeatDirection, "radio", null);
        }
        public static MvcHtmlString RadioButtonListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, List<SelectListItem> items, RepeatDirection repeatDirection = RepeatDirection.Horizontal)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression<TModel, TProperty>(expression, htmlHelper.ViewData);
            string name = ExpressionHelper.GetExpressionText(expression);           
            string fullHtmlFieldName = htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);
            return ListControlUtil.GenerateHtml(fullHtmlFieldName, items, repeatDirection, "radio", metadata.Model);
        }

        public static MvcHtmlString CheckBoxList(this HtmlHelper htmlHelper, string name, List<SelectListItem> items, RepeatDirection repeatDirection = RepeatDirection.Horizontal)
        {
            return ListControlUtil.GenerateHtml(name, items, repeatDirection, "checkbox", null);
        }
        public static MvcHtmlString CheckBoxListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, List<SelectListItem> items, RepeatDirection repeatDirection = RepeatDirection.Horizontal)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression<TModel, TProperty>(expression, htmlHelper.ViewData);
            string name = ExpressionHelper.GetExpressionText(expression);
            string fullHtmlFieldName = htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);
            return ListControlUtil.GenerateHtml(fullHtmlFieldName, items, repeatDirection, "checkbox", metadata.Model);
        }
    }
}