# JavaScript

Browser exercises, small games, and framework-based applications.

## Contents

- Standalone HTML files cover asynchronous JavaScript, temperature conversion,
  grade calculations, and other exercises.
- [Responsive-Login-Form](Responsive-Login-Form/) contains a login form example.
- [Snake](Snake/), [SnakeNokia](SnakeNokia/), and [Tris](Tris/) contain game projects.
- [angular/plotly-chart](angular/plotly-chart/) is an Angular 16 application using Plotly.
- [SnakeNokia/Snake-Nokia](SnakeNokia/Snake-Nokia/) packages a Snake game with
  Electron Forge.
- [tests](tests/) contains additional JavaScript experiments.

## Running Browser Examples

Open a standalone HTML file in a browser. Examples that load modules or fetch
resources may need to be served over HTTP rather than opened as local files.

## Running Angular

Use a Node.js version supported by Angular 16. From this folder:

```sh
cd angular/plotly-chart
npm install
npm start
```

The project also provides `npm run build` and `npm test`.

## Running Electron

From this folder, with Node.js and npm installed:

```sh
cd SnakeNokia/Snake-Nokia
npm install
npm start
```

Use `npm run package` or `npm run make` to create desktop packages. Packaging
requirements depend on the target operating system and Electron Forge maker.

Dependencies, caches, build output, and Electron packages are ignored. Keep
application sources, assets, package manifests, and dependency lockfiles versioned.
