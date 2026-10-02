# Dart and Flutter

Standalone Dart experiments and Flutter application projects.

## Contents

- [primalityTest.dart](primalityTest.dart) is a standalone primality-testing experiment.
- [sudoku-flutter](sudoku-flutter/) contains a Flutter Sudoku application with
  platform runners for mobile, desktop, and web.

## Running the Dart Example

Install the Dart SDK, then run from this folder:

```sh
dart run primalityTest.dart
```

## Running the Flutter Application

Install Flutter with a bundled Dart SDK compatible with the project's
`pubspec.yaml` (Dart 3.5 or later within the 3.x series). From this folder:

```sh
cd sudoku-flutter
flutter pub get
flutter run
```

Use `flutter devices` to list available targets. Each platform requires its own
toolchain; iOS and macOS builds require macOS and Xcode.

The local `flutter/` directory is ignored by this folder's existing `.gitignore`.
Flutter caches, platform dependencies, and build output are not source files;
keep application sources, assets, platform configuration, and `pubspec.lock` versioned.
