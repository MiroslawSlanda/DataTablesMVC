# DataTablesMVC

Extendable packages pack for simplifying DataTables in your ASP.MVC projects. 

# Documentation:

```csharp
@using(var dt = Html.DataTables(Model))
{
    using(var c = dt.Columns())
    {
        c.ColumnFor(d => d.FirstName);
    }
    using(var e = dt.Events())
    {
        e.Init("init");
        using(e.Draw("draw"))
        {
            <script>
                function draw() {
                    console.log('draw');
                }
            </script>
        }
    }
}
```
