#pragma checksum "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61fc8f7d7cebb9f496e58431b94ffa9fa23312ff"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using BlazorCRUD.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using BlazorCRUD.UI.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Sumar");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-secondary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\Pages\Counter.razor"
                                            decrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Restar");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-success");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\Pages\Counter.razor"
                                          resetCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Reset");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-warning");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\Pages\Counter.razor"
                                          dobleIncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Sumar 2");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, 
#nullable restore
#line 11 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\Pages\Counter.razor"
    mensaje

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\Pages\Counter.razor"
   
    if (currentCount >= 0) {
        mensaje = "";
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\CursosPG\CSharp\BlazorCRUD\BlazorCRUD.UI\Pages\Counter.razor"
       
    private int currentCount = 0;
    private string mensaje = "";

    private void IncrementCount()
    {
        currentCount++;
    }

    private void decrementCount()
    {
        currentCount--;
        if(currentCount < 0) {
            currentCount = 0;
            mensaje = "Parece que no puedes restarle m??s!";
        }
    }

    private void resetCount()
    {
        currentCount = 0;
    }

    private void dobleIncrementCount()
    {
        currentCount += 2;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
