# 📱 Basic Blazor Hybrid Mobile App

A cross-platform mobile application built with **.NET MAUI** and **Blazor Hybrid** — combining the power of native mobile development with Razor component-based UI. Features user authentication, registration, and navigation following the **MVVM** architectural pattern.

---

## ✨ Features

- 🔐 **User Login & Registration** — secure authentication flow
- 🧭 **Multi-page Navigation** — structured routing between Blazor pages
- 📐 **MVVM Architecture** — clean separation of UI, logic, and data
- 📱 **Cross-platform** — runs on Android, iOS, Windows, and macOS from a single codebase
- 🔗 **MAUI–Blazor Interop** — native platform APIs accessible from Razor components

---

## 🛠️ Tech Stack

![.NET MAUI](https://img.shields.io/badge/.NET_MAUI-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Blazor](https://img.shields.io/badge/Blazor_Hybrid-512BD4?style=for-the-badge&logo=blazor&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)

| Technology | Purpose |
|------------|---------|
| .NET MAUI | Cross-platform native app shell |
| Blazor Hybrid | Razor component UI rendered inside MAUI WebView |
| C# | Application logic & services |
| XAML | Native page layout (MainPage.xaml) |
| CSS | Blazor component styling (wwwroot) |

---

## 🏗️ Project Structure

```
Basic-Blazor-Hybrid-Mobile-App/
├── Pages/              # Blazor Razor pages (Login, Register, Home...)
├── Shared/             # Shared layout and components (NavMenu, etc.)
├── Models/             # Data models (User, etc.)
├── ViewModels/         # MVVM ViewModels — business logic per page
├── Services/           # Service layer (auth, data access)
├── Data/               # Data access / repositories
├── States/             # App state management
├── Platforms/          # Platform-specific code (Android, iOS, Windows, Mac)
├── wwwroot/            # Static assets (CSS, JS, images)
├── Main.razor          # Root Blazor component
├── MainPage.xaml       # MAUI native host page
├── MauiInterop.cs      # Blazor ↔ MAUI native interop
└── MauiProgram.cs      # App startup & DI configuration
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022+ with **.NET MAUI** workload installed
- Android emulator or physical device (for Android target)

### Run the App

```bash
# Clone the repository
git clone https://github.com/mbilalhussain15/Basic-Blazor-Hybrid-Mobile-App.git
cd Basic-Blazor-Hybrid-Mobile-App

# Open in Visual Studio
start SampleProject1.sln
```

Select your target platform (Android / iOS / Windows) in Visual Studio and press **Run**.

---

## 🔄 How Blazor Hybrid Works

```
.NET MAUI Shell (native)
        ↓
  MainPage.xaml          ← MAUI native host page
        ↓
  BlazorWebView          ← renders Blazor inside native WebView
        ↓
  Main.razor             ← root Blazor component
        ↓
  Pages/*.razor          ← individual app pages
        ↓
  MauiInterop.cs         ← bridge to native MAUI APIs
```

---

## 📄 License

MIT © [Bilal Hussain](https://github.com/mbilalhussain15)
