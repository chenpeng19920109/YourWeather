﻿using Masa.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourWeather.IService;

namespace YourWeather.Razor.Pages
{
    public partial  class PageSettings
    {
        [Inject]
        IJSRuntime? JS { get; set; }

        [Inject]
        private IBrowserService? IBrowserService { get; set; }
        [Inject]
        IPopupService? IPopupService { get; set; }

        private bool _dialogExit;

        protected override async Task OnInitializedAsync()
        {
            await JS!.InvokeVoidAsync("disableBack");
        }

        private async Task ViewSourceCode()
        {
            string url = "https://github.com/Yu-Core/YourWeather";
            await IBrowserService!.OpenLink(url);
        }

        private void ExitApp()
        {
            
            Environment.Exit(0);
        }
    }
}