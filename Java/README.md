# Java

Java experiments and examples built as independent projects.

## Contents

- [observable](observable/) is a Maven project demonstrating the Observer pattern
  through subjects, observers, messages, and a data sender.
- Its sources and tests follow Maven's `src/main/java` and `src/test/java` layout.

## Building and Running

Install Maven and a JDK compatible with the project's compiler settings. The
current POM targets Java 7; newer JDKs may no longer support that source level.
From this folder:

```sh
cd observable
mvn test
mvn package
java -cp target/classes com.test.App
```

Maven places compiled classes, test reports, and packaged output in `target/`,
which is ignored. Keep Java sources, tests, and the POM in version control.
