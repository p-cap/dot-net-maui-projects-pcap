# Start a .net maui project via commandline

### lists the .net maui templates
- `dotnet new list`

### Installs the .net maui templates
- `dotnet new install Microsoft.Maui.Templates`

### Installs maui workload
- `dotnet workload install maui`
```
Why workloads????

With workloads, I can jsut install specific "feature packs" for my project instead of having everything included in the project

when buiilding a .Net MAUI project, we need the Andriod SDK, the iOS toolchain, and specific Windows UI libraries
```
### Create a standard MAUI app
dotnet new maui -n MyAwesomeApp

### Create a MAUI Blazor Hybrid app (if you prefer HTML/CSS for UI)
dotnet new maui-blazor -n MyHybridApp

