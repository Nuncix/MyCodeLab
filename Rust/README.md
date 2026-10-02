# Rust

Rust-based application experiments.

## Contents

- [multi-tool](multi-tool/) is a Tauri 2 desktop application with a Rust backend
  in `src-tauri/` and a Preact/TypeScript frontend built with Vite.

## Running the Application

Install Rust through rustup, Node.js and npm, and the
[Tauri platform prerequisites](https://v2.tauri.app/start/prerequisites/).
Linux desktop builds require the appropriate WebKitGTK and native development
packages; other operating systems have their own toolchain requirements.

From this folder:

```sh
cd multi-tool
npm install
npm run tauri dev
```

Use `npm run tauri build` to build the desktop application. `npm run dev` starts
only the Vite frontend and does not provide the native Tauri backend.

Cargo output, frontend build output, and generated Tauri schemas are ignored.
Keep Rust sources, frontend assets, project configuration, and dependency
lockfiles, including `Cargo.lock`, in version control.
