#pragma checksum "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 3-4\car-dealership\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94ff6357fd14d8846a97fd9eba4cbbc06fed21cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 3-4\car-dealership\Views\Home\Index.cshtml"
using CarDealership.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94ff6357fd14d8846a97fd9eba4cbbc06fed21cb", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Welcome to the Car Dealership!!</h1>\r\n<ul>\r\n");
#nullable restore
#line 5 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 3-4\car-dealership\Views\Home\Index.cshtml"
 if (Model.Count == 0)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No cars! go buy some.</p>\r\n");
#nullable restore
#line 8 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 3-4\car-dealership\Views\Home\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 3-4\car-dealership\Views\Home\Index.cshtml"
 if (Model.Count != 0)
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 3-4\car-dealership\Views\Home\Index.cshtml"
   foreach(Car car in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>Make/Model: ");
#nullable restore
#line 13 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 3-4\car-dealership\Views\Home\Index.cshtml"
               Write(car.MakeModel);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Car Price:");
#nullable restore
#line 13 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 3-4\car-dealership\Views\Home\Index.cshtml"
                                        Write(car.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Mileage: ");
#nullable restore
#line 13 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 3-4\car-dealership\Views\Home\Index.cshtml"
                                                            Write(car.Miles);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 14 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 3-4\car-dealership\Views\Home\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 3-4\car-dealership\Views\Home\Index.cshtml"
   
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<a href=\"/car/form\">Click here to list a new vehicle!</a>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
