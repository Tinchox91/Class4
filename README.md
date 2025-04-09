# Clase4Interfaces

Aplicación de consola en C# desarrollada con fines didácticos para demostrar el uso de **interfaces** en la programación orientada a objetos. Se utiliza un contexto simple de animales (como perros y patos) para ilustrar cómo distintas clases pueden implementar múltiples interfaces de comportamiento.

---

## 📁 Estructura del proyecto

- **Clases/**
  - `Animal.cs`: Clase base abstracta para todos los animales.
  - `Perro.cs`: Clase derivada que representa un perro, implementando `ICaminar`, `INadar`, e `IReptar`.
  - `Pato.cs`: Clase derivada que representa un pato, implementando `IVolar`, `INadar`, `ICaminar`, e `IReptar`.

- **Interfaces/**
  - `ICaminar.cs`
  - `INadar.cs`
  - `IVolar.cs`
  - `IReptar.cs`

- `Inicio.cs`: Contiene el `Main`, donde se planea agregar un menú interactivo para ejecutar acciones sobre los animales.

---

## 🧠 Conceptos aplicados

- **Herencia**
- **Abstracción**
- **Interfaces**
- **Polimorfismo**

---

## 🚀 Cómo ejecutar

1. Abrí el proyecto en Visual Studio.
2. Asegurate de que `Inicio.cs` tenga el método `Main`.
3. Ejecutá el proyecto con **Ctrl + F5**.

---

## 📝 Notas

- La lógica principal aún no está implementada, pero se planea agregar un **menú de consola** que permita al usuario elegir un animal y ejecutar diferentes acciones (caminar, nadar, volar, etc.).
- El método `mostrarDatos()` está definido como `protected` en las clases derivadas. Se podría exponer si se desea mostrar información desde el `Main`.

---

## 📌 Ejemplo de salida esperada (a futuro)

```bash
Seleccione un animal:
1. Perro
2. Pato

Seleccione una acción:
1. Caminar
2. Nadar
3. Volar
4. Reptar
