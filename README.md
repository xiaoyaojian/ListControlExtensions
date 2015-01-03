ListControlExtensions
=====================

This is use for asp.net mvc to extend RadioButtonList and CheckBoxList

Getting Started
=====================
1.Open your Nuget package Manager dialog 

2.Search by this keyword : **ListControlExtension**

3.Install it,and now,you can beginnning to use this extension use statement like"Html.CheckBoxListFor(....." in your view page

Methods
=====================
- Html.RadioButtonList(string name, List<SelectListItem> items, string cssClass=null)
- Html.RadioButtonListFor<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression, List<SelectListItem> items, string cssClass=null)
- Html.CheckBoxList(string name, List<SelectListItem> items,  string cssClass = null)
- Html.CheckBoxListFor<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression, List<SelectListItem> items,  string cssClass = null)
