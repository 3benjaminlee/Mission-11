// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Bookstore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/benjaminlee/Documents/IS413/Mission 11/Bookstore/Pages/Admin/_imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/benjaminlee/Documents/IS413/Mission 11/Bookstore/Pages/Admin/_imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/benjaminlee/Documents/IS413/Mission 11/Bookstore/Pages/Admin/_imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/benjaminlee/Documents/IS413/Mission 11/Bookstore/Pages/Admin/_imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/benjaminlee/Documents/IS413/Mission 11/Bookstore/Pages/Admin/_imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/benjaminlee/Documents/IS413/Mission 11/Bookstore/Pages/Admin/_imports.razor"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    public partial class BuyTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "/Users/benjaminlee/Documents/IS413/Mission 11/Bookstore/Pages/Admin/BuyTable.razor"
       

    [Parameter]
    public string TableTitle { get; set; } = "Buys";

    [Parameter]
    public IEnumerable<Buy> Buys { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Shipped";

    [Parameter]
    public EventCallback<int> BoughtSelected { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
