# Web application

- new BS4 markup
- Yarn or NPM for client side assets managment
- Yarn/NPM scripting for clean and simple build process
- SASS (SCSS) for CSS
- Webpack for JavaScript bundling and building. Uses ES5 but could switch to ES6 or TypeScript
- PostCSS plugins for auto prefixing and minification
- `Development`, `Stating` and `Production` support for web application 

## Scripting with Yarn (or NPM)

### Dependencies

Full fresh install including `dotnet restore`:

```bash
yarn
yarn install v0.23.2
[1/4] 🔍  Resolving packages...
[2/4] 🚚  Fetching packages...
[3/4] 🔗  Linking dependencies...
[4/4] 📃  Building fresh packages...
$ dotnet restore
  Restoring packages for /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web/CoreHeroes.Web.csproj...
  Lock file has not changed. Skipping lock file write. Path: /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web/obj/project.assets.json
  Restore completed in 1.52 sec for /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web/CoreHeroes.Web.csproj.
  
  NuGet Config files used:
      /Users/piotrblazejewicz/.nuget/NuGet/NuGet.Config
  
  Feeds used:
      https://api.nuget.org/v3/index.json
✨  Done in 21.16s.
```

### Run in `Development` mode

```bash
yarn serve
yarn serve v0.23.2
$ cross-env ASPNETCORE_ENVIRONMENT=Development npm run start:dev 

...

> postcss --use autoprefixer -o wwwroot/css/main.css wwwroot/css/main.css --no-map.inline

✔ Finished wwwroot/css/main.css (796ms)

> coreheroes.web@1.0.0 webpack /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> webpack --config ./webpack.config.js --progress

Hash: 10bcbfa6e78af6d698d9                                                         
Version: webpack 2.4.1
Time: 687ms
     Asset    Size  Chunks                    Chunk Names
vendors.js  518 kB       0  [emitted]  [big]  vendors
   site.js  2.7 kB       1  [emitted]         site
   [0] ./~/jquery/dist/jquery.js 268 kB {0} [built]
   [1] ./~/tether/dist/js/tether.js 56.4 kB {0} [built]
   [2] ./~/bootstrap/dist/js/bootstrap.js 99.8 kB {0} [built]
   [3] ./~/holderjs/holder.js 89.9 kB {0} [built]
   [4] ./Client/js/site.js 58 bytes {1} [built]
   [5] ./Client/js/vendors.js 161 bytes {0} [built]
Hosting environment: Development
Content root path: /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
```

### Run in `Production` mode

`yarn start` or `yarn serve:prod`:

```bash
yarn start
yarn start v0.23.2
$ npm run clean && npm run copy && npm run build && dotnet run 

> coreheroes.web@1.0.0 clean /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> npm run clean:all

...
> postcss -u cssnano -o wwwroot/css/main.min.css wwwroot/css/main.css --no-map.inline

✔ Finished wwwroot/css/main.css (394ms)

> coreheroes.web@1.0.0 webpack /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> webpack --config ./webpack.config.js --progress

Hash: b5a9cbdbb91ed90c4648                                                         
Version: webpack 2.4.1
Time: 4589ms
         Asset       Size  Chunks             Chunk Names
vendors.min.js     191 kB       0  [emitted]  vendors
   site.min.js  507 bytes       1  [emitted]  site
   [0] ./~/jquery/dist/jquery.js 268 kB {0} [built]
   [1] ./~/tether/dist/js/tether.js 56.4 kB {0} [built]
   [2] ./~/bootstrap/dist/js/bootstrap.js 99.8 kB {0} [built]
   [3] ./~/holderjs/holder.js 89.9 kB {0} [built]
   [4] ./Client/js/site.js 58 bytes {1} [built]
   [5] ./Client/js/vendors.js 161 bytes {0} [built]
Microsoft (R) Build Engine version 15.1.548.43366
Copyright (C) Microsoft Corporation. All rights reserved.

  CoreHeroes.Web -> /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web/bin/Debug/netcoreapp1.1/CoreHeroes.Web.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:02.99
Hosting environment: Production
Content root path: /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
```

## Author

@peterblazejewicz