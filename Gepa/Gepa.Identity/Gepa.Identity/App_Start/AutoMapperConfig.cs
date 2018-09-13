using AutoMapper;
using Gepa.Identity.Base.Model;
using Gepa.Identity.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gepa.Identity.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(mapper =>
            {
                mapper.CreateMap<IdentityRole, RoleModel>()
                    .ForMember(destiny => destiny.RoleId, options => options.MapFrom(r => r.Id))
                    .ForMember(destiny => destiny.RoleName, options => options.MapFrom(r => r.Name));
            });
        }
    }
}