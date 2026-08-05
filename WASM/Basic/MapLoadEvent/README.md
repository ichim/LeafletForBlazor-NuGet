# Map events

Blazor page:

    <Map height="calc(100vh - 2rem)" width="calc(100vw - 2rem)" OnAfterMapLoaded="@OnAfterMapLoaded" />


Code block:

    @code {
        private Task OnAfterMapLoaded(MapEventArgs args)
        {
            Console.WriteLine($"lat: {args.centerOfView.latitude} long: {args.centerOfView.longitude}");
            return Task.CompletedTask;
        }
    }
