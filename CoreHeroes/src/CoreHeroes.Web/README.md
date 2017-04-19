# Web application

## Scripting with Yarn (or NPM)

```bash
info Commands available from binary scripts: copyfiles, copyup, cross-env, node-sass, npm, rimraf, stylelint, webpack
info Project commands
   - build
      npm run build:all
   - build:all
      npm run build:scss && npm run build:js
   - build:js
      npm run webpack
   - build:scss
      node-sass --output wwwroot/css --source-map true --output-style expanded --source-map-contents scss
   - build:scss:minified
      node-sass --output wwwroot/css --source-map true --output-style compressed --source-map-contents scss
   - clean
      npm run clean:all
   - clean:all
      rimraf wwwroot/
   - clean:css
      rimraf wwwroot/css
   - clean:fonts
      rimraf wwwroot/fonts
   - clean:images
      rimraf wwwroot/images
   - copy
      npm run copy:all
   - copy:all
      npm run copy:assets && npm run copy:fonts
   - copy:assets
      copyfiles -u 1 assets/*.* wwwroot && copyfiles -u 1 assets/**/* wwwroot
   - copy:fonts
      copyfiles -u 3 node_modules/font-awesome/fonts/*.* wwwroot/fonts
   - dist
      npm run clean && npm run copy && npm run build && dotnet build
   - postinstall
      dotnet restore
   - serve
      cross-env ASPNETCORE_ENVIRONMENT=Development npm run start
   - start
      npm run dist && dotnet run
   - stylelint
      stylelint "wwwroot/scss/*.scss"
   - webpack
      webpack --config ./webpack.config.js --progress
question Which command would you like to run?: 
```

## Install deps and run

```bash
yarn
yarn install v0.23.2
[1/5] 🔍  Resolving packages...
[2/5] 🚚  Fetching packages...
[3/5] 🔗  Linking dependencies...
[4/5] 📃  Building fresh packages...
[5/5] ♻️  Cleaning modules...
$ dotnet restore
  Restoring packages for /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web/CoreHeroes.Web.csproj...
  Lock file has not changed. Skipping lock file write. Path: /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web/obj/project.assets.json
  Restore completed in 1.97 sec for /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web/CoreHeroes.Web.csproj.
  
  NuGet Config files used:
      /Users/piotrblazejewicz/.nuget/NuGet/NuGet.Config
  
  Feeds used:
      https://api.nuget.org/v3/index.json
✨  Done in 24.66s.
```

```bash
yarn serve
yarn serve v0.23.2
$ cross-env ASPNETCORE_ENVIRONMENT=Development npm run start 

> coreheroes.web@1.0.0 start /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> npm run dist && dotnet run


> coreheroes.web@1.0.0 dist /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> npm run clean && npm run copy && npm run build && dotnet build


> coreheroes.web@1.0.0 clean /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> npm run clean:all


> coreheroes.web@1.0.0 clean:all /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> rimraf wwwroot/


> coreheroes.web@1.0.0 copy /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> npm run copy:all


> coreheroes.web@1.0.0 copy:all /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> npm run copy:assets && npm run copy:fonts


> coreheroes.web@1.0.0 copy:assets /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> copyfiles -u 1 assets/*.* wwwroot && copyfiles -u 1 assets/**/* wwwroot


> coreheroes.web@1.0.0 copy:fonts /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> copyfiles -u 3 node_modules/font-awesome/fonts/*.* wwwroot/fonts


> coreheroes.web@1.0.0 build /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> npm run build:all


> coreheroes.web@1.0.0 build:all /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> npm run build:scss && npm run build:js


> coreheroes.web@1.0.0 build:scss /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> node-sass --output wwwroot/css --source-map true --output-style expanded --source-map-contents scss

Rendering Complete, saving .css file...
Wrote CSS to /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web/wwwroot/css/main.css
Wrote Source Map to /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web/wwwroot/css/main.css.map
Wrote 1 CSS files to /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web/wwwroot/css

> coreheroes.web@1.0.0 build:js /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> npm run webpack


> coreheroes.web@1.0.0 webpack /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
> webpack --config ./webpack.config.js --progress

Hash: ca9ec61a57343c7d8066                                                         
Version: webpack 2.4.1
Time: 591ms
     Asset    Size  Chunks                    Chunk Names
vendors.js  428 kB       0  [emitted]  [big]  vendors
   site.js  2.7 kB       1  [emitted]         site
   [0] ./~/jquery/dist/jquery.js 268 kB {0} [built]
   [1] ./~/tether/dist/js/tether.js 56.4 kB {0} [built]
   [2] ./~/bootstrap/dist/js/bootstrap.js 99.8 kB {0} [built]
   [3] ./js/site.js 58 bytes {1} [built]
   [4] ./js/vendors.js 125 bytes {0} [built]
Microsoft (R) Build Engine version 15.1.548.43366
Copyright (C) Microsoft Corporation. All rights reserved.

  CoreHeroes.Web -> /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web/bin/Debug/netcoreapp1.1/CoreHeroes.Web.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:02.82
Hosting environment: Development
Content root path: /Users/piotrblazejewicz/git/dotnet-core-heroes/CoreHeroes/src/CoreHeroes.Web
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
```

## Author

@peterblazejewicz