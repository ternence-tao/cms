﻿/*
namespace OPSite.Mvc
{
    using System;
    using System.Web.Mvc;
    using Spc;

    public class PermissionAttribute : FilterAttribute, IActionFilter
    {
        private global::Spc.PermissionAttribute per;
        public PermissionAttribute()
        {
            per = new OPS.OPSite.PermissionAttribute();
        }
        public PermissionAttribute(string path)
        {
            per = new OPS.OPSite.PermissionAttribute(path);
        }
      
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (UserState.Current.GroupID == (int)UserGroups.Administrator) return;
            per.Validate(UserState.Current);
        }
    }
}*/