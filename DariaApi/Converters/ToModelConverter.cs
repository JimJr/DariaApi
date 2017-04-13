namespace DariaApi.Converters
{
    using DariaApi.Contracts.Entities;
    using DariaApi.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class ToModelConverter
    {
        public static User ToModel(this UserData data)
        {
            if (data == null)
            {
                return null;
            }

            return new User
            {
                UserName = data.UserName
            };
        }
    }
}