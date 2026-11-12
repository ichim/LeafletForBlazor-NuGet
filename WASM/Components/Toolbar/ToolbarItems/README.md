
# Toolbar Items

## Toggle


Buna ziua din nou,

Incerc sa aplic clase *.css customizabile si nu functioneaza. Ma poti ajuta sa-mi spui ce am gresit?

1. Componenta Blazor:

<label class="switch @className" style="margin:2px;">
    <input type="checkbox" checked="@Checked" @onchange="OnToggleChanged" }>
    <span class="slider round @className"></span>
</label>
@code {
    [Parameter]
    public bool Checked { get; set; }

    [Parameter]
    public EventCallback<bool> CheckedChanged { get; set; }
    [Parameter] public string? className { get; set; }

    private async Task OnToggleChanged(ChangeEventArgs e)
    {
        var isChecked = (bool)(e.Value ?? false);
        await CheckedChanged.InvokeAsync(isChecked);
    }
}
2. toggle.css (se afla in wwwroot/css/)

.switch {
    position: relative;
    display: inline-block;
    width: 32px;
    height: 32px;
}

    .switch input {
        opacity: 0;
        width: 0;
        height: 0;
    }

.slider {
    position: absolute;
    cursor: pointer;
    top: 11px;
    left: 0;
    right: 0;
    height: 10px;
    background-color: var(--uncheck-background-color, #ccc);
    -webkit-transition: .3s;
    transition: .3s;
}

    .slider:before {
        position: absolute;
        content: "";
        height: 16px;
        width: 16px;
        left: 1px;
        bottom: -3px;
        background-color: var(--knob-background-color, white);
        border: var(--knob-border,solid 1px lightgray);
        -webkit-transition: .3s;
        transition: .3s;
    }

input:checked + .slider {
    background-color: var(--check-background-color, #2196F3);
}

input:focus + .slider {
    box-shadow: 0 0 1px var(--check-background-color, #2196F3);
}

input:checked + .slider:before {
    -webkit-transform: translateX(14px);
    -ms-transform: translateX(14px);
    transform: translateX(14px);
}

/* Rounded sliders */
.slider.round {
    border-radius: 10px;

}

    .slider.round:before {
        border-radius: 50%;
    }

3. Aplicatia care gazduieste controlul si in care vreau sa modific proprietatile stilului:
3.1 Pagina Blazor:
<Map @ref="map"
     loadParameters="@loadParameters"
     height="calc(100vh - 4rem)"
     width="calc(100vw - 2rem)"
     OnAfterMapLoaded="@OnAfterMapLoaded">
    <Toolbar left="48px" top="12px">
        <Toggle @bind-Checked="isToggled" />
        <Toggle className="toogle-cheerful" Checked="isToggled" CheckedChanged="OnToggleChanged" />
    </Toolbar>
   
</Map>
3.2 app.css
.toogle-cheerful {
    --uncheck-background-color: #f8f8ff;
    --knob-background-color: #faebd7;
    --check-background-color: #ffbf00;
    --knob-border: solid 1px #fffacd;
}
Ce nu functioneaza? Schimbarea propreitatilor stilului nu se regaseste in pagina asa cum ma asteptam.

