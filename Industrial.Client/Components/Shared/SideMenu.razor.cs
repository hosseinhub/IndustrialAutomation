﻿using Microsoft.AspNetCore.Components;
using MudBlazor;
using Industrial.Client.Models;
using Industrial.Client.Models.SideMenu;

namespace Industrial.Client.Components.Shared;

public partial class SideMenu
{
    private List<MenuSectionModel> _menuSections = new()
    {
        new MenuSectionModel
        {
            Title = "داشبورد",
            SectionItems = new List<MenuSectionItemModel>
            {
                new()
                {
                    Title = "App",
                    Icon = Icons.Material.Filled.Speed,
                    Href = "/"
                },
                new()
                {
                    Title = "لیست محصولات",
                    Icon = Icons.Material.Filled.ShoppingCart,
                    Href = "/products",
                }
                //new()
                //{
                //    Title = "Analytics",
                //    Icon = Icons.Material.Filled.Analytics,
                //    Href = "/analytics",
                //    PageStatus = PageStatus.ComingSoon
                //},
                //new()
                //{
                //    Title = "Banking",
                //    Icon = Icons.Material.Filled.Money,
                //    Href = "/banking",
                //    PageStatus = PageStatus.ComingSoon
                //},
                //new()
                //{
                //    Title = "Booking",
                //    Icon = Icons.Material.Filled.CalendarToday,
                //    Href = "/booking",
                //    PageStatus = PageStatus.ComingSoon
                //}
            }
        },

        new MenuSectionModel
        {
            Title = "مدیریت",
            SectionItems = new List<MenuSectionItemModel>
            {
                new()
                {
                    IsParent = true,
                    Title = "User",
                    Icon = Icons.Material.Filled.Person,
                    MenuItems = new List<MenuSectionSubItemModel>
                    {
                        new()
                        {
                            Title = "Profile",
                            Href = "/user/profile",
                            PageStatus = PageStatus.ComingSoon
                        },
                        new()
                        {
                            Title = "Cards",
                            Href = "/user/cards",
                            PageStatus = PageStatus.ComingSoon
                        },
                        new()
                        {
                            Title = "List",
                            Href = "/user/list",
                            PageStatus = PageStatus.ComingSoon
                        }
                    }
                },
                new()
                {
                    IsParent = true,
                    Title = "Article",
                    Icon = Icons.Material.Filled.Article,
                    MenuItems = new List<MenuSectionSubItemModel>
                    {
                        new()
                        {
                            Title = "Posts",
                            Href = "/user/posts",
                            PageStatus = PageStatus.ComingSoon
                        },
                        new()
                        {
                            Title = "Post",
                            Href = "/user/post",
                            PageStatus = PageStatus.ComingSoon
                        },
                        new()
                        {
                            Title = "New Post",
                            Href = "/user/newpost",
                            PageStatus = PageStatus.ComingSoon
                        }
                    }
                }
            }
        }
    };

    [EditorRequired] [Parameter] public bool SideMenuDrawerOpen { get; set; }
    [EditorRequired] [Parameter] public EventCallback<bool> SideMenuDrawerOpenChanged { get; set; }
    [EditorRequired] [Parameter] public bool CanMiniSideMenuDrawer { get; set; }
    [EditorRequired] [Parameter] public EventCallback<bool> CanMiniSideMenuDrawerChanged { get; set; }
    [EditorRequired] [Parameter] public UserModel User { get; set; }
}