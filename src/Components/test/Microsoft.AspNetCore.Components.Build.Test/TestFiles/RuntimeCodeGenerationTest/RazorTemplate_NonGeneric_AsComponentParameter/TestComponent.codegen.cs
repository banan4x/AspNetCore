// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
   RenderFragment template = 

#line default
#line hidden
            (builder2) => {
                builder2.AddMarkupContent(0, "<div>Joey</div>");
            }
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                             ; 

#line default
#line hidden
            builder.OpenComponent<Test.MyComponent>(1);
            builder.AddAttribute(2, "Person", template);
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
