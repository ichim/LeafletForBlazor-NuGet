# Map events

Blazor page:



Code block:

    @code {
        private Task OnAfterMapLoaded(MapEventArgs args)
        {
            Console.WriteLine($"lat: {args.centerOfView.latitude} long: {args.centerOfView.longitude}");
            return Task.CompletedTask;
        }
    }
