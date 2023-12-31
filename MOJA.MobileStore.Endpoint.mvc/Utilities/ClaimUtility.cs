﻿using System.Security.Claims;

namespace MOJA.MobileStore.Endpoint.mvc.Utilities
{
    public static class ClaimUtility
    {
        public static string GetUserId(ClaimsPrincipal User)
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            string userId = claimsIdentity!.FindFirst(ClaimTypes.NameIdentifier)!.Value;
            return userId;
        }
    }
}
