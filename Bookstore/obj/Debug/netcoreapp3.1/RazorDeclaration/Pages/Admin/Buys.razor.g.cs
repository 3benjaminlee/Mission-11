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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/buys")]
    public partial class Buys : OwningComponentBase<IBuyRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/Users/benjaminlee/Documents/IS413/Mission 11/Bookstore/Pages/Admin/Buys.razor"
       

    public IBuyRepository repo => Service;

    public IEnumerable<Buy> AllBuys { get; set; }
    public IEnumerable<Buy> UncollectedBuys { get; set; }
    public IEnumerable<Buy> CollectedBuys { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllBuys = await repo.Buys.ToListAsync();
        UncollectedBuys = AllBuys.Where(x => !x.BuyReceived);
        CollectedBuys = AllBuys.Where(x => x.BuyReceived);
    }

    public void CollectBuy(int id) => UpdateBuy(id, true);
    public void ResetBuy(int id) => UpdateBuy(id, false);

    private void UpdateBuy (int id, bool bought)
    {
        Buy b = repo.Buys.FirstOrDefault(x => x.BuyId == id);
        b.BuyReceived = bought;
        repo.SaveBuy(b);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591