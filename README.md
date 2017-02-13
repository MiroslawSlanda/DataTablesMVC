# DataTablesMVC

Extendable packages pack for simplifying DataTables in your ASP.MVC projects. 

# Documentation:

```csharp
@model IEnumerable<Product>
@using(var dt = Html.DataTables(Model))
{
    using(var c = dt.Columns())
    {
        c.ColumnFor(d => d.Name).Title("[[[Name]]]");
        c.ColumnFor(d => d.ProductNumber).Title("[[[Number]]]");
        c.ColumnFor(d => d.Color).Title("[[[Color]]]").Width("30px").Render("color");
        using (var pt = c.ColumnFor(d => d.StandardCost))
        {
            using (pt.BeginRender("standardCost"))
            {
                <script>
                    function standardCost(data, type, row) {
                    return '<strong>' + data + '</strong>';
                }
                </script>
            }
        }
    }
    using(var e = dt.Events())
    {
        e.Init("init");
        using(e.Draw("draw"))
        {
            <script>
                function draw(e, settings) {
                    console.log('draw');
                }
            </script>
        }
    }
    
    <script>
        function init(e, settings, json) {
            console.log('init');
        }
        
        function color(data, type, row) {
            return data;
        }
    </script>
}
```
