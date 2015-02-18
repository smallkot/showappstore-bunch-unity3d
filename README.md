Showappstore Bunch Unity3d
---

It's Unity3d implementation of Showappstore for Native Gateway.

Native Gateway
---

Native Gateway allows you to create flexible native extension for cross-platform engines in easy way.

See implemetation of flurry integration as an example: https://github.com/vedi/flurry-bunch

At the moment we consider Unity3d as a primary target platform, but it's easy to create adaptors for other engimes / frameworks.

Getting Started
---

Import `native-gateway.unitypackage` and `showappstore-bunch.unitypackage` to your project. They contain all needed stuff.

Add `ShowappstoreBunch` script to a game object on your scene. No more configuration is needed.

At the moment only text sharing is supported, but it can be easily extended. Follow `ShowappstoreBunch` script to get additional details.

Related projects
---

This repository includes prebuild native libraries, the sources are available at the following URLs:

* https://github.com/smallkot/showappstore-bunch-ios.git
