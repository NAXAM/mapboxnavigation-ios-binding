<img src="./art/repo_header.png" alt="Mapbox Navigation for Xamarin.iOS" width="728" />

# Mapbox Navigation for Xamarin.iOS
A Xamarin.iOS binding library for [Mapbox](https://www.mapbox.com/navigation-sdk/) library.

## About
This project is maintained by Naxam Co.,Ltd.<br>
We specialize in developing mobile applications using Xamarin and native technology stack.<br>

**Looking for developers for your project?**<br>

<a href="mailto:tuyen@naxam.net"> 
<img src="https://github.com/NAXAM/naxam.github.io/blob/master/assets/img/hire_button.png?raw=true" height="40"></a> <br>

## Installation

```
Install-Package Naxam.MapboxNavigation.iOS
```

## Usage

Plz follow the official guide [here](https://www.mapbox.com/navigation-sdk/).

## License

Mapbox Navigation binding library for iOS is released under the MIT license.
See [LICENSE](./LICENSE) for details.

# Get our showcases on AppStore/PlayStore
Try our showcases to know more about our capabilities. 

<a href="https://itunes.apple.com/us/developer/tuyen-vu/id1255432728/" > 
<img src="https://github.com/NAXAM/imagepicker-android-binding/raw/master/art/apple_store.png" width="117" height="34"></a>

<a href="https://play.google.com/store/apps/developer?id=NAXAM+CO.,+LTD" > 
<img src="https://github.com/NAXAM/imagepicker-android-binding/raw/master/art/google_store.png" width="117" height="34"></a>

Contact us if interested.

<a href="mailto:tuyen@naxam.net"> 
<img src="https://github.com/NAXAM/naxam.github.io/blob/master/assets/img/hire_button.png" height="34"></a> <br>
<br>

Follow us for the latest updates<br>[![Twitter URL](https://img.shields.io/twitter/url/http/shields.io.svg?style=social)](https://twitter.com/intent/tweet?text=https://github.com/NAXAM/mapboxnavigation-ios-binding)
[![Twitter Follow](https://img.shields.io/twitter/follow/naxamco.svg?style=social)](https://twitter.com/naxamco)

# Build NuGet package

- `carthage update --platform iOS`: Pulls in the native dependencies and builds them for iOS
- `sh copy-frameworks.sh`: Copies the build output from `carthage` to a folder where the C# project will pull them from
- Open the solution file, build in Release mode.
- Update `libspec.nuget`, if needed
- Run `nuget pack` to generate the NuGet Package
