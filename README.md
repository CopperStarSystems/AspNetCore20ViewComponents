# Stuck?  Want to learn more about these technologies?
**Contact me on CodeMentor for Live 1:1 Help!**

[![Contact me on Codementor](https://cdn.codementor.io/badges/contact_me_github.svg)](https://www.codementor.io/copperstarconsulting?utm_source=github&utm_medium=button&utm_term=copperstarconsulting&utm_campaign=github)

# Asp.Net Core 2.0 ViewComponents
A basic example of using ViewComponents in .NET core 2.0, including ViewComponents declared in an external assembly.

# Quick Overview
The project contains 2 ViewComponents, one defined directly in the ASP.Net Core MVC project, and one defined in a separate assembly.

Each ViewComponent takes a single parameter and outputs it to the consumer along with a message indicating its source component.

Note that the external component is implemented as a simple class library, and only defines the component's behavior.  Rendering the component's output is the responsibility of a template defined in the consuming application.  This approach enables us to test the ViewComponent's behavior separately from its rendering.

For additional information, see [the Microsoft Documentation for ViewComponents](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-3.0)
